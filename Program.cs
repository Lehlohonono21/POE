using PART1;
using System;
using System.Transactions;
using System.Collections;

namespace Part1;

class Recipes
{
    static string recName, ingredName, number, meas, qua, steps, follow,read;
    static int ingredNumber, value,  num,  i;
    static double Quantity, Measurement;
    static void Main(string[] args)
    {
        Quantities factor = new Quantities();
        NewRecipes recipes = new NewRecipes();
        // Welcome statement
        Console.WriteLine("**** WELCOME TO AN APPLICATION WHERE YOU CAN STORE YOUR RECIPE AND ALSO STEPS***");
        Console.WriteLine();
        Console.WriteLine();

        // the user is able to enter the recipe's name 
        Console.WriteLine("Enter name of the recipe: ");

        // users inputs the name of the recipe
        recName = Console.ReadLine();

        Console.WriteLine("Enter the number of ingredients you would like to follow: ");
        number = Console.ReadLine();
        ingredNumber = int.Parse(number); // This code converts the st
                                          // ring into int from the user 

        // stores the information in array called value
        int[] value = new int[ingredNumber];
        for (int k = 0; k < value.Length; k++)
        {
            Console.WriteLine("Enter the name of the ingredient: ");
            ingredName = Console.ReadLine();

            Console.WriteLine("\n Enter the quantity of the ingredient: ");
            qua = Console.ReadLine();
            Quantity = double.Parse(qua);// This code converts the string into double from the user 


            Console.WriteLine("\n Enter the unit of the measurement (in kg): ");
            meas = Console.ReadLine();
            Measurement = double.Parse(meas);// This code converts the string into int from the user 

        }
        // steps
        Console.WriteLine("Enter the number of steps you would like to follow");
        follow = Console.ReadLine();
        num = int.Parse(follow);
        // stores the steps in an array called steps
        string[] steps = new string[num];
        for (int i = 0; i < steps.Length; i++)
        {
            int rank = i + 1;
            Console.Write("Step " + rank + ": ");
             read = Console.ReadLine();

        }
        // From this line the console will display the full recipe
        Console.WriteLine("Would you like to see the full recipe?  Please type yes or no");
        string answer = Console.ReadLine();
        if (answer == "yes")
        {
            foreach (int message in value)// using the foreach statement to print out the values stored in values 
            {


                Console.WriteLine(" The name of the recipe is: " + recName);

                Console.WriteLine(" The ingridient Name is: " + ingredName);
                Console.WriteLine(" The Quantity is: " + Quantity);
                Console.WriteLine("The measuremet is: " + Measurement);
                Console.WriteLine();
                foreach (string read in steps) {
                    Console.WriteLine(read);
                }
                
            }
        }
        else
        {
            Console.ReadLine();// breaks the code
        }
        Console.WriteLine("Do you wish to scale your quantittes? Type yes or no");
        string reply = Console.ReadLine();
        if ( reply == "yes") {
            // the user maes a selection of a factor should the user want to change the quantities
            Console.WriteLine("What factor do you want your quantites to be scaled? ");
            Console.WriteLine("Please make a selection from the following menu: ");
            Console.WriteLine(" Press 1: 0.50(half) " +
                "\n Press 2: 2(double)" +
                "\n Press 3: 3 (Triple)");
            string response = Console.ReadLine();
            double val = double.Parse(response);// converts string int double
            factor.newSize = Quantity;/* the newSize object in the quantities class is 
                                       * equavelent to the Quantity that is stored in the Program class*/
            switch (val)
            {
                case 1:
                    Console.WriteLine("\n Your new Quantity is: "+factor.newSize * 0.5);
                    break;
                case 2:
                    Console.WriteLine("\n Your new Quantity is: "+ factor.newSize*2);
                    break;
                    case 3: 
                        Console.WriteLine("\n Your new Quantity is: "+factor.newSize*3);
                    break;
                default: Console.WriteLine("Your factor is unavailable");
                    break;
            }

        }
        else
        {
            Console.Read();
        }


        Console.WriteLine("\n Do you wish to reset your Quantities to the original values?");
        string res = Console.ReadLine();
        if (res == "yes")
        {
            factor.reset = Quantity;
            Console.WriteLine("The old Quantity is :"+ Quantity);

        }
        else
        {
            Console.Read();
        }

        Console.WriteLine("\n Do you wish to reset your Ingredients?");
        recipes.newName = value;
        string ans = Console.ReadLine();
        if (ans == "yes")
        {
            Array.Clear(recipes.newName, 0, recipes.newName.Length);
            foreach (int menu in value)
            {


                Console.WriteLine(menu);


            }
        }
        else {
            Console.Read();

        }
            
        
        Console.Read();// Wait for a comand

    }
}
