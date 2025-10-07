using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoladorDados.Models
{
    public class Dado
    {
        private int qteLados;
        private int ladoSorteado;
        
        public Dado(int lados)
        {
            qteLados = lados;
        }

        public void Rolar()
        {
            ladoSorteado = Random.Shared.Next(1, qteLados + 1);
        }
    }
}