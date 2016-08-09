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


        //define a new Letter Constructor 
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
            string charToSave = enteredValue.ToString();

            //check for non-letters and provide a messaage
            if (!char.IsLetter(enteredValue))
            {
                Console.WriteLine("'{0}' is not a letter, please choose again", enteredValue);
                return;
            }

            
            //check the list against what was entered


            //update list of letters


        }

        //build a contstructor function for listLength
        //return the length of the priavte list 
        public int listLength()
        {
            return enteredList.Count();
        }





    }
}
