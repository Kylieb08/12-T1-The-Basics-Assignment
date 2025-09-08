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
            Console.WriteLine();
            Console.WriteLine("Press ENTER to see question 3");
            Console.ReadLine();

            //3
            Console.WriteLine("(             )                      (\\_._/)");
            Console.WriteLine(" `--(_   _)--'                       ( o o )");
            Console.WriteLine("      Y-Y                            /  V  \\");
            Console.WriteLine("     /@@ \\                          /(  _  )\\");
            Console.WriteLine("    /     \\                           ^^ ^^");
            Console.WriteLine("    `--'.  \\             ,          ");
            Console.WriteLine("        |   `.__________/)           ");

            /* 1. Provide two different ways to write a greeting to someone who's name is stored in a string variable firstName.
            * Use string interpolation and the + operator. Which method do you prefer? 

            * There are two ways to write something stored in a string variable. The first is to use the + operator.
            * It connects two strings together. The second is to use string interpolation. It is done by placing a $ 
            * before the string, and then placing the variable in curly braces {}. 
            * I prefer string interpolation because it's cleaner. */

            /* 2. How would you print out the number of characters in a string called passPhrase?
             * Console.WriteLine(passPhrase.Length); */

            /* 3. What does the Trim() method do? Why might this be useful?

             * The Trim() method removes spaces before and after a string. This is useful because sometimes the spaces 
             * go unnoticed and it is easier to remove them than to find them. */

            /* 4. Methods such as Trim(), ToUpper(), ToLower() and Replace() do not actually
             * change the original string. Instead they return a new string. What do you need to add to the
             * following line of code so that schoolCheer will be all caps when it is printed? (Hint: you will need
             * to overwrite the existing string with the new version returned by the method)

             * schoolCheer = "programmers are the best!";
             * schoolCheer = schoolCheer.ToUpper();
             * Console.Writeline(schoolCheer); */

            /* 5. Attempt the challenge on step 5 of the Hello World tutorial by using StartsWith() and
             * EndsWith(). Put the lines of code you used here:

             * Console.WriteLine(songLyrics.StartsWith("goodbye"));
             * Console.WriteLine(songLyrics.StartsWith("You"));
             * Console.WriteLine(songLyrics.EndsWith("hello"));
             * Console.WriteLine(songLyrics.EndsWith("goodbye")); */

            /* 6. What is the difference between Console.WriteLine() and Console.Write()?

             * Console.WriteLine() writes the text and then moves to the next line. Console.Write() writes the text 
             * and stays on the same line. */
        }
    }
}
