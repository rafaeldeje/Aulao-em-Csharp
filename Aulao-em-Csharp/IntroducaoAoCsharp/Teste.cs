using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Teste
    {
        static void Main(string[] args)
        {
            var totalSomatrio = 0;

            foreach (var idade in idades)
                totalSomatrio += idade;

            return totalSomatrio / idades.Count;
        }
    }
}