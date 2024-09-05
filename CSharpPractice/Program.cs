using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using MyLibrary;

namespace CSharpPractice
{
    struct Product
    {
        public string Name { get; set; }

        public Product(string input)
        {
            this.Name = input;
        }

        public override string ToString()
        {
            return "Redgate " + this.Name;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Product("The weather is good");
            var q = new Product("Hello how are you");

            p = q;
            q.Name = "New Value";
            Console.WriteLine(p);   // Redgate Hello how are you
            Console.WriteLine(q);   // Redgate New Value

        }

        static void TestPassByReferenceArray()
        {
            string[] str = new string[3];
            str[0] = "a";
            str[1] = "b";
            modifyStr(str);

            str.ToList().ForEach(ele => Console.WriteLine(ele));
        }

        static void modifyStr(string[] str)
        {
            str[2] = "c";
        }

        static void TestMineSweeper()
        {
            Minesweeper minesweeper = new ();
            //Minesweeper minesweeper = new Minesweeper("*.*. ...* .*.. **..");
            Console.WriteLine(minesweeper);
        }

        static void TestLinq()
        {
            Console.WriteLine();
            Console.WriteLine("Show all movies");
            List<Movie> movies = Movie.GetDemoData();
            movies.ForEach(movie => Console.WriteLine(movie));

            // Check if any item contains "or"
            Console.WriteLine();
            Console.WriteLine("Check and pop-out movies with `or`");
            bool hasMovieWithOr = movies.Any(movie => movie.Name.ToLower().Contains("or"));

            if (hasMovieWithOr)
            {
                List<Movie> moviesWithOr = movies.Where(movie => movie.Name.Contains("or", StringComparison.CurrentCultureIgnoreCase)).ToList();
                moviesWithOr.ForEach(movie => Console.WriteLine(movie));
            } else
            {
                Console.WriteLine("Record Not Found");
            }

            // Check if all has a string
            Console.WriteLine();
            string targetHasString = "t";   // all have t
            Console.WriteLine($"Check if all have the string {targetHasString}");
            bool isAllMovieHasString = movies.All(movie => movie.Name.Contains(targetHasString, StringComparison.CurrentCultureIgnoreCase));

            Console.WriteLine(isAllMovieHasString ? $"All have string {targetHasString}" : $"Not all have sting {targetHasString}");

            // Get distinct
            Console.WriteLine();
            Console.WriteLine("Show Distinct Movies");
            List<Movie> distinctedMovies = movies.DistinctBy(movie => movie.Name).ToList();
            distinctedMovies.ForEach(movie => Console.WriteLine(movie));

            // Select only required column
            Console.WriteLine();
            Console.WriteLine("Show Selected Info");
            List<object> selectedInfo = movies.Select(movie => new { movie.Name, movie.Year }).ToList<object>();
            selectedInfo.ForEach(movie => Console.WriteLine("{0}", movie));

        }



        static void TestFindMovies()
        {
            List<Movie> movies = Movie.GetDemoData();

            List<Movie> filteredMovies = movies.Where(movie => movie.Rating > 4.5).ToList();

            foreach(Movie movie in filteredMovies)
            {
                Console.WriteLine(movie);
            }
        }

        static void TestCountingEvenAndOddNumbers()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            int evenCount = numbers.Count(n => n % 2 == 0);
            int oddCount = numbers.Count(n => n % 2 != 0);

            Console.WriteLine($"Even Count: {evenCount}");

            Console.WriteLine($"Odd Count: {oddCount}");

        }

        static void TestReverseWordOrders()
        {

            Console.WriteLine("Please enter a string: ");
            string str = Console.ReadLine() ?? string.Empty;

            string[] strArray = str.Split(" ");

            Array.Reverse(strArray);

            Console.WriteLine(String.Join(", ", strArray).ToString());
        }

        static void TestFindAllSubstring()
        {
            Console.WriteLine("Please enter a string: ");
            string str = Console.ReadLine() ?? string.Empty;

            List<string> resultList = new List<string>();

            // take `testing` string as example
            // start from the 1st character of the string e.g. t
            for(int startingPosition = 0; startingPosition < str.Length; startingPosition++)
            {
                // set the capacity of the StringBuilder for more memory efficient
                int capacity = str.Length - startingPosition;   

                StringBuilder stringBuilder = new StringBuilder(capacity);
                // then list out the combination starts from t
                // i.e. from the startingPosition to the end of the string, record down the combinations
                for(int capturePosition = startingPosition; capturePosition < str.Length; capturePosition++)
                {
                    stringBuilder.Append(str[capturePosition]);
                    // put the current build to the resultList
                    resultList.Add(stringBuilder.ToString());
                }
            }

            // join the result and print out
            Console.WriteLine(String.Join(", ", resultList.ToArray()).ToString());

        }

