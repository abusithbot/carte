using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carte
{
    internal class Joueur
    {
        string name;
        int PdV;
        int Disquette;

        Card[] main;

        public Joueur()
        {
            Console.WriteLine("Entre ton nom initié contre le capitalisme");
            name = Console.ReadLine();

            PdV = 20;
            Disquette = 5;


        }
    }
}
