using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VisualNavExamples;

namespace UnitTestExamples
{
    [TestClass]
    public class UnitTestExample
    {
        // Welcome to the Hello World with FizzBuzz template
        // Get started, make sure VisualNav for Visual Studio is installed: LINK
        // Optionally, make sure motion input is installed LINK

        // Use unit test function
        // 
        // Navigate the Command Pallet (radial menu), by selecting Test -> Assert. 
        // You will see several blocks that can be used in the unit test project.
        // Use AreEqual() as an example. Click this command and create it in the building window.
        //
        // Input the variable for this block:
        // expected variable should be a number, you can choose a block under Code -> Math directory
        // actual variable should be a number, you can choose a block under Code -> Math directory
        // delta variable (optional) should be a number, you can choose a block under Code -> Math directory
        // message variable (optional) should be a text, you can choose a block under Code -> Text directory
        //
        // Choose a right position in the TestMethod1 and click the 'insert code' button.
        // The result would be like Assert.AreEqual(0, 0, 0, "");




        [TestMethod]
        public void MethodToTestReturns5()
        {
            Assert.AreEqual(VisualNavExamples.HelloWorldTemplate.MethodToTest(), 5);
        }
    }
}
