using _09_13_sandorral;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;

List<Adatok> lista = new List<Adatok>();

string faljnev = "people.csv";

using (StreamReader sr = new StreamReader(faljnev))
{
    while (!sr.EndOfStream)
    {
        string sor = sr.ReadLine();
        Adatok s = new Adatok(sor);
        lista.Add(s);
    }
}

Console.WriteLine($"A legidősebb személy neve: {lista
    .OrderByDescending(x => x.kor)
    .Select(x => $"{x.vezetek_nev} {x.kereszt_nev}")
    .FirstOrDefault()}");

Console.WriteLine($"A legfiatalabb személy neve: {lista
    .OrderBy(x => x.kor)
    .Select(x => $"{x.vezetek_nev} {x.kereszt_nev}")
    .FirstOrDefault()}");

Console.WriteLine($"Átlag életkor: {lista.Average(x=>x.kor)}");