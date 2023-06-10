using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08GeteSet2
{
    public class CaixaMagica
    {
        private string cor; // Propriedade privada para armazenar a cor da caixa

        public string Cor
        {
            get // Função get para obter o valor da cor
            {
                return cor;
            }
            set // Função set para definir o valor da cor
            {
                cor = value;
            }
        }
    }

}