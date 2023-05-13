namespace LINQ


{
    namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
           var vidgames = new List<string>{"Zelda" , "Halo", "Gears of War"};
           var sortedgames = vidgames.OrderBy(x => x.Length);
           foreach(var i in sortedgames)
           {
            Console.WriteLine(i);
            Console.WriteLine("----------");
           }
        }
    }
}
}



/*
Use the list of [Linq methods](https://portal.truecoders.io/course/1/lecture/62/lesson) 
for help

+ Create a list of video game names...
+ Order the list of games by length of the game name.
+ Use the lambda expression in this exercise as well.
+ use Method Syntax for this exercise
*/