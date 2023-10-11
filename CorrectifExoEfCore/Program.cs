using CorrectifExoEfCore.Domain;
using CorrectifExoEfCore.Entities;

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

foreach (Film m in dc.MovieList)
{
    Console.WriteLine($"{m.Title} - {m.MainActor} - {m.Realisator} - {m.ReleaseYear}");
}
