using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        // Variables
        string longwords;
        string text;
        List<int> parameters;

        // Makes a new file
        StreamWriter sw = new StreamWriter("longwords.txt");

        public Report(string Text, List<int> Parameters, string Longwords)
        {
            // Text is what you inputed in manual text
            text = Text;
            longwords = Longwords;

            // Parameters is the list of results from analyse
            parameters = Parameters;
            
        }

        public void OutputConsole()
        {
            // What they've inputed should be displayed. Also, what characters are.
            Console.WriteLine(".................................................");

            Console.WriteLine("This is the text that you've inputed/got: \n" + text);

            // The analysis should be reported. So, the numbers of sentences, etc.
            List<string> report = new List<string>() { 
                "Sentences: " + parameters[0] , 
                "Vowels: " + parameters[1], 
                "Consonants: " + parameters[2], 
                "Upper Case Letters: " + parameters[3], 
                "Lower Case Letters: " + parameters[4],
                "Max Letters: " + parameters[5],
                "Special Characters: " + parameters[6] };

            // The print
            Console.WriteLine("- The Report - ");
            foreach (string reports in report)
            {
                Console.WriteLine(reports);
            }

            // Generating a file for long words
            Console.WriteLine("\nFile created. It's called 'longwords'.\nYou'll find the file located in: CMP1903M Assessment 1 Base Code / bin / Debug / net6.0.");

            sw.WriteLine("Long words file: \n" + longwords);
            sw.Flush();
        }
    }
}
    