using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosExplorando.Models
{
    public class LeituraArquivo
    {
        // Como um metodo so pode ter um tipo de retorno. Usa a tupla para quando quiser ter mais retornos
        public (bool Sucesso, string[] Linhas, int QtdLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}