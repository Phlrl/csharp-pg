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
}
