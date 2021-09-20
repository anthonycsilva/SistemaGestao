using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MetodosGerais
    {
        public string retornaNome(string nome)
        {
            return nome;
        }

        public int converteStringInt(string texto)
		{
			int numero = Convert.ToInt32(texto);
			return numero;
		}

		public int gerarCodigoPedido() 
		{
			Random rnd = new Random();
			int codigoPedido = rnd.Next(1, 1000000);
			return codigoPedido;
		}

		public bool verificaCPF(string cpf)
		{
			int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
			string tempCpf;
			string digito;
			int soma;
			int resto;

			cpf = cpf.Trim();
			cpf = cpf.Replace(".", "").Replace("-", "");

			if (cpf.Length != 11)
				return false;

			tempCpf = cpf.Substring(0, 9);
			soma = 0;

			for (int i = 0; i < 9; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = resto.ToString();

			tempCpf = tempCpf + digito;

			soma = 0;
			for (int i = 0; i < 10; i++)
				soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

			resto = soma % 11;
			if (resto < 2)
				resto = 0;
			else
				resto = 11 - resto;

			digito = digito + resto.ToString();

			return cpf.EndsWith(digito);
		}

		public string FormataCPF(string sender)
		{
			string response = sender.Trim();
			if (response.Length == 11)
			{
				response = response.Insert(9, "-");
				response = response.Insert(6, ".");
				response = response.Insert(3, ".");
			}
			return response;
		}


	}
}
