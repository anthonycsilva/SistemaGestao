using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Pessoa : DadosBancoBLL
    {
        public int ID_PESSOA { get; set; }
        public string NOME { get; set; }
        public int IDADE { get; set; }
        public string CPF { get; set; }


    }
}
