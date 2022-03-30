using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1
        string text = "nothing";
        
        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {
            Console.Clear();
            Console.Write("Enter Sentence:  ");
            string s = Console.ReadLine();
            if (s != null)
                text = s;
            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {
            //Check either file exists or not
            if (File.Exists(fileName))
            {
                //getfile name
                string file = Path.GetFileName(fileName);

                //check either file is .txt or not
                if (file.Split('.')[1] == "txt")
                {
                    //read all text inside file
                    text = File.ReadAllText(fileName);
                }
                else
                    Console.WriteLine("Please Enter .txt file");
            }
            else
            {
                Console.WriteLine("File does not exist in the specified directory!");
                text = "";
            }
            return text;
        }

    }
}
