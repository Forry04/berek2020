//8:59
//9:18

//19 perc
using berek2020;
using System.Text;

List<Dolgozo> dolgozok = [];

using StreamReader sr = new(@"../../../src/berek2020.txt",Encoding.UTF8);
_ =sr.ReadLine();
while (!sr.EndOfStream)
{
    dolgozok.Add(new Dolgozo(sr.ReadLine()));
}

//3
Console.WriteLine("3. feladat");
Console.WriteLine(dolgozok.Count);
Console.WriteLine();

Console.WriteLine("4. feladat");
Console.WriteLine($"{dolgozok.Average(d=>d.Ber)/1000:.0}");
Console.WriteLine();

Console.WriteLine("5. feladat");
Console.Write("Add meg a részeleg nevét: ");
string reszleg = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("6. feladat");
if (dolgozok.Any(d=>d.Reszleg.Equals(reszleg,StringComparison.OrdinalIgnoreCase)))
{
    Console.WriteLine(dolgozok.Where(d=>d.Reszleg.Equals(reszleg, StringComparison.OrdinalIgnoreCase)).MaxBy(d=>d.Ber));   
}
else
{
    Console.WriteLine("A megadott részleg nem létezik a cégnél!");
}
Console.WriteLine();

Console.WriteLine("7.feladat");
var reszlegek = dolgozok.GroupBy(d => d.Reszleg);
foreach (var item in reszlegek)
{
    Console.WriteLine($"{item.Key} - {item.Count()} fő");
}

