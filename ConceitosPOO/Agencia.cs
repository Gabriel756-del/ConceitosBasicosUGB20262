using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Agencia
    {
        private string _nome;
        private string _telefone;
        private string _numero;

        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {
                if (value.Length > 3)
                {
                    _numero = value;
                }
                else
                {
                    throw new Exception("O campo deve conter mais de 3 caracteres");
                }
            }
        }

    }

}
