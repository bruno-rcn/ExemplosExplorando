using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public static class IntExtensions
    {
        public static bool EhPar(this int numero) // esse this int extende o comportamento de var int. Agora toda var int pode acessar esse metodo
        {
            return numero % 2 == 0;
        }
    }
}