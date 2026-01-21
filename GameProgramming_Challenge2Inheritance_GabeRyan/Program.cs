using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace GameProgramming_Challenge2Inheritance_GabeRyan
{
    internal class Program
    {
        static void Main(string[] args)
        {




        }



        class Question
        {
            protected string _questionText;
            protected string _answerText;


            public Question (string questionText, string answerText)
            {

            }

            public void Ask()
            {
                Console.WriteLine($"{_questionText}");
            }
            public bool CheckAnswer()
            {
                if(_questionText == _answerText)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



        class MultipleChoiceQuestion : Question
        {

        }



        class TrueOrFalseQuestion : Question
        {

        }





    }
}