        static void TestFindPrime()
        {

            bool logging = true;

            while (logging)
            {
                Console.Write("Please enter a number: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (input.ToLower().Equals("exit"))
                {
                    // exit the loop in here
                    logging = false;
                }

                // continue checking
                if (int.TryParse(input, out int num))
                {

                    bool isPrime = IsPrime(num);


                    Console.WriteLine(
                        isPrime ? "A Prime Number" : "Not A Prime Number"
                    );


                } else
                {
                    // log and continue to readline again
                    Console.WriteLine("This is not a number");
                }


            }

        }

        static bool IsPrime(int num)
        {
            if (num <= 1) return false; // 1 is not a prime
            if (num == 2) return true; // 2 is a prime

            if (num % 2 == 0) return false; // even number other than 2 is not a prime number

            // we only check from 2 to the i^2 as checking later dividers are meaningless
            // say for 16, checking to 4x4 is enough, as 3x5 == 5x3 will caused unnecessary checkings
            for (int i = 2; Math.Pow(i, 2) <= num; i++)
            {

                if (num % i == 0) return false;

            }
            // a default return
            return true;
        }

        static void TestErrorHandling()
        {
            Note.ErrorHandling();
        }

        static void TestPassByReference()
        {

            int num = 100;
            Note.TestPassByReference(ref num);
            Console.WriteLine(num);
        }

        static void TestInterface()
        {
            MyFactory myFactory = new MyFactory(new Rectangle(100, 200));
            myFactory.GenerateDetail();
            
        }

        static void TestOutParameter() {

            Note.TestOutParameters();


            MyList myList = new MyList(new List<string> {
                "Coffee", "Milk", "Apple"
            });

            bool isExist = myList.IsStringExists("app1le", out int isExistsIndex);

            Console.WriteLine(isExist ? "Found" : "Not Found");
            Console.WriteLine($"The index is {isExistsIndex}");

        }

        static void TestReverseArray2()
        {
            string[] stringArray =
            {
                "testing",
                "what"

            };
            MyArray<string> myArray = new MyArray<string>(stringArray);
            PrintArray<string[]>(myArray.getReversedArray2());
        }

        static void TestSortingStringByMedalType()
        {
            string[] medals =
            {
                "Silver - Class A",
                "Gold - What 2",
                "Gold - What 1",
                "Silver - Bobby",
                "Bronze - Tinder"
            };

            Array.Sort(medals, new MedalComparer());

            foreach(string medal in medals)
            {
                Console.WriteLine(medal);
            }
        }

        static void TestReverseArray()
        {
            int[] inputArray = { 1, 2, 3, 4, 5 };

            Console.WriteLine(String.Join(",", inputArray));

            MyArray<int> myArray = new MyArray<int>(inputArray);

            int[] reversedArray = myArray.getReversedArray();
            PrintArray<Int32[]>(reversedArray);
        }

        static void TestPalindrom()
        {

            string inputString = "abcdefedcba";

            MyString myString = new MyString(inputString);
            //myString.setInputString(myString);

            Boolean isPalindrome = myString.IsPalindrome();

            string wordForPalindromeOutput = isPalindrome ? " " : " NOT ";

            Console.WriteLine($"{inputString} is{wordForPalindromeOutput}palindrome");
        }

        static void TestReverseString()
        {
            string stringToReverse = "This is a testing";

            MyString myString = new MyString(stringToReverse);

            string reversedString = myString.getReversedString();

            Console.WriteLine($"The reversed string of {stringToReverse} is {reversedString}");

        }

        static void PrintArray<InputArrayType>(InputArrayType inputArray)
        {
            if (inputArray is Array)
            {
                Array array = inputArray as Array;
                Console.WriteLine(String.Join(",", array.Cast<object>()));
            }
            else
            {
                Console.WriteLine(inputArray.ToString());

            }
        }

    }
}