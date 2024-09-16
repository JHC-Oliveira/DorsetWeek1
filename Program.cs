
using SuperHeros.Models;

Heros heroOne = new Heros();
heroOne.Name = "Peter Parker";
heroOne.HeroName = "Spider Man";

Heros heroTwo = new Heros();
heroTwo.Name = "Bruce Wayne";
heroTwo.HeroName = "Batman";

Heros heroThree = new Heros();
heroThree.Name = "Bruce/David Banner";
heroThree.HeroName = "Hulk";

List<Heros> list = new List<Heros>();
list.Add(heroOne);
list.Add(heroTwo);
list.Add(heroThree);

Heros heroFour = new Heros("Tony Stark", "Iron man");
list.Add(heroFour);

foreach(Heros hero in list)
{
    Console.WriteLine(hero);
}