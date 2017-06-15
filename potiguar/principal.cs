using System.Xml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.OleDb;
using System.Globalization;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Bematech;
using Bematech.Texto;
using Bematech.CodigosDeBarras;
using Bematech.Comunicacao;
using Bematech.MiniImpressoras;

namespace potiguar
{
    public partial class principal : Form
    {
        //Variáveis públicas
        public int ultimonumero = 0;
        public int[] listanumeroSessao = new int[100];
        Random rdn = new Random(); // gerar numeros aleatorio
        string ret;
        string cod_ativacao = "";
        sql c = new sql();
        string cnpj = "";
        string cnpjSH = "";
        string ie = "";
        string ac = "";
        double aliquota = 0;
        string usuario = "Desenvolvimento";
        string sat = "";

        public int random() {
            bool flag = true;
            int num = 0;
            int i=0;

            if (ultimonumero == 100)
                ultimonumero = 0;
            
            while(flag){
                num = rdn.Next(999999999);
                flag = false;
                for (i = 0; i < listanumeroSessao.Length; i++)
                {
                    if(num == listanumeroSessao[i])
                        flag = true;
                }
            }

            listanumeroSessao[ultimonumero] = num;
            ultimonumero = (ultimonumero + 1);
            return num;
        }

        //Converter XML para UTF8
        private string ConverterToUTF8(string dados)  // sempre mandar os dados para o sat em UT8
        {
            byte[] utf16Bytes = Encoding.Unicode.GetBytes(dados);
            byte[] utf8Bytes = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, utf16Bytes);

            return Encoding.Default.GetString(utf8Bytes);
        }

        //Separa por meio de delimitadores
        private string Sep_Delimitador(char sep, int posicao, string dados)
        {
            try
            {
                string[] ret_dados = dados.Split(sep);
                return ret_dados[posicao];
            }
            catch
            {           
                return "";
            }
        }

