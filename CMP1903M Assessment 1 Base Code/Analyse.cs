using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Return if charater is true else return false
        public bool isVowel(char chr)
        {
            if (chr == 'a' || chr == 'e' || chr == 'i' || chr == 'o' || chr == 'u' ||
                           chr == 'A' || chr == 'E' || chr == 'I' || chr == 'O' || chr == 'U')
                return true;
            return false;
        }

        //Check either charater is between a-z OR A-Z
        public bool isValidChar(char chr)
        {
            if ((Convert.ToInt32(chr) >= 65 && Convert.ToInt32(chr) <= 90) ||
                (Convert.ToInt32(chr) >= 91 && Convert.ToInt32(chr) <= 122))
                    return true;
            return false;
        }

        //Handles the analysis of text
        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters

            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for(int i = 0; i<5; i++)
            {
                values.Add(0);
            }
            int uppercase = 0;
            int lowercase = 0;
            int vowels = 0;
            int consonanats = 0;
            if (input != "" && input != null)
            {
                // Spliting string on the basis of '. ' it will return total lines
                string[] split_string_by_line = input.Split(". ");
                values[0] = split_string_by_line.Count();

                //Select one line at a time
                foreach (string line in split_string_by_line)
                {
                    //Getting all words inside a line
                    string[] words = line.Split(' ');

                    //Select one word at a time
                    foreach (string word in words)
                    {
                        if (word == "") continue;

                        //Select one charater inside a word at a time
                        foreach (char chr in word)
                        {
                            if (isValidChar(chr))
                            {
                                //If word is vowel then add into vowels
                                if (isVowel(chr))
                                    vowels++;
                                // if word is not vowel it must be consonant
                                else if (!isVowel(chr))
                                    consonanats++;
                                // check charater if it lies in A-Z, incease uppercase
                                if (Convert.ToInt32(chr) >= 65 && Convert.ToInt32(chr) <= 90)
                                    uppercase++;

                                //check charater if it lies in a-z, increase lowercase
                                else if (Convert.ToInt32(chr) >= 97 && Convert.ToInt32(chr) <= 122)
                                    lowercase++;
                            }
                        }
                    }
                }
                values[1] = vowels;
                values[2] = consonanats;
                values[3] = uppercase;
                values[4] = lowercase;
            }
            return values;
        }
    }
}
