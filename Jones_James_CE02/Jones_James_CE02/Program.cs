using System;

namespace Jones_James_CE02
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * James M. Jones
             * 03/06/2021
             * DEV2000-O 02: Introduction to Development II
             * 1.6 Code Exercise: Arrays
            */
            //Problem #1: Book Buyer

            //First, I want to prompt the user for the amount of books they wish to purchase.
            Console.WriteLine("We are going to the book fair!");
            Console.WriteLine("How many books would you like to buy?");

            //Next, we want to listen for the user's input.
            //This input should only be a positive whole number.
            string stringNumBooks = Console.ReadLine();

            /* declare your int variable here and not in while loop, you will need it later
             * 
             *
             * */

            int numBooks;

            // int numBooks and remove the int in the while loop
            while (!int.TryParse(stringNumBooks, out numBooks) || numBooks !< 0)
            {
                //Tell the user the problem
                Console.WriteLine("\r\nPlease only type in postive number values.");

                //Restate the question
                Console.WriteLine("\r\nHow many books would you like to buy?");

                //Catch the user's response
                //USE same variable!
                stringNumBooks = Console.ReadLine();
            }

            //Now, we need to know how much each book costs.
            //We can create an array to handle this.
            Console.WriteLine("Now we need to know how much each book will cost.");

            /*
             * You now have the number of books create a for loop like
             * for(int c = 0; c< numBooks; c++){
             *  // ask user for book cost
             *  // validate entry and make sure cost is > 0 as well as tryParse - make sure you use decimal
             *  // if successful validation add bookCost to your array
             * }
             * */

            //I want to declare and define my array to add the cost of the books to the number of books that we are looping through.
            //The array will be the size of the user's input of the number books requested.
            
            decimal[] bookCost = new decimal[numBooks];

            //This for loop will run for the number of books that the user inputs.
            for (int i = 0; i < numBooks; i++)
            {   //We want to ask for the cost of each book and add to the array.
                Console.WriteLine("What is the cost of book #{0} ?", i + 1);

                string stringBookCost = Console.ReadLine();

                decimal costOfBook;

                while (!decimal.TryParse(stringBookCost, out costOfBook) || costOfBook < 0)
                {
                    //Tell the user the problem
                    Console.WriteLine("\r\nPlease only type in postive decimal values.");

                    //Restate the question
                    Console.WriteLine("\r\nWhat is the cost of book #{0} ?", i + 1);

                    //Catch the user's response
                    //USE same variable!
                    stringBookCost = Console.ReadLine();
                }
                //Saves the cost of the books to the initial array.
                bookCost[i] = costOfBook;
            }

            decimal totalCostOfBooks = 0;

            for (int i = 0; i < bookCost.Length; i++)
            {
                totalCostOfBooks = totalCostOfBooks += bookCost[i];
            }
            Console.WriteLine("The total for those {0} books is ${1} ", numBooks, totalCostOfBooks);

            /*
             * You wont need the above while loops because of your for loop above
             * Now create another for loop to loop thru your array and add up the book cost
             * something like
             * declare variable for total must be decimal and initilize to zero
             * loop thru array and add books up like
             * totalBookCost += costOfBooks[i];
             * after for loop write your output
             * Your total for those 3 books is $19.25 // just an example output
             * */

            //Problem #2: Coloring Outside The Lines

            Console.WriteLine("Here are a few of my favorite things!");

            Console.WriteLine("Please press ENTER to continue");

            Console.ReadLine();

            //Declare and define a string array for random things at home.

            string[] randomThings = new string[] {"grapes", "apples", "limes", "lemons"};

            //Declare and define a string array for colors and match the indexes with 

            string[] colors = new string[] { "purple", "red", "green", "yellow" };

            // I decided to use an if statement conditional in order to confirm the size of the arrays are equal.

            if (randomThings.Length == colors.Length)
            {
                //if the conditional that the arrays are equal in .Length, the for loop will run
                //based on the length of the first string array since both arrays are equal in size.
                for (int i = 0; i < randomThings.Length; i++)
                {
                    //Finally, I want to output the result to the console using advanced string concatenation
                    //for a clean, optimial reading experience.
                    Console.WriteLine("The main color of the {0} is {1}",randomThings[i], colors[i]);
                }
            }
        }
    }
}
