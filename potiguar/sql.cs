using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Bematech;
using Bematech.Texto;
using Bematech.CodigosDeBarras;
using Bematech.Comunicacao;
using Bematech.MiniImpressoras;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace potiguar
{
    class sql
    {       
        
        OleDbConnection con = new OleDbConnection();
        
        public sql(){
            //configuração do caminho ao banco de dados
            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=potiguar.mdb";
            con.Open();
        }

        public OleDbDataReader consulta(String sql){
            OleDbCommand com = new OleDbCommand(sql, con);
            //Executar o comando e ler os dados retornados
            OleDbDataReader dados = com.ExecuteReader();
            return dados;
        }

        public void fechar()
        {
            con.Close();
        }

        public void inserir(String sql)
        {
            OleDbCommand com = new OleDbCommand(sql, con);
            //Executar o comando e ler os dados retornados
            com.ExecuteNonQuery();
        }

        public void auditoria(string usuario, string operacao)
        {
            inserir("insert into auditoria (usu,dat,ope) values ('" + usuario + "','" + DateTime.Now + "','" + operacao + "')");
        }

        public bool ValidaCPF(string vrCPF) { 
            string valor = vrCPF.Replace(".", ""); 
            valor = valor.Replace("-", ""); 
            if (valor.Length != 11) 
                return false; 

            bool igual = true; 
            
            for (int i = 1; i < 11 && igual; i++) 
                if (valor[i] != valor[0]) igual = false; 
            
            if (igual || valor == "12345678909") 
                return false; 
            
            int[] numeros = new int[11]; 
            
            for (int i = 0; i < 11; i++) 
                numeros[i] = int.Parse( valor[i].ToString()); 
            
            int soma = 0; 
            
            for (int i = 0; i < 9; i++) 
                soma += (10 - i) * numeros[i]; 
            
            int resultado = soma % 11; 
            
            if (resultado == 1 || resultado == 0) { 
                if (numeros[9] != 0) 
                    return false; 
            } else 
                if (numeros[9] != 11 - resultado) 
                    return false; 
                soma = 0; 
                
                for (int i = 0; i < 10; i++) 
                    soma += (11 - i) * numeros[i]; 
                
                resultado = soma % 11; 
            
                if (resultado == 1 || resultado == 0) { 
                    if (numeros[10] != 0) 
                        return false; 
                } else 
                    if (numeros[10] != 11 - resultado) 
                        return false; 
            return true; 
        }

        public bool ValidaCNPJ(string vrCNPJ)
        {
            string CNPJ = vrCNPJ.Replace(".", "");

            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");

            int[] digitos, soma, resultado;
            int nrDig;
            string ftmt;
            bool[] CNPJOk;
            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];

            soma[0] = 0;
            soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0;
            resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false;
            CNPJOk[1] = false;

            try
            {
                for (nrDig = 0; nrDig < 14; nrDig++)
                {
                    digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11)
                        soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    if (nrDig <= 12)
                        soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }

                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1))
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                    else
                        CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));
                }

                return (CNPJOk[0] && CNPJOk[1]);
            }
            catch
            {
                return false;
            }
        }

        public string formatNumber2(double d, int c)
        {
            NumberFormatInfo nfi = (NumberFormatInfo)
            CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = ",";

            return (d.ToString("N"+c.ToString(), nfi));// 1.00
        }

        public string formatNumber(double d)
        {
            NumberFormatInfo nfi = (NumberFormatInfo)
            CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = ",";

            return (d.ToString("N2", nfi));// 1.00
        }

        public void imprimeLinha(string linha, ImpressoraNaoFiscal bema, bool negrito, int ali)
        {
            // tamanho do caracter
            TextoFormatado.TamanhoCaracter tamanhoCaracter;

            tamanhoCaracter = TextoFormatado.TamanhoCaracter.Condensado;
            //tamanhoCaracter = TextoFormatado.TamanhoCaracter.Elite;
            //tamanhoCaracter = TextoFormatado.TamanhoCaracter.Normal;

            TextoFormatado.FormatoCaracter formato = TextoFormatado.FormatoCaracter.Normal;
            if(negrito)
                formato = TextoFormatado.FormatoCaracter.Negrito;

            
            TextoFormatado.TipoAlinhamento alinhamento;
            if (ali == 0)
                alinhamento = TextoFormatado.TipoAlinhamento.Centralizado;
            else
            {
                if(ali == -1)
                    alinhamento = TextoFormatado.TipoAlinhamento.Esquerda;
                else
                    alinhamento = TextoFormatado.TipoAlinhamento.Direita;
            }
            
            TextoFormatado texto = new TextoFormatado(linha + "\r\n", tamanhoCaracter, formato, alinhamento);
            texto.TabelaCaracteres = bema.TabelaCaracteres;

            try
            {
                bema.Imprimir(texto);
            }
            catch (MiniImpressoraException erro)
            {
                MessageBox.Show(erro.Message, "TestMiniPrinter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
    