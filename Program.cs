namespace _12_T1_The_Basics_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string firstName = "Kylie";
            string favMovie = "The Matrix";
            string favQuote = "Po-ta-toes. Boil em, mash em, stick em in a stew";

            Console.WriteLine("Hello, World!");

            //1

            /*a*/
            Console.WriteLine($"My name is {firstName} and my favorite movie is {favMovie}.".ToLower());

            /*b*/
            favMovie = favMovie.ToUpper();
            Console.WriteLine(favMovie);

            /*c*/
            Console.WriteLine(favMovie.Contains("THE"));

            /*d*/
            favMovie = favMovie.Replace("A", "@");
            favMovie = favMovie.Replace("E", "3");
            Console.WriteLine();
            Console.WriteLine("Press ENTER to see question 2");
            Console.ReadLine();

            //2
            Console.WriteLine(favQuote);

            /*a*/
            favQuote = favQuote.ToLower();

            /*b*/
            favQuote = favQuote.Replace("a", "");
            favQuote = favQuote.Replace("e", "");
            favQuote = favQuote.Replace("i", "");
            favQuote = favQuote.Replace("o", "");
            favQuote = favQuote.Replace("u", "");
            Console.WriteLine(favQuote);
            
            //3

            /*
             
             (             )
              `--(_   _)--'
                   Y-Y
                 //@@ \
                //     \
                 `--'.  \             ,
                     |   `.__________/)

                ^deer
             
             */

            /*
             
                (\_._//)
                ( o o )
               //  V  \
              //(  _  )\
                 ^^ ^^

                ^owl
              
             */


        }
    }
}
