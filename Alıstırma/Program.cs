// See https://aka.ms/new-console-template for more information


Arabalar araba1 = new Arabalar();
araba1.Renk = "Mavi";
araba1.Markasi = "BMW";
araba1.Yil = 2020;

Arabalar araba2 = new Arabalar();
araba2.Renk = "Siyah";
araba2.Markasi = "Mercedes";
araba2.Yil = 2021;


Arabalar araba3 = new Arabalar();
araba3.Renk = "Beyaz";
araba3.Markasi = "Audi";
araba3.Yil = 2022;

Arabalar[] araba = new Arabalar[] { araba1, araba2, araba3 };

foreach (var a in araba)
{
    Console.WriteLine(a.Renk + " " + a.Markasi + " " + a.Yil);
}

class Arabalar
{
    public int Yil { get; set; }
    public string Markasi { get; set; }
    public string Renk { get; set; }
}