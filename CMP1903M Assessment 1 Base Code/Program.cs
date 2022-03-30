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
            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();
            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Input input = new Input();
            int choice = 0;
            string text = "";

            //Menu
            while (choice != 3)
            {
                Console.WriteLine("1.   Do you want to enter the text via the keyboard?");
                Console.WriteLine("2.   Do you want to read in the text from a file?");
                Console.WriteLine("3.   Exit");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                    // Get Text From File
                    if (choice == 2)
                    {
                        Console.Write("Enter Filepath: ");
                        text = input.fileTextInput(Console.ReadLine());
                        break;
                    }

                    //Get Text From Keyboard
                    else if (choice == 1)
                    {
                        text = input.manualTextInput();
                        break;
                    }
                    else if (choice == 3)
                        break;
                    else
                        Console.WriteLine("Please make valid choice\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyse = new Analyse();
            //Receive a list of integers back
            parameters = analyse.analyseText(text);

            //Report the results of the analysis
            Report report = new Report();
            report.outputConsole(parameters);


            //TO ADD: Get the frequency of individual letters?
            report.lettersFrequency(text);
        }
    
    }
}
