namespace berek2020;

internal class Dolgozo
{
    public string Nev { get; set; }
    public bool Nem { get; set; }
    public string Reszleg { get; set; } 
    public int Belepes { get; set; }
    public int Ber{ get; set; }

    public Dolgozo(string sor)
    {
        string[] m = sor.Split(';');
        Nev = m[0];
        Nem = m[1] == "férfi";
        Reszleg = m[2];
        Belepes = int.Parse(m[3]);
        Ber = int.Parse(m[4]);
    }

    public override string ToString()
    {
        return $"{Nev} {(Nem?"Férfi":"Nő")} {Reszleg} {Belepes} {Ber}";
    }
}
