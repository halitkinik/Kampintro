﻿// See https://aka.ms/new-console-template for more information

string[] kurslar = new string[]
{
    "Yazılım Geliştirme",
    "Proje Geliştirme",
    "Python"
};

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}

Console.WriteLine("For bitti");

foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("Sayfa sonu - footer");