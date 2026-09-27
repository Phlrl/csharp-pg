namespace csharp_pg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Iban = Bankkonto.generateIban();
            Kunde hanspeter = new Kunde("Hans", "Peter");
            Bankkonto bk = new Bankkonto(1234, Iban, "1234", hanspeter);
            Console.WriteLine(bk.Kontoinhaber);
            bk.geldEinzahlen(20.29);
        }
    }
}
