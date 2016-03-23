using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bProblems
{
    class wordChecker
    {
        // Write a program that barks at the user every time they enter in the same input twice. You must use a while loop to continually ask the user for input, and you must use a for loop to iterate through the list of user inputs 

        public List<string> wordList = new List<string>();

        public string resultWord;

        public wordChecker ()
        {
            wordList.Add("  ");
        }

        public void getWord ()
        {
           
            Console.WriteLine("Please enter a Word!");
            resultWord = Console.ReadLine();
            
            wordList.Add(resultWord);
        }

          public void Checker ()
          {

            for (int word = 0; word < wordList.Count; word++)

                if (wordList[word].Contains(resultWord))
                {

                    Console.WriteLine("Bark!");
                    getWord();

                }
                else
                {
                    Console.WriteLine("Good,continue");

                    wordList.Add(resultWord);
                    getWord();

                }

            }       

              }
          
    }


