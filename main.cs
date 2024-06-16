using System;
using System.Collections.Generic;

class Program
{
  public static void Main(string[] args)
  {


    // Here is our introduction statement telling the user what the program does
    Console.WriteLine("This Prgoram will find the Perfect numbers between 1 and 10,000:\n");

    
    
    // We initialize the unit test the professor is asking to us to test against the list of perfect numbers    
    int unit_test = 496;

    
    
    /* We initialize a boolean to let the program know if the unit_test var compares equal against 
       any of the perfect numbers we create */
    bool unit_test_test = false;

    
    
    // We are going to create an array to store all the perfect numbers we find.
    List<int> perfectNumbers = new List<int>();

    
    
    // We are running a for loop start at 1 and ending at 10,000 that increments each iteration
    for (int number = 1; number <= 10000; number++)
      {

        /* We initialize an int named sum that will be used to accumulate numbers that divide into the 
           iterative for loop value number */
        int sum = 0;

    
        
        /* Here we are running another for loop in a sub stack that will test each incremental iteration
           to see if when it is divided by any number less than itself it will come out equal to zero */
        for (int divisor = 1; divisor < number; divisor++) 
        {

        
          
          // if the number ver has no remainder when divided by the for loop control variable with modulus
          if (number % divisor == 0) 
          { // then we accumulate the value of the divisor to the sum variable at its present state 
            sum += divisor;
          }


          
        }
        

        
        
        
        
        /* if the accumuation of all the numbers modulated by the divisor incrementor is equal to the
           number iterative in this stack */
        if (sum == number)
        { // add the current incrementation of number to the list of perfect numbers
          perfectNumbers.Add(number);          
        }


        
      }


    
    // We are going to create a for loop that goes through the perfectNumbers list
    foreach (int pn in perfectNumbers)
    {

      // foreach int in the perfectNumbers list we will print that int out
      Console.WriteLine(pn);


      
      /* After we write out each int in list we compare it to the unit_test variable
         to see if the unit_test variable matches any of the ints in the perfectNumbers list */
      
      // If the unit_test var matches the current iteration of the foreach perfectNumbers list value
      if (unit_test == pn)
        // We will tell the unit_test_test boolean that it is true instead of false
        { unit_test_test = true; }
      
    }




    // We are now going to print out a line to inform the audience about the unit test comparison
    Console.WriteLine("\nAnd it will test this unit test " + unit_test + " to see if it is a perfect number");



    

    // If the unit_test_test is true
    if (unit_test_test)
      // We inform the audience that the unit test is a perfect number
      { Console.WriteLine("\nUnit test " + unit_test + " is a Perfect Number."); }

    else
      // Else we inform the audience that the unit test is not a perfect number
      { Console.WriteLine("\nUnit test " + unit_test + " is Not a Perfect Number."); }

    
  }

  
  
  
}