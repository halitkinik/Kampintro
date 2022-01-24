// See https://aka.ms/new-console-template for more information

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "c#";
kurs1.Egitmeni = "Engin Demirog";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "java";
kurs2.Egitmeni = "Halit";
kurs2.IzlenmeOrani = 70;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "python";
kurs3.Egitmeni = "Taha";
kurs3.IzlenmeOrani = 75;

//Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmeni);

Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

foreach (var kurs in kurslar)
{
    //Console.WriteLine(kurs.KursAdi);
    Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmeni);
}


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmeni { get; set; }
    public int IzlenmeOrani { get; set; }

}



































