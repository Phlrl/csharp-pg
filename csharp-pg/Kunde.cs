namespace csharp_pg
{
    public class Kunde
    {
        public string? Vorname { get; private set; }
        public string? Nachname { get; private set; }
        //vor und nachname, addresse(class) ein kunde hat mehre addressen(liste),  

        public string vornameSetzen(string GesezterVorname)
        {
            Vorname = GesezterVorname;
            return Vorname;
        }  

        public string nachnameSetzen(string GesezterNachname)
        {
            Nachname = GesezterNachname;
            return Nachname;
        } 
    }
}