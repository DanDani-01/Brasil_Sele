using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selecao_Brasa_POO
{
    internal class Goleiro: Jogadores
    {
        public Goleiro() {
            Posicao = "Goleiro";
        }
        public override string PosicaoCamp()
        {
            return "Joga no gol";
        }
    }
}
