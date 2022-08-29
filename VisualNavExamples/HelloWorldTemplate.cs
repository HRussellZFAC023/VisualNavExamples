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

            Console.writeLine("hello world");

            //  We can also write a more complicated algorithm, this prints  Fizz on odd numbers and Buzz on even numbers

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
            // Choose a right position in the Main method and click the 'insert code' button.
            // The result would be like Math.random();  

            dynamic x = Math.random();
            Console.WriteLine(x);


        }


        public int MethodToTest()
        {
            return 5;
        }

    }

}
