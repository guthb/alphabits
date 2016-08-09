using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Letters
    {

        //build a list for characters entered
        //this will capture from the char's entered for interrigation
        public List<char> enteredList = new List<char>();


        //define a new Letter Constructor for list of letters
        public Letters()
        {
            List<char> enteredList = new List<char>();
        }
        
        //build a contsructor function addChar
        // handle different cases of char entered upper and lower
        // handle mutiple entries of the same char
        // handle id char is not part of the alphabet sequence
        public void addChar(char enteredValue)
        {

            //handle all chars entered as lowercase
            enteredValue = char.ToLower(enteredValue);
            //to check for more than one letter entered
            string charToSave = enteredValue.ToString();

            //check for non-letters and provide a messaage
            if (!char.IsLetter(enteredValue))
            {
                Console.WriteLine("'{0}' is not a letter, please choose again", enteredValue);
                return;
            }
            
            

            //check if letter already added

            if (enteredList.Contains(enteredValue))
            {
                Console.WriteLine(" {0}, has already been added.... try again", charToSave);
                return;
            }

            //update list of letters

            enteredList.Add(enteredValue);

        }

        //build a contstructor function for listLength
        //return the length of the priavte list 
        public int listLength()
        {
            return enteredList.Count();
        }





    }
}
