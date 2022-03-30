using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        Analyse analyse = new Analyse();
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)
        public void outputConsole(List<int> parameters)
        {
            Console.Write("Sentence:\t");
            Console.WriteLine(parameters[0]);
            Console.Write("Total Characters:\t");
            Console.WriteLine(parameters[1] + parameters[2]);
            Console.Write("Vowels:\t");
            Console.WriteLine(parameters[1]);
            Console.Write("Consonants:\t");
            Console.WriteLine(parameters[2]);
            Console.Write("Upper Case:\t");
            Console.WriteLine(parameters[3]);
            Console.Write("Lower Case:\t");
            Console.WriteLine(parameters[4]);
        }

        public void lettersFrequency(string text)
        {
            // Initialize two arrays ind_frequency_upper keeps the count of uppercase letters 
            // and ind_frequency_lower keeps lowercase count with zeros

            int[] ind_frequency_upper = new int[26];
            int[] ind_frequency_lower = new int[26];
            for (int i = 0; i < ind_frequency_upper.Length; i++)
            {
                ind_frequency_upper[i] = 0;
                ind_frequency_lower[i] = 0;
            }

            //Split will split text on the bases of '. ' and convert them into array
            string[] split_string_by_line = text.Split(". ");

            //traver each line that splited in above line
            foreach (string line in split_string_by_line)
            {
                //Split line into words
                string[] words = line.Split(' ');
                //traverse each word
                foreach (string word in words)
                {
                    //convert word into letters
                    foreach (char chr in word)
                    {
                        if (analyse.isValidChar(chr))
                        {
                            if (Convert.ToInt32(chr) >= 97 && Convert.ToInt32(chr) <= 122)
                                ind_frequency_lower[Convert.ToInt32(chr) - 97] += 1;
                            else if (Convert.ToInt32(chr) >= 65 && Convert.ToInt32(chr) <= 90)
                                ind_frequency_upper[Convert.ToInt32(chr) - 65] += 1;
                        }
                    }
                }

            }
            for (int i = 0; i < ind_frequency_upper.Length; i++)
            {
                Console.WriteLine("{0} = {1}", Convert.ToChar(i + 65), ind_frequency_upper[i]);
                Console.WriteLine("{0} = {1}", Convert.ToChar(i + 97), ind_frequency_lower[i]);
            }
        
        }
        

    }
}
