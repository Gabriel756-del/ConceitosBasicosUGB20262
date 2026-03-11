using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceitosPOO
{
    public class Cliente
    {
        private string _nome;
        private string _cpf;

        public string Nome
        {
            get // pegar o valor
            {
                return _nome;
            }

            set // armazenar o valor
            {
                if (value.Length > 0)
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O campo não pode ficar vazio");
                }
            }
        }

        public string Cpf
        {
            get => _cpf;
            set
            {
                if (value.Length == 11)
                {
                    _cpf = value;
                }
                else
                {
                    throw new Exception("Não tem 11 caracteres");
                }
            }
        }
        public Cliente(string nome, string cpf)
        {
            _nome = nome;
            _cpf = cpf;
        }
    }
}
