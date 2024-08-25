using ImdbListPractice;

public class Program
{
    static void Main(string[] args)
    {
        List<Movie> movieList = new List<Movie>();
        while (true)
        {
            Console.Write("Lütfen film adı giriniz. Çıkmak için 'h' tuşuna basınız.");
            string choiseName = Console.ReadLine().ToLower();
            if (choiseName == "h")
                break;
            Console.Write("Filmin IMDB puanını giriniz.");
            double choiseImdb;
            while (!double.TryParse(Console.ReadLine(), out choiseImdb))
            {
                Console.Write("Lütfen geçerli bir IMDB puanı girin: ");
            }
            Movie movie = new Movie(choiseName , choiseImdb );
            movieList.Add(movie);
        }
        Console.WriteLine("******Seçilen Filmler******");
        foreach (var Movie in movieList)
        {
            Console.WriteLine($"Seçilen Film -> {Movie.Name}" +
                              $"\nImdb Puanı -> {Movie.ImdbScore}");
        }
        Console.WriteLine("\n*** IMDB Puanı 4 ile 9 arasında olan filmler ***");
        foreach (var Movie in movieList)
        {
            if (Movie.ImdbScore >= 4 && Movie.ImdbScore <= 9)
                Console.WriteLine($"Film Adı -> {Movie.Name}, IMDB Puanı -> {Movie.ImdbScore}");
        }
        Console.WriteLine("\n*** 'A' harfi ile başl filmler ***");
        foreach (var Movie in movieList)
        {
            if(Movie.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"Filmin Adı -> {Movie.Name}" +
                                  $"\n Imdb Puanı -> {Movie.ImdbScore}");
        }



    }


}