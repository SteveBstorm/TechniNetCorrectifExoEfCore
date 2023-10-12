using CorrectifExoEfCore.Domain;
using CorrectifExoEfCore.Entities;
using Microsoft.EntityFrameworkCore;

DataContext dc = new DataContext();


#region Ajout du film
//Film film = new Film
//{
//    Title = "Pacific Rim",
//    Realisator = "Guillermo Del Toro",
//    ReleaseYear = 2013,
//    Genre = "Action",
//    MainActor = "Charlie Hunnam"
//};



//dc.MovieList.Add(film);
//dc.SaveChanges(); 
#endregion


#region Afficher film Avant 2001
//foreach (Film m in dc.MovieList.Where(f => f.ReleaseYear < 2001))
//{
//    Console.WriteLine($"{m.Title} - {m.MainActor} - {m.Realisator} - {m.ReleaseYear}");
//} 
#endregion

#region Modifier acteur des starwars
//foreach (Film m in dc.MovieList.Where(f => f.Title.Contains("Star Wars")))
//{
//    m.MainActor = "Harison Ford";

//}
//dc.SaveChanges(); 
#endregion

#region Suppression de films
//foreach (Film f in dc.MovieList.Where(f => f.MainActor == "Charlie Hunnam"))
//{
//    dc.MovieList.Remove(f);
//}

//dc.SaveChanges(); 
#endregion

List<Film> completeInfo = dc.MovieList.Where(x => x.Title.Contains("Star Wars")).Include(x => x.Realisator)
                                      .Include(x => x.Casting)
                                      .ThenInclude(x => x.Person).ToList();

foreach (Film m in completeInfo)
{
    Console.WriteLine($"{m.Title} - {m.Realisator.Firstname} {m.Realisator.Lastname} - {m.ReleaseYear}");
    Console.WriteLine();
    Console.WriteLine("Casting");
    Console.WriteLine("-------");
    Console.WriteLine();
    foreach (FilmPerson p in m.Casting )
    {
        Console.WriteLine($"{p.Person.Firstname} {p.Person.Lastname}");
    }
    Console.WriteLine();
    Console.WriteLine("-----------------");
    Console.WriteLine();
}

foreach(Person p in dc.PersonList.Include(x => x.AsActor).ThenInclude(x => x.Film))
{
    Console.WriteLine($"{p.Firstname} {p.Lastname}");
    foreach (FilmPerson f in p.AsActor) {
        Console.WriteLine($"{f.Film.Title}");
    }
}

