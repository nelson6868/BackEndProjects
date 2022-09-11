using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslatorApp
{
    class Program
    {

       

        static void Main(string[] args)
        {
            //Logic
            //We are assuming that every word has a vowel
            //We are assuming that every word has a vowel as the ist, 2nd or 3rd letter
            //step 1. find the vowel
            // step 2. follow a rule.


            Console.WriteLine("Pig Latin Translator");
            Console.WriteLine();
            Console.Write("Enter word");
          string Word=  Console.ReadLine();


            int VowelPosition = -1;
            foreach(char letter in Word)
            {
                VowelPosition = VowelPosition + 1;
                if (letter == 'a' || letter == 'e' || letter=='i' || letter == 'o' || letter == 'u')
                {
                    break;


                }

            }
            //stpe2 
            string PigLatingWord = "";
            string BeforeLetters = "";
            string AfterLetters = "";

            switch(VowelPosition)
            {
                case 0:
                    //rule 1- add "way"
                    PigLatingWord = Word + "way";
                    break;
                case 1:
                    //rule 2- Ist letter at end + "ay"
                    BeforeLetters = Word.Substring(0, 1);
                    AfterLetters = Word.Substring(1);
                    PigLatingWord = AfterLetters + BeforeLetters + "way";

                    break;
                case 2:
                    // rule 3 - 2 Consonants add to end + "ay"
                    BeforeLetters = Word.Substring(0, 2);
                    AfterLetters = AfterLetters + BeforeLetters + "ay";
                    PigLatingWord = AfterLetters + BeforeLetters + "ay";
                  break;
                default:
                    PigLatingWord = "Unable to translate";
                    break;

            }

            Console.WriteLine("Translation: " + PigLatingWord);
            Console.WriteLine();

            Console.WriteLine("-- press any key to exit --");
            Console.ReadKey();

        }
    }
}
