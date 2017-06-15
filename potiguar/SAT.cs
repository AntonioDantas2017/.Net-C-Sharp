using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace potiguar
{

    public partial class SAT : principal
    {
        public int randInt(int low, int high)
        {
            int numero, i;
            bool flag = true;
            numero = 0;
            /* garante que o numero de sessão não se repete nas ultimas 100 comunicacoes */
            while (flag)
            {
                Random rnd = new Random();
                numero = rnd.Next(low,high) % ((high + 1) - low) + low;
                flag = false;

                for (i = 0; i < listanumeroSessao.Length; i++)
                {
                    if (numero == listanumeroSessao[i])
                    {
                        /* numero de sessao repetido, necessario gerar outro */
                        flag = true;
                    }
                }
            }

            listanumeroSessao[ultimonumero] = numero;
            ultimonumero = (ultimonumero + 1) % listanumeroSessao.Length;
            return numero;
        }
    }

    public class Declaracao_Func_SAT
    {
        [DllImport("DLLSAT.DLL", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ConsultarStatusOperacional(int sessao, string cod);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr EnviarDadosVenda(int sessao, string cod, string dados);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr CancelarUltimaVenda(int sessao, string cod, string chave, string dadoscancel);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TesteFimAFim(int sessao, string cod, string dados);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ConsultarSAT(int sessao);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ConsultarNumeroSessao(int sessao, string cod, int sessao_a_ser_consultada);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AtivarSAT(int sessao, int tipoCert, string cod_Ativacao, string cnpj, int uf);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ComunicarCertificadoICPBRASIL(int sessao, string cod, string csr);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ConfigurarInterfaceDeRede(int sessao, string cod, string xmlConfig);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AssociarAssinatura(int sessao, string cod, string cnpj, string sign_cnpj);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr DesbloquearSAT(int sessao, string cod_ativacao);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr BloquearSAT(int sessao, string cod_ativacao);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr TrocarCodigoDeAtivacao(int sessao, string cod_ativacao, int opcao, string nova_senha, string conf_senha);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ExtrairLogs(int sessao, string cod_ativacao);

        [DllImport("DLLSAT.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr AtualizarSoftwareSAT(int sessao, string cod_ativacao);
    }
}
