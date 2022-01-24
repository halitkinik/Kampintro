// See https://aka.ms/new-console-template for more information
string kategoriEtiketi = "Kategori";
int ogrenciSayisi = 32000;
double faizOranı = 1.45;
bool sistemeGirisYapmisMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45;

if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu");
}
else if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu");
}
else
{
    Console.WriteLine("Eşittir butonu");
}


if (sistemeGirisYapmisMi == true) 
{
    Console.WriteLine("Kullanıcı Ayarları Butonu");
}
else
{
    Console.WriteLine("Giris yap butonu");
}

Console.WriteLine(kategoriEtiketi);


