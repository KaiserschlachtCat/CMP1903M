using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        List<int> values = new List<int>();
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //Initialise all the values in the list to '0'
            for(int i = 0; i<7; i++)
            {
                values.Add(0);
            }
            int c, len;

            // Gets the input of the text.
            len = input.Length;

            for (c = 0; c < len; c++)
            {
                //1. Number of sentences
                if (input[c] == '.')
                {
                    values[0]++;
                }

                //2. Number of vowels
                if (input[c] == 'a' || input[c] == 'e' ||
                    input[c] == 'i' || input[c] == 'o' ||
                    input[c] == 'u' || input[c] == 'A' ||
                    input[c] == 'E' || input[c] == 'I' ||
                    input[c] == 'O' || input[c] == 'U')
                {
                    values[1]++;
                }
                //3. Number of consonants
                else if ((input[c] >= 'a' && input[c] <= 'z') || 
                         (input[c] >= 'A' && input[c] <= 'Z'))
                {
                    values[2]++;
                }
                //4. Number of upper case letters
                if (char.IsUpper(input[c]))
                {
                    values[3]++;
                    // Max Characters
                    values[5]++;
                }
                //5. Number of lower case letters
                if (char.IsLower(input[c]))
                {
                    values[4]++;
                    // Max Characters
                    values[5]++;
                }
                //6. Special Characters
                if (input[c] == '!' || input[c] == '"' || input[c] == '£' || input[c] == '%' || input[c] == '*' ||
                    input[c] == ',' || input[c] == '#' || input[c] == ':' || input[c] == ';' || input[c] == '/' ||
                    input[c] == '-' || input[c] == '+' )
                {
                    values[6]++;
                }
            }
            return values;
        }
        public List<int> GetList()
        {
            return values;
        }

        //Method: LongWords
        //Arguments: string
        //Returns: list of strings
        //It looks for words longer than 5 characters and then adds it to a string.
        public string LongWords(string longwords)
        {
            string line = longwords;
            string[] words = line.Split(new[] { ' ' }, StringSplitOptions.None);
            string longword = "";
            int longwordLimit = 5;
            foreach (String c in words)
            {
                if (c.Length > longwordLimit)
                {
                    longword += "," + c;
                    longwordLimit = c.Length;
                    continue;
                }
            }
            return longword;
        }
    }
}
