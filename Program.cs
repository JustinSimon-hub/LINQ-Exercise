namespace LINQ


{
    public class Program
    {
        static void Main(string[] args)
        {
           
           
            List<string> VidGames = new List<string> { "Zelda", "Halo", "Gears of War" };
           
       var ans = VidGames.OrderBy(s => s.Length);
        foreach( string i in ans)
        {
            Console.WriteLine(i); 
        }


           
           


        }
    }

   
}
