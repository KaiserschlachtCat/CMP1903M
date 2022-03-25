//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            // Gets the text from manual and file. This is used for the Report so it can directly send it across.
            string text;
            string longwords;

            // Choosing the input type
            string input_type;

            //Local list of integers to hold the first five measurements of the text
            // This will be used to hold the the variables you have set in the Analyse Class!
            List<int> parameters = new List<int>();

            //Create Input object.
            //Get Manual Text and File Text Input | Change these within the input class and not main PROGRAM!
            Input input = new Input(); // Once created assign to a variable and send it to the Report Construct.

            //Create an Analyse object
            //Pass the text input to the 'analyseText' method and retrieve the text through getManualText method.
            Analyse analyse = new Analyse();

            while (true)
            {
                // User Input
                Console.WriteLine("Enter user input type: 'y' = Manual | 'n' = File");
                input_type = Console.ReadLine();
                if (string.IsNullOrEmpty(input_type)) // If the string is empty raise this.
                {
                    Console.WriteLine("The input type you've inputed is empty. ");
                }
                else if (input_type == "y")
                {
                    // FOR MANUAL
                    parameters = analyse.analyseText(input.manualTextInput());
                    text = input.getText();
                    longwords = analyse.LongWords(text);

                    //Report the results of the analysis
                    Report report = new Report(text, parameters, longwords);
                    report.OutputConsole();
                    break;
                }
                else if (input_type == "n")
                {
                    // FOR FILE
                    parameters = analyse.analyseText(input.fileTextInput(""));
                    text = input.getText();
                    longwords = analyse.LongWords(text);

                    //Report the results of the analysis
                    Report report = new Report(text, parameters, longwords);
                    report.OutputConsole();
                    break;
                }
                else // If the string you've entered is wrong it will tell to choose a new option.
                {
                    Console.WriteLine("Choose a valid option.");
                    continue;
                }


            }

        }
        
    }
}
