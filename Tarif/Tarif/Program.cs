using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Telefonieren
            Console.WriteLine("Bitte geben Sie die Anzahl der Minuten ein, die Sie im Monat telefonieren");
            double Input1 = double.Parse(Console.ReadLine());

            //SMS
            Console.WriteLine("Bitte geben Sie die Anzahl der SMS im Monat ein");
            double Input2 = double.Parse(Console.ReadLine());

            //Calculate
            double Ergebnis1 = 0;
            double Ergebnis2 = 0;
            double Gesamt = 0;
            double Euro = 0;

            //Tarif 1
            Ergebnis1 = Input1 * 10;
            Ergebnis2 = Input2 * 10;
            Gesamt = Ergebnis1 + Ergebnis2;
            Euro = Gesamt / 100;
            

            Console.WriteLine($"Tarif 1 betraegt insgesamt {Gesamt} ct / {Euro} Euro im Monat.");

            //Tarif2
            double Grundgebuehren = 500;
            double Ergebnis3 = 0;
            double Ergebnis4 = 0;
            double Gesamt2 =0;
            double Euro2 = 0;

            Ergebnis3 = Input1 * 5;
            Ergebnis4 = Input2 * 5;
            Gesamt2 = Ergebnis3 + Ergebnis4 + Grundgebuehren;
            Euro2 = Gesamt2 / 100;

            Console.WriteLine($"Tarif 2 betraegt insgesamt {Gesamt2} ct / {Euro2} Euro im Monat. ");

            //Leer
            Console.WriteLine();

            //vergleich

            double Vergleich1 = 0;
            double Vergleich2 = 0;

            Vergleich1 = Euro2 - Euro;
            Vergleich2 = Euro - Euro2;

            if (Euro > Euro2)
            {
                Console.WriteLine($"Tarif 1 wird empfohlen, da Sie {Vergleich2} Euro sparen ");
            }
            else if (Euro2 > Euro)
            {
                Console.WriteLine($"Tarif 2 wird empfohlen, da Sie {Vergleich1} Euro sparen ");
            }
            Console.ReadLine();
            



        }
    }
}
