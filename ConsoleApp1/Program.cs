using ConsoleApp1;

List<Kuldetes> kuldetesek = new();
using StreamReader sr = new(@"..\..\..\res\kuldetesek.csv");
while (!sr.EndOfStream) kuldetesek.Add(new Kuldetes(sr.ReadLine()));

Console.WriteLine($"3. Feladat: \n\tösszesen {kuldetesek.Count} űrhajó lett indítva.");


int UtasokSzamanakOsszege = kuldetesek.Sum(x => x.UtasokSzama);
Console.WriteLine($"4. Feladat: \n\t{UtasokSzamanakOsszege} utas indult az űrbe összesen.");


int k5u = kuldetesek.Count(x => x.UtasokSzama < 7);
Console.WriteLine($"5. Feladat: \n\t" +
                  $"Összesen {k5u} alkalommal küldtek kevesebb mint 5 embert az űrbe.");