using System;
using System.Collections.Generic;

namespace VisualNavExamples
{
	public class HelloWorldTemplate
	{
        static void Main(string[] args)
		{
            // Welcome to the Hello World with FizzBuzz template
            // Get started, make sure VisualNav for Visual Studio is installed and optionally, motion input
            // https://sites.google.com/view/visualnav/download
            // Step 1
            // Open VisualNav
            // With motion input, Voice Command - "Open All Windows" or Select Tools -> OpenAllWindows


            // Step 2
            // Print hello world
            // Naviagate the Command Pallet (radial menu), by selecting Code -> Text. Click the 'text' block
            // and the 'print' block (in the second page). And then, these two blocks will be created in the building window.
            //
            // Input 'hello world' in the 'text' block using keyboard or voice command and connect it with the 'print' block.
            // 
            // Choose a right position in the Main method and click the 'insert code' button.
            // The result would be like Console.WriteLine("hello world");
            //
            // Example is provided in examples/hello world.jpg

            Console.writeLine("hello world");

            // We can also write a more complicated algorithm, this prints  Fizz on odd numbers and Buzz on even numbers
            // Use 'for (code -> loops -> for)' block to create for loops, and use 'number (code -> math -> number)' block to specify the loop condition.
            // Use 'get (code -> variables -> get)' block to get the loop variable.
            // Use 'if (code -> logic -> if)' block to create if statements and use mutator to create more if esle statements.
            // Use 'compare (code -> logic -> compare)' block to combine different boolean conditions.
            // Use 'print (code -> text -> print)' block and 'text (code -> text -> text)' block to print the results.
            //
            // Example is provided in examples/FizzBuzz.jpg.

            dynamic i;
            for ( i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }




            // Step 3
            // Using a library (currently C# only)
            // For exampe, we want to use the Math.random() function. 
            //
            // Choose the library name and the function name (Math.random).
            //
            // Navigate the Command Pallet by selecting Custom Blocks -> Custom Function. 
            // Then you will see a new command called Math.random() under the Custom Blocks directory.
            //
            // Use 'set' block and set the result of function to a variable x
            // Use 'print' block to print the result.
            //
            // Example is provided in examples/custom function.jpg


            var x;
            x = Math.random();
            Console.WriteLine(x);

            // Step 4
            // Using Thread library (currently C# only)
            // import Thread library by using System.Threading;
            //
            // Create a function called ThreadProc (code -> functions -> def no return)
            // The ThreadProc method is called when the thread starts.
            // Examples is provided in examples/ThreadProc.jpg
            //
            // Build the following function to create a thread.
            // var T = new Thread(ThreadProc);
            // T.Start();
            // For convenience, we can add 'new' and 'ThreadProc' as custom object and add 'Thread' and 'Start' as custom function.
            // Create a variable t and connect it with the custom function 'Thread'.
            // As we didn't provide consuructor in the command pallet, users have to insert the keyword 'new' manually.
            // Example is provided in examples/CreateThread.jpg
            var ThreadVariable, T;
            ThreadVariable = ThreadProc;
            T = new Thread(ThreadVariable);

            T.Start();
        }


        var i;

        var ThreadProc = new Action(() => {
          for (i = 0; i <= 10; i++) {
            Console.WriteLine(String.Concat("ThreadProc: {0}", i));
          }
        });



        public int MethodToTest()
        {
            return 5;
        }

    }

}
