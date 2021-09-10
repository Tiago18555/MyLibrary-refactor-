using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Library
{
    class Globals
    {
		/// <summary>
		/// Versão do aplicativo
		/// </summary>
		public static string versao = "1.0";
		/// <summary>
		/// Indica se existe um usuário logado
		/// </summary>
		public static bool logado = false;
		public static string sys_path { get; set; } = Environment.CurrentDirectory;
		public static string data_base_name { get; set; } = "biblioteca.db";
		public static string path { get; set; } = sys_path + @"\banco\";

        /// <summary>
        /// Retorna true se o CPF é válido
        /// </summary>
        /// <param name="cpfVar"></param>
        /// <returns></returns>
        public static bool validaCPF(string cpfVar)
        {
            double v1 = 0;
            double v2 = 0;
            bool aux = false;
            cpfVar = cpfVar.Replace(",", "").Replace("-", "");

            for (int i = 1; i < 11; i++)
            {
                if (cpfVar[i - 1] != cpfVar[i])
                    aux = true;
            }

            if (aux == false)
                return false;

            int[] cpfArray = new int[11];
            for (int i = 0; i < 11; i++)
            {
                cpfArray[i] = cpfVar[i];
                switch (cpfArray[i])
                {
                    case 48: cpfArray[i] = 0; break;
                    case 49: cpfArray[i] = 1; break;
                    case 50: cpfArray[i] = 2; break;
                    case 51: cpfArray[i] = 3; break;
                    case 52: cpfArray[i] = 4; break;
                    case 53: cpfArray[i] = 5; break;
                    case 54: cpfArray[i] = 6; break;
                    case 55: cpfArray[i] = 7; break;
                    case 56: cpfArray[i] = 8; break;
                    case 57: cpfArray[i] = 9; break;
                }
            }

            for (int i = 0, p = 10; i < 9; i++, p--)
            {
                v1 += cpfArray[i] * p;
            }


            v1 = ((v1 * 10) % 11);


            if (v1 == 10)
                v1 = 0;

            if (v1 != cpfArray[9])
                return false;

            for (int i = 0, p = 11; i < 10; i++, p--)
            {
                v2 += cpfArray[i] * p;
            }

            v2 = ((v2 * 10) % 11);

            if (v2 == 10)
                v2 = 0;

            if (v2 != cpfArray[10])
                return false;
            else
                return true;
        }

        /// <summary>
        /// Retorna true se o CNPJ é válido
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public static bool validaCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(",", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj += digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito += resto.ToString();
            return cnpj.EndsWith(digito);
        }

        /// <summary>
        /// Retorna o CPF sem os separadores
        /// </summary>
        /// <param name="cpfVar"></param>
        /// <returns></returns>
        public static string formatCPF(string cpfVar)
        {
            cpfVar = cpfVar
                .Trim()
                .Replace(",", "")
                .Replace("-", "")
                .Replace("/", "")
                .Replace(".", "");
            return cpfVar;
        }

        /// <summary>
        /// Retorna CNPJ sem os separadores
        /// </summary>
        /// <param name="cnpj"></param>
        /// <returns></returns>
        public static string formatCNPJ(string cnpj)
        {
            cnpj = cnpj
                .Trim()
                .Replace(",", "")
                .Replace("-", "")
                .Replace("/", "")
                .Replace(".", "");
            return cnpj;
        }

        /// <summary>
        /// Retorna true se o email corresponde ao padrão
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public static bool validaEmail(string email)
		{
            Regex _regexEmail = new Regex(@"^[\w_\-.]+@[\w_\-.]+\.[\w_\-.]+$");
            return _regexEmail.IsMatch(email);
        }
        /// <summary>
        /// Retorna true se se a tecla pressionada não for numérica
        /// </summary>
        /// <param name="e">Objeto do tipo "KreyPressEventArgs"</param>
        /// <returns></returns>
        public static bool keyIsNumber(KeyPressEventArgs e)
		{
            int key = e.KeyChar;

            return
                !char.IsNumber(e.KeyChar) &&
                e.KeyChar != ',' &&
                key != 8 &&
                key != 13 &&
                key != 27;
        }
    }
}