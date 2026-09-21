using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace csharp_pg
{
        public class Bankkonto
    {
        private double Kontostand = 0;
        public int Pin = 0;
        private int Iban = 0;
        int Kontonummer = 0;
        string Kontoinhaber;

        private void setPin(int PinZahl)
        {
            Console.WriteLine("Setzt deine Pin (4-stellig)");
            if (PinZahl >= 1000 && PinZahl <= 9999)
            {
                Pin = PinZahl;
            }
            else
            {
                Console.WriteLine("Pin muss 4-stellig sein");
            }
        }

        private void checkPin()
        {
            Console.WriteLine("Gebe deine Pin ein: ");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            
            int counter = 0;

            while(counter != 3)
                if(eingabe == Pin)
                {
                    Console.WriteLine("Zugang gewärt");
                }
                else
                {
                    Console.WriteLine("Try again");
                    counter ++;
                }
        }

        private double kontostandAnzeigenAfterAcces()
        {
            return Kontostand;
        }

        private void geldEinzahlen(double EingezahltesGeld)
        {
            Kontostand = Kontostand + EingezahltesGeld;
        }

        private double kontostandAnzeigen()
        {
            return Kontostand;
        }

    }
}
