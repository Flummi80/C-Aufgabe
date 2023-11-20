using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT_aufgabe
{
    class A2
    {
        public static void Start()
        {
            //Der Nutzer soll 10 Zahlen eingeben. Diese werden in das Array gespeichert. 
            //Die Zahlen, die größte und die kleinste davon werden anschließend ausgegeben.
            // Schreiben innerhalb von CODE START - CODE ENDE das Programm fertig
            double[] dbl_Array = new double[10];
            double max_Zahl = double.MinValue; //MinValue ist die kleinstmögliche Double Zahl die es gibt
            double min_Zahl = double.MaxValue; //MaxValue ist die größtmögliche Double Zahl die es gibt
            //CODE START

            //CODE ENDE

            Console.WriteLine("Ihre Eingaben waren: ");
            foreach(var i in dbl_Array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n Die größte Zahl ist: " + max_Zahl);
            Console.WriteLine("Die kleinste Zahl ist: " + min_Zahl);

        }
    }
}
