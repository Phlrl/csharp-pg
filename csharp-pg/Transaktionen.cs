namespace csharp_pg
{
    public class Transaktion
    {
        Bankkonto? bk;
        public List<Bankkonto> BankKonten {get; private set;} = new List<Bankkonto>();

        public void KontoZuBankKontenAdden()
        {
            BankKonten.Add(bk);
        }
    }
}