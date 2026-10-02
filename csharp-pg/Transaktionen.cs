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

        public bool checkForKontenInBankKonten()
        {
            string checkforibaninBankkonten= Console.ReadLine();
            foreach (Bankkonto bk in BankKonten)
            {
                if (checkforibaninBankkonten == bk.Iban)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
