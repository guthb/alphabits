﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alphabits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The challenge is to enter all the letters of the alphabet, one at a time, without repeating any, and without typing any non-letter characters.");
            Console.WriteLine("Let's begin\n");
            

            //initalize the count of letters to be used in a loop for checking the list count of 
            //correctly entered values and instaciate a new list
            int letterCount = 0;
            Letters letterList = new Letters();

            //loop through the entries until all letters are picked

            while (letterCount != 26)
            {
                int alphaTotal = 26;
                //friendly message to urge user along
                Console.WriteLine("you have entered {0} letters of the alphabet, what are you waiting for?\n", letterCount);

                string userInput = Console.ReadLine();

                char inputChar = userInput[0];
                
                //check for more than one character entered
                if (userInput.Length > 1)
                {
                    Console.Write("only enter one letter! \n");
                }

                //bonus
                if (userInput == "@")
                {

                    String inputString = letterList.returnList();
                    Console.Write("Current userList is {0} \n", inputString);
                }



                letterList.addChar(inputChar);

                letterCount = letterList.listLength();
                Console.WriteLine("you only have {0} to go", alphaTotal - letterCount);

                



            }
            
            Console.WriteLine("You are a Genius, !You typed all the letters of the alphabet!");
            Console.ReadLine();
            
        }
    }
}
