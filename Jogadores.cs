using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Brasa_POO
{
    internal class Jogadores
    {
        public string Nome { get; set; }
        public string Posicao { get; set; }
        public int Numero { get; set; }
        public int Idade { get; set; }
        public string Time { get; set; }
        public string Imagem { get; set; }

        public Jogadores() { 
        
        }

        public virtual string PosicaoCamp()
        {
            return Posicao+" no campo";
        }
    }
}
