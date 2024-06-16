using System;
using System.Collections.Generic;

class Program
{
  public static void Main(string[] args)
  {


    // Here is our introduction statement telling the user what the program does
    Console.WriteLine("This Prgoram will find the Perfect numbers between 1 and 10,000:\n");

    
    
    // We initialize the unit test the professor is asking to us to test against the list of perfect numbers    
    int unitTest = 5112;

    
    
    /* We initialize a boolean to let the program know if the unitTest var compares equal against 
       any of the perfect numbers we create */
    bool unitTestTest = false;

    
    
    // We are going to create an array to store all the perfect numbers we find.
    List<int> perfectNumbers = new List<int>();

    
    
    // We are running a for loop start at 1 and ending at 10,000 that increments each iteration
    for (int tNumber = 1; tNumber <= 10000; tNumber++)
      {

        /* We initialize an int named sum that will be used to accumulate numbers that divide into the 
           iterative for loop value t_number */
        int sum = 0;

    
        
        /* Here we are running another for loop in a sub stack that will test each incremental iteration
           to see if when it is divided by any number less than itself it will come out equal to zero */
        for (int divisor = 1; divisor < tNumber; divisor++) 
        {

        
          
            // if the t_number var has no remainder when divided by the for loop control variable with modulus
            if (tNumber % divisor == 0) 
            { // then we accumulate the value of the divisor to the sum variable at its present state 
              sum += divisor;
            }


          
        }
        

        
        
        
        
        /* if the accumuation of all the numbers modulated by the divisor incrementor is equal to the
           number iterative in this stack */
        if (sum == tNumber)
          { // add the current incrementation of t_number to the list of perfect numbers
            perfectNumbers.Add(tNumber);          
        }


        
      }


    
    // We are going to create a for loop that goes through the perfectNumbers list
    foreach (int pn in perfectNumbers)
    {

      // foreach int in the perfectNumbers list we will print that int out
      Console.WriteLine(pn);


      
      /* After we write out each int in list we compare it to the unitTest variable
         to see if the unitTest variable matches any of the ints in the perfectNumbers list */
      
      // If the unitTest var matches the current iteration of the foreach perfectNumbers list value
      if (unitTest == pn)
          // We will tell the unitTest_test boolean that it is true instead of false
          { unitTestTest = true; }
      
    }




    // We are now going to print out a line to inform the audience about the unit test comparison
    Console.WriteLine("\nAnd it will test this unit test " + unitTest + " to see if it is a perfect number");



    

    // If the unitTest_test is true
    if (unitTestTest)
      // We inform the audience that the unit test is a perfect number
      { Console.WriteLine("\nUnit test " + unitTest + " is a Perfect Number."); }

    else
      // Else we inform the audience that the unit test is not a perfect number
      { Console.WriteLine("\nUnit test " + unitTest + " is Not a Perfect Number."); }

    
  }

  
  
  
}