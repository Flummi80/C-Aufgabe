using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_aufgabe
{
    class A1
    {
        public static void Start()
        {
            int[] int_Array = new int[100];

            Random rnd = new Random();
            int x = rnd.Next(0, 100);            
            //Hier wird eine Zufallszahl zwischen 0 und 99 erzeugt und in die Variable x gespeichert.
            //Schreiben Sie im Bereich zwischen CODE START und CODE ENDE ihren Code rein.
            // Befühlen Sie das Array mit 100 Zufallszahlen;

            //CODE START

            //CODE ENDE

            foreach(var i in int_Array)
            {
                Console.Write(i + " ");
            }
        }
    }
}