        //Le um arquivo TXT de venda
        private string LerArqTxt(string NomeArq)
        {
            try
            {
                StreamReader arq = new StreamReader(NomeArq);
                NomeArq = arq.ReadToEnd();
                arq.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString(), "Erro");
                return "";
            }
            return ConverterToUTF8(NomeArq);
        }

        //Converter para Base 64
        private string Base64ToString(string base64)  // caso queira tirar o arquivo de base 64
        {
            byte[] arq;

            System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();

            arq = Convert.FromBase64String(base64);
            base64 = enc.GetString(arq);
            return base64;
        }   

        public principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbDataReader dados = c.consulta("select * from estabelecimentos");
                if (dados.Read())
                {
                    cod_ativacao = dados.GetString(4);
                    cnpj = dados.GetString(1);
                    ie = dados.GetString(3);
                    cnpjSH = cnpj;
                    ac = dados.GetString(2);
                    aliquota = Convert.ToDouble(dados.GetValue(6).ToString());
                    sat = dados.GetString(7);
                }
                
                //ret = Marshal.PtrToStringAnsi(FuncoesSATDECL.AtivarSAT(random(), 1, cod_ativacao, cnpj, 35));
                c.auditoria(usuario, "INICIAR SISTEMA");

                lblSubtotal.Text = "Total de Itens: 0 | Subtotal R$ 0,00";

                string sql = "select * from modalidades";
                dados = c.consulta(sql);

                cboModalidade.Items.Clear();                                                                                                                                                                                                                                                                                        
                while (dados.Read())
                {
                    string str = dados.GetValue(0).ToString();
                    str += "|";
                    str += dados.GetString(1);
                    cboModalidade.Items.Add(str);
                }
                cboModalidade.SelectedIndex = 0;
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aTIVARSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ret = Marshal.PtrToStringAnsi(FuncoesSATDECL.ConsultarSAT(rdn.Next(999999)));
            c.inserir("insert into logSat (ses,msg,err,dat) values ('"+Sep_Delimitador('|', 0, ret)+"','"+Sep_Delimitador('|', 2, ret)+"','"+Sep_Delimitador('|', 1, ret)+"','"+DateTime.Now+"')");
            MessageBox.Show(Sep_Delimitador('|', 2, ret));
            c.auditoria(usuario, "CONSULTAR SAT");                      

        }

        private void principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void testarSATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                String teste = "<?xml version='1.0' encoding='UTF-8'?><CFe><infCFe versaoDadosEnt='0.04'><ide><CNPJ>" + cnpj + "</CNPJ><signAC>000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000</signAC><numeroCaixa>115</numeroCaixa></ide><emit><CNPJ>" + cnpj + "</CNPJ><IE>" + ie + "</IE><IM>123123</IM><cRegTribISSQN>1</cRegTribISSQN><indRatISSQN>N</indRatISSQN></emit><dest /><det nItem='1'><prod><cProd>01</cProd><xProd>Carne</xProd><CFOP>5000</CFOP><uCom>un</uCom><qCom>1.0000</qCom><vUnCom>2.100</vUnCom><indRegra>A</indRegra></prod><imposto><ICMS><ICMS00><Orig>0</Orig><CST>00</CST><pICMS>5.00</pICMS></ICMS00></ICMS><PIS><PISAliq><CST>01</CST><vBC>2.10</vBC><pPIS>1.0000</pPIS></PISAliq></PIS><PISST><vBC>1.10</vBC><pPIS>1.0000</pPIS></PISST><COFINS><COFINSAliq><CST>01</CST><vBC>1.00</vBC><pCOFINS>1.0000</pCOFINS></COFINSAliq></COFINS></imposto></det><pgto><MP><cMP>01</cMP><vMP>33.00</vMP></MP></pgto><total /></infCFe></CFe>";
                ret = Marshal.PtrToStringAnsi(FuncoesSATDECL.TesteFimAFim(random(), cod_ativacao, teste));
                c.inserir("insert into logSat (ses,msg,err,dat,arq,ale,cfe,ncf) values ('" + Sep_Delimitador('|', 0, ret) + "','" + Sep_Delimitador('|', 2, ret) + "','" + Sep_Delimitador('|', 1, ret) + "','" + DateTime.Now + "','" + Sep_Delimitador('|', 5, ret) + "','','" + Sep_Delimitador('|', 8, ret) + "','" + Sep_Delimitador('|', 7, ret) + "')");
                MessageBox.Show(ret);
                c.auditoria(usuario, "TESTAR SAT"); 
            }catch(ArgumentException erro){
                MessageBox.Show(erro.Message);
            }
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
                
        }

        private void extrairLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ret = Marshal.PtrToStringAnsi(FuncoesSATDECL.ExtrairLogs(random(), cod_ativacao));
                
                string log = Base64ToString(Sep_Delimitador('|', 5, ret));
                log = log.Substring(200000);
                c.inserir("insert into logSat (ses,msg,err,dat,arq) values ('" + Sep_Delimitador('|', 0, ret) + "','" + Sep_Delimitador('|', 2, ret) + "','" + Sep_Delimitador('|', 1, ret) + "','" + DateTime.Now + "','" + log+ "')");
                //MessageBox.Show("");
                c.auditoria(usuario, "LOG SAT");
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }

            try
            {
                
            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.fechar();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {           
            
            string xml = "";
            xml += "<?xml version='1.0' encoding='UTF-8'?>";
            xml += "<CFe>";
	        xml += "<infCFe versaoDadosEnt='0.06'>";
		    xml += "<ide>";
			xml += "<CNPJ>"+cnpjSH+"</CNPJ>";
			xml += "<signAC>"+ac+"</signAC>";
			xml += "<numeroCaixa>123</numeroCaixa>";
		    xml += "</ide>";
		    xml += "<emit>";
			xml += "<CNPJ>"+cnpj+"</CNPJ>";
			xml += "<IE>"+ie+"</IE>";
            xml += "<indRatISSQN>N</indRatISSQN>";
		    xml += "</emit>";

            if (!txtCPF.Text.Equals(""))
            {
                xml += "<dest>";
                if (txtCPF.Text.Count() == 11)
                    xml += "<CPF>" + txtCPF.Text + "</CPF>";
                else
                    xml += "<CNPJ>" + txtCPF.Text + "</CNPJ>";
                xml += "</dest>";
            }
            else
            {
                xml += "<dest></dest>"; 
            }

            for (int i = 0; i < lstProd.Items.Count; i++)
            {
                xml += "<det nItem='"+i+1+"'>";
			    xml += "<prod>";
                string produto = lstProd.Items[i].ToString();
                int codProd = Convert.ToInt16(produto.Split('|')[0]);
				xml += "<cProd>"+codProd+"</cProd>";

                OleDbDataReader dados = c.consulta("select * from produtos where cod = "+codProd);
                dados.Read();
                
                string descricao = dados.GetString(2);
                double preco = Convert.ToDouble(dados.GetValue(3));
                int ini = produto.IndexOf('*')+1;
                int fim = produto.IndexOf('=');
                string aux = produto.Substring(ini, fim-ini);
                double qtd = Convert.ToDouble(aux);
                string un = dados.GetString(4);
                int ncm = Convert.ToInt32(dados.GetValue(5));
                int cfop = Convert.ToInt32(dados.GetValue(6));
                int imposto = Convert.ToInt32(dados.GetValue(7));

                dados = c.consulta("select * from imposto where cod = "+imposto);
                dados.Read();

                xml += "<xProd>"+descricao+"</xProd>";
                xml += "<NCM>"+ncm+"</NCM>";
				xml += "<CFOP>"+cfop+"</CFOP>";
				xml += "<uCom>"+un+"</uCom>";
				xml += "<qCom>"+c.formatNumber2(qtd,4)+"</qCom>";
				xml += "<vUnCom>"+c.formatNumber2(preco,2)+"</vUnCom>";
				xml += "<indRegra>A</indRegra>";
				//xml += "<vDesc>0.00</vDesc>";
				//xml += "<vOutro>0.00</vOutro>";
			    xml += "</prod>";
                        
                string icms = dados.GetString(1);
                string pis = dados.GetString(2);
                string cofins = dados.GetString(3);
                string origem = dados.GetString(4);

                xml += "<imposto>";
				xml += "<ICMS>";
				xml += "<"+icms+">";
				xml += "<Orig>"+origem+"</Orig>";

                if(icms.Equals("ICMS00") || icms.Equals("ICMS40")|| icms.Equals("ICMS40"))
                    xml += "<CST>"+dados.GetString(5)+"</CST>";
                else{
                    if(icms.Equals("ICMSSN102") || icms.Equals("ICMSSN900"))
                        xml += "<CSOSN>"+dados.GetString(7)+"</CSOSN>";
                    }

                if (icms.Equals("ICMS00") || icms.Equals("ICMSSN900"))
                    xml += "<pICMS>" + dados.GetString(6) + "</pICMS>";

                xml += "</"+icms+">";
				xml += "</ICMS>";
				
                xml += "<PIS>";
                xml += "<"+pis+">";
				xml += "<CST>"+dados.GetString(8)+"</CST>";

                /*IMPEMENTAR DEPOIS
                 * if(icms.Equals("PISAliq") || icms.Equals("PISQTDE")|| icms.Equals("PISNT")|| icms.Equals("PISSN"))
                
                else{
                    if(icms.Equals("ICMS00") ||icms.Equals("ICMSSN900"))
                        xml += "<pICMS>"+dados.GetString(6)+"</pICMS>";
                    else{
                        if(icms.Equals("ICMSSN102") || icms.Equals("ICMSSN900"))
                            xml += "<CSOSN>"+dados.GetString(7)+"</CSOSN>";
                    }
                }
                */
				xml += "</"+pis+">";	
				xml += "</PIS>";
				
                xml += "<COFINS>";
			    xml += "<"+cofins+">";
                xml += "<CST>"+dados.GetString(8)+"</CST>";
				xml += "</"+cofins+">";
				xml += "</COFINS>";                                 
			    xml += "</imposto>";
                xml += "<infAdProd>Consumido no local</infAdProd>";
                xml += "</det>";
            }

            xml += "<total>";
			//xml += "<DescAcrEntr>";
			//xml += "<vDescSubtot>0.00</vDescSubtot>";
			//xml += "</DescAcrEntr>";
            //xml += "<vCFeLei12741>0.00</vCFeLei12741>";
		    xml += "</total>";
		    
            xml += "<pgto>";
			

            for(int i=0;i<lstModalidade.Items.Count;i++)
            {
                xml += "<MP>";
                string cod = "000"+lstModalidade.Items[i].ToString().Split('|')[1];
				xml += "<cMP>"+cod.Substring(cod.Length-2,2)+"</cMP>";
				xml += "<vMP>"+c.formatNumber2(Convert.ToDouble(lstModalidade.Items[i].ToString().Split('|')[0]),2)+"</vMP>";
                xml += "</MP>";
            }   

			
		    xml += "</pgto>";
		    //xml += "<infAdic>";
            //xml += "<infCpl>ICMS a ser recolhido conforme LC 123/2006 - Simples Nacional</infCpl>";
            //xml += "<obsFisco xCampo='xCampo1'>";
            //xml += "<xTexto>xTexto1</xTexto>";
			//xml += "</obsFisco>";
		    //xml += "</infAdic>";
	        xml += "</infCFe>";
            xml += "</CFe>";

            try
            {
                xml = ConverterToUTF8(xml);
                //ret = Marshal.PtrToStringAnsi(FuncoesSATDECL.EnviarDadosVenda(random(), cod_ativacao, xml));
                ret = "223064259|06000|0000|Emitido com sucesso + conteÃºdo notas|||PENGZT48aW5mQ0ZlIElkPSJDRmUzNTE1MTExMTc4Mjc2NTAwMDE0NzU5MDAwMDYyMTU5MDAwMDAxNjY2MTE0MCIgdmVyc2FvPSIwLjA2IiB2ZXJzYW9EYWRvc0VudD0iMC4wNiIgdmVyc2FvU0I9IjAxMDIwMCI+PGlkZT48Y1VGPjM1PC9jVUY+PGNORj42NjYxMTQ8L2NORj48bW9kPjU5PC9tb2Q+PG5zZXJpZVNBVD4wMDAwNjIxNTk8L25zZXJpZVNBVD48bkNGZT4wMDAwMDE8L25DRmU+PGRFbWk+MjAxNTExMTk8L2RFbWk+PGhFbWk+MTY0OTAxPC9oRW1pPjxjRFY+MDwvY0RWPjx0cEFtYj4xPC90cEFtYj48Q05QSj4xMTc4Mjc2NTAwMDE0NzwvQ05QSj48c2lnbkFDPlc0TG5sVS9HS2tCTVdSa1VsL1I5TU5ac1Fpa2RoQXRDeUt5bis2Q3orN2dKTlZYZEtFRGtOK0wwNHFCbGp3ek9SVDhwZ3FCRVNsS2t4Y1ByTjd0bHBPb0RHSHVjNzBNbndNKzRZYlVYcUxSRURWcFRQMTFkQnp1KzN1LzVHVXRPZDZXeXZpZlRLVlVNNUg5ejBJc1VkWUhzYTRuU2luVXNhcnkwamVTVVU0WUdlekZLYVMwblNONmY0MFVYemZESWk5YUJNNW55cGo0N0k4ZldWaDVVQzRiMFdHVENEK2JYd01oYXdzRkUyU3JjUXg0ZGo0bnJKT3puUzkwZ00zSkp2eUhEUWJHeElUVG1TUkxSb0kyMmxURkdKcUZPY29KR0YzREk0TjRHdnowT2NNMm1UaWN4WFdxOUYyNEhsbHJDQWRLcnJiTXBwQ0t5NjhPdUlNL1d5Zz09PC9zaWduQUM+PGFzc2luYXR1cmFRUkNPREU+TTV6Zk9CK0NWb3lNRi9jN3ljbGQ0ZEYyVTJYeUk3QVlPZHRDbGZaNGRVd0lEWkRsekV5cU5JZ1FjWjBIOUNPNStGcTFSa21IcmRyVTdZUFR4ZkxsVGl4QkdudTRibWdETXVyWVN2d0VuUVdadlZCY24vSmMyK25MRDArakxpc0ZnV2hJOTZScUJaRVZmdTA3d1RSajdxQ1V0aVRzdGlFenRMYk9pcGg5bUZab0xwekY1WnphVXpTMnNGWmcxdEVMQmZneXZSTGRIUWNlclVlZVZDallTTncvSjJZN01ZeUtXYVlyY1RhS1ZjY1hTUGI1eSt6NnZIdTI4VUh4eEkwdlQ1VERNZ3JSRGVyTFRuN3JnV2pnRzJjb1l2eGJUNExRM1R6dzI1Qmh1ci9mVjZtWDV0S0YzZXRzS3hJZkFNZHlkR29VcHB0U0VvYUZtNkpxeTdTRXlnPT08L2Fzc2luYXR1cmFRUkNPREU+PG51bWVyb0NhaXhhPjEyMzwvbnVtZXJvQ2FpeGE+PC9pZGU+PGVtaXQ+PENOUEo+MTE3ODI3NjUwMDAxNDc8L0NOUEo+PHhOb21lPlBPVElHVUFSIFBJWlpBIEUgR1JJTEwgTFREQSBNRTwveE5vbWU+PHhGYW50PlBPVElHVUEgUElaWkEgRSBHUklMTDwveEZhbnQ+PGVuZGVyRW1pdD48eExncj5SVUEgTFVJWiBDQVJMT1MgUEFWQU5JVE88L3hMZ3I+PG5ybz4zNTwvbnJvPjx4Q3BsPkVTUVVJTkEgQVYgRFIgSkJPTTwveENwbD48eEJhaXJybz5QQVJRVUUgUVVBUlRPIENFTlRFTkFSSU88L3hCYWlycm8+PHhNdW4+VEFVQkFURTwveE11bj48Q0VQPjEyMDQwNTU1PC9DRVA+PC9lbmRlckVtaXQ+PElFPjY4ODI5OTQzOTExNjwvSUU+PGNSZWdUcmliPjE8L2NSZWdUcmliPjxpbmRSYXRJU1NRTj5OPC9pbmRSYXRJU1NRTj48L2VtaXQ+PGRlc3Q+PENQRj4zNjQ3MTA0MjgwOTwvQ1BGPjwvZGVzdD48ZGV0IG5JdGVtPSIwMSI+PHByb2Q+PGNQcm9kPjE8L2NQcm9kPjx4UHJvZD5SRUZFScOHw4NPIFNFTEZTRVJWSUNFPC94UHJvZD48TkNNPjIxMDY5MDA1PC9OQ00+PENGT1A+NTEwMjwvQ0ZPUD48dUNvbT5LRzwvdUNvbT48cUNvbT4xLjAwMDA8L3FDb20+PHZVbkNvbT4wLjAxPC92VW5Db20+PHZQcm9kPjAuMDE8L3ZQcm9kPjxpbmRSZWdyYT5BPC9pbmRSZWdyYT48dkl0ZW0+MC4wMTwvdkl0ZW0+PC9wcm9kPjxpbXBvc3RvPjxJQ01TPjxJQ01TU04xMDI+PE9yaWc+MDwvT3JpZz48Q1NPU04+NTAwPC9DU09TTj48L0lDTVNTTjEwMj48L0lDTVM+PFBJUz48UElTU04+PENTVD40OTwvQ1NUPjwvUElTU04+PC9QSVM+PENPRklOUz48Q09GSU5TU04+PENTVD40OTwvQ1NUPjwvQ09GSU5TU04+PC9DT0ZJTlM+PC9pbXBvc3RvPjxpbmZBZFByb2Q+Q29uc3VtaWRvIG5vIGxvY2FsPC9pbmZBZFByb2Q+PC9kZXQ+PHRvdGFsPjxJQ01TVG90Pjx2SUNNUz4wLjAwPC92SUNNUz48dlByb2Q+MC4wMTwvdlByb2Q+PHZEZXNjPjAuMDA8L3ZEZXNjPjx2UElTPjAuMDA8L3ZQSVM+PHZDT0ZJTlM+MC4wMDwvdkNPRklOUz48dlBJU1NUPjAuMDA8L3ZQSVNTVD48dkNPRklOU1NUPjAuMDA8L3ZDT0ZJTlNTVD48dk91dHJvPjAuMDA8L3ZPdXRybz48L0lDTVNUb3Q+PHZDRmU+MC4wMTwvdkNGZT48L3RvdGFsPjxwZ3RvPjxNUD48Y01QPjAxPC9jTVA+PHZNUD4wLjAxPC92TVA+PC9NUD48dlRyb2NvPjAuMDA8L3ZUcm9jbz48L3BndG8+PC9pbmZDRmU+PFNpZ25hdHVyZSB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnIyI+PFNpZ25lZEluZm8+PENhbm9uaWNhbGl6YXRpb25NZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy9UUi8yMDAxL1JFQy14bWwtYzE0bi0yMDAxMDMxNSI+PC9DYW5vbmljYWxpemF0aW9uTWV0aG9kPjxTaWduYXR1cmVNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNyc2Etc2hhMjU2Ij48L1NpZ25hdHVyZU1ldGhvZD48UmVmZXJlbmNlIFVSST0iI0NGZTM1MTUxMTExNzgyNzY1MDAwMTQ3NTkwMDAwNjIxNTkwMDAwMDE2NjYxMTQwIj48VHJhbnNmb3Jtcz48VHJhbnNmb3JtIEFsZ29yaXRobT0iaHR0cDovL3d3dy53My5vcmcvMjAwMC8wOS94bWxkc2lnI2VudmVsb3BlZC1zaWduYXR1cmUiPjwvVHJhbnNmb3JtPjxUcmFuc2Zvcm0gQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy9UUi8yMDAxL1JFQy14bWwtYzE0bi0yMDAxMDMxNSIPC9UcmFuc2Zvcm0+PC9UcmFuc2Zvcm1zPjxEaWdlc3RNZXRob2QgQWxnb3JpdGhtPSJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGVuYyNzaGEyNTYiPjwvRGlnZXN0TWV0aG9kPjxEaWdlc3RWYWx1ZT5RbWpWSWVYZ21KbGFjeDA3VVFqM3docjl6QmZlS0NxdmFBSkJ2cHVPTzN3PTwvRGlnZXN0VmFsdWU+PC9SZWZlcmVuY2U+PC9TaWduZWRJbmZvPjxTaWduYXR1cmVWYWx1ZT5HNjdOeG40OEZMTnRxc1l0N0wrSTdwTkhONjB0QnltT1c4bXVhQll4ZkNqMzRFMzJjT1pTb1IvdGtUSlkyR3JrWmtSUS9pTUtsREpFb0w5Q3ArM09KMmtuOWlsUXBxcGFLNEpWWTc4SWkzQkpyblZLc1pENVlzazJVOC9HVmIrblpTczgxUk1uWDRHNHA5VTRnWHFEY2VEVjdZejUvanJCUVgraVNLS0RZUFN2eEs3THlJY0V3YmZzN3hSaUNSQzc5WUwvRTh4QkUyTkRKbmNIK1ZnRlYyQ2dYRENWakpCNklwb1B0MzZBaWx5UHBoSlpLdnJhdUt5WE5CdU4zT2hkSmswL2JZRWFlUTdTQ0pzWS9UODFTNnlQdWtlUGRkN0ZVWE0wQS9qT1VBTkVDeVFZeisxRUFtTGhiTzBrQkNTZUJ0aTRhWkQ2UXZiT3p0cEZjN21LYkE9PTwvU2lnbmF0dXJlVmFsdWU+PEtleUluZm8+PFg1MDlEYXRhPjxYNTA5Q2VydGlmaWNhdGU+TUlJR2dqQ0NCR3FnQXdJQkFnSUpBUm9ZSkRKenRURkxNQTBHQ1NxR1NJYjNEUUVCQ3dVQU1GRXhOVEF6QmdOVkJBb1RMRk5sWTNKbGRHRnlhV0VnWkdFZ1JtRjZaVzVrWVNCa2J5QkZjM1JoWkc4Z1pHVWdVMkZ2SUZCaGRXeHZNUmd3RmdZRFZRUURFdzlCUXlCVFFWUWdVMFZHUVZvZ1UxQXdIaGNOTVRVeE1UQTFNRGd4TWpReFdoY05NakF4TVRBMU1EZ3hNalF4V2pDQnV6RVNNQkFHQTFVRUJSTUpNREF3TURZeU1UVTVNUXN3Q1FZRFZRUUdFd0pDVWpFU01CQUdBMVVFQ0JNSlUyRnZJRkJoZFd4dk1SRXdEd1lEVlFRS0V3aFRSVVpCV2kxVFVERVBNQTBHQTFVRUN4TUdRVU10VTBGVU1TZ3dKZ1lEVlFRTEV4OUJkWFJsYm5ScFkyRmtieUJ3YjNJZ1FWSWdVMFZHUVZvZ1UxQWdVMEZVTVRZd05BWURWUVFERXkxUVQxUkpSMVZCVWlCUVNWcGFRU0JGSUVkU1NVeE1JRXhVUkVFZ1RVVTZNVEUzT0RJM05qVXdNREF4TkRjd2dnRWlNQTBHQ1NxR1NJYjNEUUVCQVFVQUE0SUJEd0F3Z2dFS0FvSUJBUUNFcE5FUG1pQjNkblZPakxoMW8zYmpBdXdFcno5ZEFKTm40bzNmY2FzaCtaV0RxTjZqQU5aMisxaFUrZFN2czJkTUJzOGJaYko3WHdjUjlJMERCd09meFFXd04yQ3BCZnEyRFhDWVRXQUpZQWdXdEhNdzE3Y3d4bFVpV3pLbkV1cHEza2JoNkxxK0dhNkl5Zm52c1dzYmlzM3dlbE9ma1FsZVhvd3VpOEtianpKSlRZZjdGQllDZ25pSmxBekxTb3ZFSTlxc3d6Y3hHVnA4S2xxS0JweTFRWnljL3EvMXNlMXNkRWtHa3Z0eWdaTXhTbUpLQy92b1RCNmRadjZBOWJvTUhqK3h4RnoxUmJoaTZITkJ2MXR1K3JZZjJCdEMydTV6T1hoU0xJMW94YTJ2L256VjJsblFYMkpoOHdoYUttT3hXaVJjRVgrMjNjakYzam5ZaUxrVkFnTUJBQUdqZ2dId01JSUI3REFPQmdOVkhROEJBZjhFQkFNQ0JlQXdkUVlEVlIwZ0JHNHdiREJxQmdrckJnRUVBWUhzTFFNd1hUQmJCZ2dyQmdFRkJRY0NBUlpQYUhSMGNEb3ZMMkZqYzJGMExtbHRjSEpsYm5OaGIyWnBZMmxoYkM1amIyMHVZbkl2Y21Wd2IzTnBkRzl5YVc4dlpIQmpMMkZqYzJWbVlYcHpjQzlrY0dOZllXTnpaV1poZW5Od0xuQmtaakJsQmdOVkhSOEVYakJjTUZxZ1dLQldobFJvZEhSd09pOHZZV056WVhRdWFXMXdjbVZ1YzJGdlptbGphV0ZzTG1OdmJTNWljaTl5WlhCdmMybDBiM0pwYnk5c1kzSXZZV056WVhSelpXWmhlbk53TDJGamMyRjBjMlZtWVhwemNHTnliQzVqY213d2daUUdDQ3NHQVFVRkJ3RUJCSUdITUlHRU1DNEdDQ3NHQVFVRkJ6QUJoaUpvZEhSd09pOHZiMk56Y0M1cGJYQnlaVzV6WVc5bWFXTnBZV3d1WTI5dExtSnlNRklHQ0NzR0FRVUZCekFDaGtab2RIUndPaTh2WVdOellYUXVhVzF3Y21WdWMyRnZabWxqYVdGc0xtTnZiUzVpY2k5eVpYQnZjMmwwYjNKcGJ5OWpaWEowYVdacFkyRmtiM012WVdOellYUXVjRGRqTUJNR0ExVWRKUVFNTUFvR0NDc0dBUVVGQndNQ01Ba0dBMVVkRXdRQ01BQXdKQVlEVlIwUkJCMHdHNkFaQmdWZ1RBRURBNkFRQkE0eE1UYzRNamMyTlRBd01ERTBOekFmQmdOVkhTTUVHREFXZ0JTd2hZR3pLTTEyS2lra1MxOVlTbTlvMmF5d0tqQU5CZ2txaGtpRzl3MEJBUXNGQUFPQ0FnRUFUOWp2N2FWUCtCRjN1V2pVQWJiZGFIRkp3OXdFbUwyK0JGa0VaU1Vpd2FyQWx5bFFlckpLbmhHMWxaaVluRkhqMzA3S0l3TFdrNmRzUDlyUHd0NC9TcTQxNHVLWS8wYzQ2eWdDL1FkM1JBeWlTUXpueFVtelJZTHA3ZkhWak1WR1pkT2VaT1lDZko0L1IrajVSN2hGZGZYK2phSUc5VE5mdlBNcHFFTVBSbW94UkxCVkJkbXNVTTFpYVdKazN6U2p0UmdUWUcvMzMrV0RhcW93K2ZtbXhUT0NmNkVOZXdCVFlxTElZUzZOWEd2UFZybnVvUWJzSlYzd1hGU3FObXl0WjF3aldtRmlXQndITDR6SWhOdkQvT3grVGdjblJNREhDT0JrOTV6bGcxRGx4eVcwZVVlaVdBZDdHdUtsSTM4WjN6eVVKWEdmcGF3a1JnTTgzaXc3Qyt3VGVGN0pXYzdLbDkxZlRjYnRvRWZtSWNxcWY0dGdaN1JVL2VWUUZaS3RHaFJHRVRRSlBDb0k4MDlvY3I3dHFmTERDNjZwQjhjZ3gzTWY1QXJHWHY0SlM3YWlnWVdkR0N4TTRFdXV5dmZuT3k5KzZ1OXpXVDBVZ3NGbkIwYTdyaXBlUjAxSW0yVUNVYlhuZVpoUXF6YnVpWVUrSXVzN1Ruc3ZhVzFZVE8yanpKSzFwdlhldGtSd0xiZ0s5YmM1VDNlV2wxV3YrWkF0ODhNNFQzYUIxb1Zlb2lCb1pjYUJWUkk2Qk9vV2RCM09TTm92VDBlcG5qdFJZUDlwSWtSWm5ERFNFc1M2L2xDTmw5Qk9qRTY2ZFhXc0s0MXlrNUN5M1lrRUxtcXplcjlIUm4wTjZPYU9HTzVlSkMrMGd0VFF0M0V5YWtUTllWNHhuSkowTFBadytQWT08L1g1MDlDZXJ0aWZpY2F0ZT48L1g1MDlEYXRhPjwvS2V5SW5mbz48L1NpZ25hdHVyZT48L0NGZT4=|20151119164901|CFe35151111782765000147590000621590000016661140||0.01|36471042809|M5zfOB+CVoyMF/c7ycld4dF2U2XyI7AYOdtClfZ4dUwIDZDlzEyqNIgQcZ0H9CO5+Fq1RkmHrdrU7YPTxfLlTixBGnu4bmgDMurYSvwEnQWZvVBcn/Jc2+nLD0+jLisFgWhI96RqBZEVfu07wTRj7qCUtiTstiEztLbOiph9mFZoLpzF5ZzaUzS2sFZg1tELBfgyvRLdHQcerUeeVCjYSNw/J2Y7MYyKWaYrcTaKVccXSPb5y+z6vHu28UHxxI0vT5TDMgrRDerLTn7rgWjgG2coYvxbT4LQ3Tzw25Bhur/fV6mX5tKF3etsKxIfAMdydGoUpptSEoaFm6Jqy7SEyg==";
                c.auditoria(usuario, "VENDA"); 
                string numCF = Sep_Delimitador('|', 7, ret);
                string cfe = Sep_Delimitador('|', 8, ret);
                string qrc = Sep_Delimitador('|', 11, ret);

                c.inserir("insert into logSat (ses,msg,err,dat,arq,ale,cfe,qrc,sef) values ('" + Sep_Delimitador('|', 0, ret) + "','" + Sep_Delimitador('|', 3, ret) + "','" + Sep_Delimitador('|', 1, ret) + "','" + DateTime.Now + "','" + Sep_Delimitador('|', 7, ret) + "','" + Sep_Delimitador('|', 2, ret) + "','" + Sep_Delimitador('|', 8, ret) + "','" + qrc + "','" + Sep_Delimitador('|', 5    , ret) + "')");
                MessageBox.Show(ret);

                //GERACAO DE XML DE VENDA
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(new StringReader(xml));
                xmlDoc.Save(cfe + ".xml");

                //COMUNICACAO COM A IMPRESSORA
                ImpressoraNaoFiscal miniPrinter = new ImpressoraNaoFiscal(ModeloImpressoraNaoFiscal.MP4000TH, "LPT1");
                miniPrinter.AbrirGaveta();

                //IMPRESSÃO DO LOGO
                ImpressaoBitmap bitmap = null;
                picLogo.Load("logo.bmp");
                bitmap = new ImpressaoBitmap((Bitmap)picLogo.Image);
                miniPrinter.Imprimir(bitmap);
                miniPrinter.Imprimir("\r\n");

                //IMPRESSAO CABECARIO
                c.imprimeLinha("POTIGUAR PIZZA E GRILL LTDA ME", miniPrinter, false, 0);
                c.imprimeLinha("CNPJ 11.782.765/0001-47 IE 688299439116", miniPrinter, false, 0);
                miniPrinter.Imprimir("\r\n");

                c.imprimeLinha("Extrato Nº 000001", miniPrinter, true,0);
                c.imprimeLinha("CUPOM FISCAL ELETRÔNICO - SAT", miniPrinter, true,0);
                miniPrinter.Imprimir("\r\n");

                if(!txtCPF.Text.Equals(""))
                    c.imprimeLinha("CPF/CNPJ:"+txtCPF.Text, miniPrinter, true,0);
                else
                    c.imprimeLinha("CPF/CNPJ: CONSUMIDOR SEM IDENTIFICAÇÃO" + txtCPF.Text, miniPrinter, true, 0);
                miniPrinter.Imprimir("\r\n");

                c.imprimeLinha(" # COD DESCRICAO_DO_PRODUTO QTD UN VL_UN VLTOTAL", miniPrinter, true,0);
                miniPrinter.Imprimir("\r\n");

                string linha = "";
                double sub = 0;
                for (int i = 0; i < lstProd.Items.Count; i++)
                {		        
                    string produto = lstProd.Items[i].ToString();
                    int codProd = Convert.ToInt16(produto.Split('|')[0]);
                    linha = (i + 1).ToString();
                    linha += " " + codProd;
                    
                    OleDbDataReader dados = c.consulta("select * from produtos where cod = "+codProd);
                    dados.Read();
                    
                    linha += " "+dados.GetString(2);

                    int ini = produto.IndexOf('*') + 1;
                    int fim = produto.IndexOf('=');
                    double qtd = Convert.ToDouble(produto.Substring(ini, fim - ini));
                    linha += " "+c.formatNumber2(qtd,4);

                    linha += " "+dados.GetString(4);

                    double unitario = Convert.ToDouble(dados.GetValue(3));
                    linha += " "+c.formatNumber2(unitario,2);

                    sub += unitario * qtd;
                    linha += " "+c.formatNumber2(unitario*qtd,2);

                    c.imprimeLinha(linha, miniPrinter, false,0);
                }
                miniPrinter.Imprimir("\r\n");
                miniPrinter.Imprimir("\r\n");
                c.imprimeLinha(" TOTAL R$ "+c.formatNumber2(sub,2), miniPrinter, true,-1);

                for (int i = 0; i < lstModalidade.Items.Count; i++)
                {
                    
                    OleDbDataReader dados = c.consulta("select * from modalidades where cod = " + lstModalidade.Items[i].ToString().Split('|')[1]);
                    dados.Read();
                    
                    linha = dados.GetString(1)+" R$ ";
                    
                    double valor = Convert.ToDouble(lstModalidade.Items[i].ToString().Split('|')[0]);
                    linha += c.formatNumber2(valor, 2);
                    
                    sub -= valor;
                    c.imprimeLinha(" "+linha, miniPrinter, false,-1);
                    
                }
                c.imprimeLinha(" TROCO R$ " + c.formatNumber2(sub, 2), miniPrinter, false, -1);
                miniPrinter.Imprimir("\r\n");

                c.imprimeLinha("ICMS a ser recolhido conforme LC 123/2006 - Simples Nacional.", miniPrinter, true,0);
                miniPrinter.Imprimir("\r\n");

                c.imprimeLinha("SAT Número: "+sat, miniPrinter, true, 0);
                c.imprimeLinha(DateTime.Now.ToString(), miniPrinter, true,0);
                c.imprimeLinha("Chave de Acesso'", miniPrinter, true,0);
                c.imprimeLinha(" "+cfe, miniPrinter, true,0);
                miniPrinter.Imprimir("\r\n");

                //GERACAO DE IMAGEM QRCODE
                QRCodeEncoder enc = new QRCodeEncoder();
                Bitmap qrcode = enc.Encode(qrc);
                pic.Image = qrcode as Image;
                pic.Image.Save("tempQRC.bmp", System.Drawing.Imaging.ImageFormat.Bmp);

                //IMPRESSAO EM CUPOM
                pic.SizeMode = PictureBoxSizeMode.Normal;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                bitmap.QualidadeImpressao = QualidadeImpressao.Alta;
                bitmap = new ImpressaoBitmap((Bitmap)pic.Image);
                bitmap.FormatoPaisagem = true;
                
                miniPrinter.Imprimir(bitmap);
                miniPrinter.Imprimir("\r\n\r\n\r\n\r\n");
                miniPrinter.CortarPapel(true);
                

            }
            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }       
                                                        
        }           

        private void gerarXMLsToolStripMenuItem_Click(object sender, EventArgs e)
        {
                                                                                                                
        }

        public void impressaoVasilhame()
        {
            ImpressoraNaoFiscal miniPrinter2 = new ImpressoraNaoFiscal(ModeloImpressoraNaoFiscal.MP4000TH, "LPT1");
            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ImpressoraNaoFiscal miniPrinter2 = new ImpressoraNaoFiscal(ModeloImpressoraNaoFiscal.MP4000TH, "LPT1");
            ImpressaoBitmap bitmap = null;

            pic2.Load("1.bmp");
            bitmap = new ImpressaoBitmap((Bitmap)pic2.Image);
            for (int j=1; j<10; j++)
            {
                miniPrinter2.Imprimir(bitmap);
                miniPrinter2.CortarPapel(true);
            }

            pic2.Load("2.bmp");
            bitmap = new ImpressaoBitmap((Bitmap)pic2.Image);
            for (int j = 1; j < 10; j++)
            {
                miniPrinter2.Imprimir(bitmap);
                miniPrinter2.CortarPapel(true);
            }

            pic2.Load("3.bmp");
            bitmap = new ImpressaoBitmap((Bitmap)pic2.Image);
            for (int j = 1; j < 5; j++)
            {
                miniPrinter2.Imprimir(bitmap);
                miniPrinter2.CortarPapel(true);
            }

            pic2.Load("4.bmp");
            bitmap = new ImpressaoBitmap((Bitmap)pic2.Image);
            for (int j = 1; j < 3; j++)
            {
                miniPrinter2.Imprimir(bitmap);
                miniPrinter2.CortarPapel(true);
            }

            pic2.Load("5.bmp");
            bitmap = new ImpressaoBitmap((Bitmap)pic2.Image);
            for (int j = 1; j < 1; j++)
            {
                miniPrinter2.Imprimir(bitmap);
                miniPrinter2.CortarPapel(true);
            }

            string busca = txtbarras.Text;
            string sql = "";

            if (busca.Equals(""))
            {
                sql = "select * from produtos";
            }else{
                int num = 0;
                sql = "select * from produtos where ";
                if (!int.TryParse(busca, out num))
                {
                    sql += "des like '%" + busca + "%'";
                }else{
                    sql += "bar = " + busca + " or cod = " + busca + "     ";
                }
            }           

            OleDbDataReader dados = c.consulta(sql);
            int i = 0;

            cbo.Items.Clear();

            if (!dados.HasRows)
            {
                cbo.Items.Add("SEM RESULTADOS");
                cbo.SelectedIndex = 0;
                txtbarras.Text = "";
            }
            else
            {
                while (dados.Read())
                {                                                                           
                    string str = dados.GetValue(0).ToString();
                    str += "| ";
                    str += dados.GetString(2);
                    cbo.Items.Add(str);
                    i++;
                }
                cbo.SelectedIndex = 0;
                cbo.Focus();
            }
        }

        private void txtbarras_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyValue == 13)
                    button1_Click(sender,e);
        }

        private void lstProd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbo.Items[cbo.SelectedIndex].ToString().Equals("SEM RESULTADOS"))
            {
                string sqls = "select * from produtos where cod = " + cbo.Items[cbo.SelectedIndex].ToString().Split('|')[0] + "";
                OleDbDataReader dados = c.consulta(sqls);

                if (dados.Read())
                {
                    txtUnitario.Text = dados.GetValue(3).ToString();
                    txtUnidade.Text = dados.GetString(4);

                    int num = 0;

                    if (!int.TryParse(txtQtd.Text, out num) && txtQtd.Text.IndexOf(',') == 0)
                    {
                        txtQtd.Text = "1";
                        num = 1;
                    }

                    double valor = 0;
                    double.TryParse(txtUnitario.Text, out valor);

                    txtValor.Text = (num * valor).ToString();
                    txtQtd.Focus();
                }
            }
            else
            {
                txtUnitario.Text = "";
                txtUnidade.Text = "";
                txtValor.Text = "";
            }
        }
                                                                            
        private void txtQtd_TextChanged(object sender, EventArgs e)
        {
            cbo_SelectedIndexChanged(sender, e);
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (double.TryParse(txtValor.Text, out total))
            {
                lstProd.Items.Add(cbo.Text + " | " + txtUnitario.Text + "*" + txtQtd.Text + "=" + txtValor.Text);
                btnCancela.Enabled = true;
                lstProd.Enabled = true;
                btnExclui.Enabled = true;
                btnPagamento.Enabled = true;
            }

            double sub = 0;
            for (int i = 0; i < lstProd.Items.Count; i++)
            {
                sub += Convert.ToDouble(lstProd.Items[i].ToString().Split('=')[1]);
            }

            lblSubtotal.Text = "Total de Itens: "+lstProd.Items.Count+" | Subtotal R$ "+c.formatNumber(sub);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lstProd.SelectedIndex > -1)
            {
                if (MessageBox.Show("Deseja Realmente excluir este Produto?", "",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstProd.Items.Remove(lstProd.SelectedItem);

                    if (lstProd.Items.Count == 0)
                    {
                        btnExclui.Enabled = false;
                        btnCancela.Enabled = false;
                        lstProd.Enabled = false;
                        btnPagamento.Enabled = false;
                    }
                }
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Realmente cancelar a venda?", "",
     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstProd.Items.Clear();
            }

            pnlPagamento.Enabled = false;
            pnlBusca.Enabled = true;
            lstProd.Enabled = true;
            btnPagamento.Enabled = true;
            btnExclui.Enabled = true;
            pnlFechar.Enabled = false;
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            pnlBusca.Enabled = false;
            lstProd.Enabled = false;
            btnPagamento.Enabled = false;
            btnExclui.Enabled = false;

            pnlPagamento.Enabled = true;

            double sub = Convert.ToDouble(lblSubtotal.Text.Split('$')[1].Trim().Replace('.',','));
                txtModalidade.Text = c.formatNumber(sub);

            lstModalidade.Items.Clear();
            cboModalidade.Focus();
        }

        private void btnModalidade_Click(object sender, EventArgs e)
        {
            try
            {
                double sub = Convert.ToDouble(lblSubtotal.Text.Split('$')[1].Trim().Replace(".", ","));
                double total = Convert.ToDouble(txtModalidade.Text.Replace(".",",").Trim());

              
                for (int i = 0; i < lstModalidade.Items.Count; i++)
                    sub -= Convert.ToDouble(lstModalidade.Items[i].ToString().Split('|')[0].Replace('.', ','));

                if (total <= sub)
                {
                    lstModalidade.Items.Add(total.ToString() + "|" + cboModalidade.Items[cboModalidade.SelectedIndex].ToString().Split('|')[0].Replace('.', ','));

                    sub -= total;

                    if (sub == 0)
                    {
                        pnlPagamento.Enabled = false;
                        pnlFechar.Enabled = true;
                        txtCPF.Focus();
                    }
                    else
                    {
                        cboModalidade.Focus();
                    }
                }
                
            }
            catch
            {
            }
        }

        private void txtModalidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnModalidade_Click(sender, e);
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                btnIncluir_Click(sender, e);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!txtCPF.Text.Equals(""))
            {
                if (!(c.ValidaCPF(txtCPF.Text) || c.ValidaCNPJ(txtCPF.Text)))
                {
                    MessageBox.Show("CPF/CNPJ Inválido");
                    txtCPF.Focus();
                    btnFechar.Enabled = false;
                }
                else
                    btnFechar.Enabled = true;
            }
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                txtCPF_Leave(sender, e);
        }
    }
}
                