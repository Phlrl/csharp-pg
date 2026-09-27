namespace csharp_pg
{
    public class Addresse
    {
        public string? Strasse { get; set; }
        public string? Ort { get; set; }
        public bool HauptAddresse { get; private set; } = false;

        public Addresse(string strasse, string ort, bool hauptAddresse)
        {
            Strasse = strasse;
            Ort = ort;
            HauptAddresse = hauptAddresse;
        }
    }
}