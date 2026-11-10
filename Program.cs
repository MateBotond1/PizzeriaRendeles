using PizzeriaRendeles;
List<Rendeles> Lista=new List<Rendeles>();
foreach(string sor in File.ReadAllLines("rendelesek.txt"))
{
    Lista.Add(new Rendeles(sor));
}
Console.WriteLine("Napi rendelések:");
foreach(Rendeles aktualis in Lista)
{
    Console.WriteLine(aktualis);
}
Console.WriteLine("Statisztika:");
int osszesen = Lista.Sum(x => x.FizetendoDij());
Console.WriteLine($"Pizzéria teljes napi bevétele: {osszesen} Ft");
Rendeles legjobb = Lista.MaxBy(x => x.PizzakSzama);
Console.WriteLine($"Legtöbb pizzát rendelő vásárló: {legjobb.VevoNev} ({legjobb.PizzakSzama} db)");