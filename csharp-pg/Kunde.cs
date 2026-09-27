using System.Security.Cryptography.X509Certificates;

namespace csharp_pg
{
    public class Kunde
    {
        public string? Vorname { get; private set; }
        public string? Nachname { get; private set; }
        public List<Addresse> AddresseVonKunden { get; private set; } = new List<Addresse>();

        public Kunde(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }
        
        public bool addresseHinzufuegen(Addresse addresse)
        {
            bool hasHauptAddresse = checkForHauptAddresse();
            if (hasHauptAddresse == true && addresse.HauptAddresse)
            {
                return false;
            }
            AddresseVonKunden.Add(addresse);
            return true;
        }

        public bool checkForHauptAddresse()
        {
            foreach (Addresse addresse in AddresseVonKunden)
            {
                if (addresse.HauptAddresse == true)
                {
                    return true; 
                }
            }
            return false;
        }
    }
}