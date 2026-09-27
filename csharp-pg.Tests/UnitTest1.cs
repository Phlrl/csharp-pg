namespace csharp_pg.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        string iban = Bankkonto.generateIban();  
        Kunde kunde = new Kunde("Hans", "Peter");
        Bankkonto konto = new Bankkonto(1234, iban, "1234", kunde);
        Addresse addresse = new Addresse("Strase", "Bonn", true);
        kunde.addresseHinzufuegen(addresse);
        
        Assert.True(kunde.AddresseVonKunden.Count == 1);
    }

    [Fact]
    public void Test2()
    {
        string iban = Bankkonto.generateIban();  
        Kunde kunde = new Kunde("Hans", "Peter");
        Bankkonto konto = new Bankkonto(1234, iban, "1234", kunde);
        Addresse addresse1 = new Addresse("Strase", "Bonn", true);
        Addresse addresse2 = new Addresse("Straseeee", "Berlin", true);
        bool checkforaddresse = false;
        checkforaddresse = kunde.addresseHinzufuegen(addresse1);
        Assert.True(checkforaddresse);
        bool checkforaddresse2 = false;
        checkforaddresse2 = kunde.addresseHinzufuegen(addresse2);
        Assert.False(checkforaddresse2);
        
        Assert.True(kunde.AddresseVonKunden.Count == 1);

    }

    [Fact]
    public void OOTerminologie()
    {
        // Variablendeklaration: <Type> <name_der_variablen>;
        Addresse addresse;   // Variable addresse hat keinen Wert

        // Aufruf Constructor = Instanziierung einer Addresse.
        // Dies erzeugt eine Instanz / Objekt vom Typ Addresse
        new Addresse("Goethestrasse1", "7464 Hamburg", false);

        // Assign / Zweisen eines Wertes. Die addresse hat jetzt Adress-Objekct
        addresse = new Addresse("Hauptstrase 31", "53334 Buxtehude", false);

        Assert.NotNull(addresse);

        // Deklaration einer Variablen und gleichzeitige Instanziieruung einer Klasse mit Zuweisung zu der Variablen
        Addresse addresse2 = new Addresse("Schillerstraße 1", "34773  Liepzig", false);

        // Klasse Adresse hat Properties (Stasse). Jetzt kann auf die Properties zugegriffen werden.
        Assert.Equal("34773  Liepzig", addresse2.Ort);

        Kunde hanspeter = new Kunde("Hans", "Peter");

        // Methodenaufruf aud der variable "hanspeter" und Übergebe die variable "addresse2" als Parameter
        // Rückgabewert wird ignoriert
        hanspeter.addresseHinzufuegen(addresse2);

        // Aufruf der methode addresseHinzufuegen des Objektes hanspeter. 
        // Der rückgabewert wird der variable rueckgagewerthanspeter zugewiesen
        bool rueckgabewerthanspeter = hanspeter.addresseHinzufuegen(addresse);

        // deklaration der variablen addresse3
        // instanziieren eine addresse und weisen diese instanz der variable addresse3 zu
        Addresse addresse3 = new Addresse("strase","asdawd", false);

        // equal ist methode zum vergleich von 2 strings.
        // übergeben: expected string, und erwarteter string = property von dem objekt addresse 3
        Assert.Equal("strase", addresse3.Strasse );

        // Deklaration der Variable addresse4 = der wert von addresse3 wird addresse4 zugewiesen 
        Addresse addresse4 = addresse3; 

        Assert.Equal(addresse3, addresse4);
    }
}
