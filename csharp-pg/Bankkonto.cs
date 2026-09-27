namespace csharp_pg
{
    public class Bankkonto
    {
        private static Random r = new Random();
        public static string generateIban()
        {
            return r.Next(100000000, 999999999).ToString();
        }

        public static string generateKontonummer()
        {
            return r.Next(10000, 99999).ToString();
        }

        public static int generatePin()
        {
            return r.Next(1000, 9999);
        }
        
        public double Kontostand { get; private set; } = 0 ;
        private int Pin = 0;
        public string Iban { get ; private set; } 
        public string? Kontonummer { get ; private set; } 
        public Kunde? Kontoinhaber { get ; private set;}

        public Bankkonto(int pin, string iban, string kontonummer, Kunde kontoinhaber)
        {
            Pin = pin;
            Iban = iban;
            Kontonummer = kontonummer;
            Kontoinhaber = kontoinhaber;
        }

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

        public void geldEinzahlen(double EingezahltesGeld)
        {
            Kontostand = Kontostand + EingezahltesGeld;
        }

        private double kontostandAnzeigen()
        {
            return Kontostand;
        }

        public bool geldAuszahlen(int betrag)
        {
            if(Kontostand >= betrag)
            {
                Kontostand = Kontostand - betrag;
                return true;
            }
            else
            {
                Console.WriteLine("Transaktion Fehlgeschlagen");
                return false; 
            }
        }

        public bool geldAufEinAnderesKontoEinzahlen(List<Bankkonto> bankkontos ,string EmpfaengerIban, double EmpfaengerBetrag)
        {

            foreach (Bankkonto bk in bankkontos)
            {
                if (Iban == EmpfaengerIban)
                {
                    bk.geldEinzahlen(EmpfaengerBetrag);
                    Console.WriteLine("Der Betrag in Höhe von " +EmpfaengerBetrag + " Wurde auf das Konto mit der Iban " +EmpfaengerIban +" eingezalt");
                    return true;
                }
            }
            return false;
        }
    }
}
