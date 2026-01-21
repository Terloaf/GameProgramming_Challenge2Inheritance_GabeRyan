using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            List<Question> _questions = new List<Question>();

            Question question1 = new Question(questionText: "Who is the guardian of the master emerald?", answerText: "Knuckles");
            Question question2 = new Question(questionText: "What was Bowsers original name?", answerText: "King Koopa");
            Question question3 = new Question(questionText: "How many robot masters are in the original Mega Man?", answerText: "6");

            MultipleChoiceQuestion question4 = new MultipleChoiceQuestion(
                questionText: "How many playable campaigns are in sonic adventure 1?",
                answerText: "6",
                answerOptions: new string[] {"3", "4", "5","6"},
                correctAnswer: 3
                );

            MultipleChoiceQuestion question5 = new MultipleChoiceQuestion(
                questionText: "how many stars are in mario 64",
                answerText: "120",
                answerOptions: new string[] { "100", "64", "120", "160" },
                correctAnswer: 2
                );

            MultipleChoiceQuestion question6 = new MultipleChoiceQuestion(
                questionText: "How many chaos emeralds are in the original Sonic The Hedgehog?",
                answerText: "6",
                answerOptions: new string[] { "5", "6", "7", "8" },
                correctAnswer: 1
                );


            TrueOrFalseQuestion question7 = new TrueOrFalseQuestion(questionText: "Is Mega Man a robot?",  answerAsBool: true);

            TrueOrFalseQuestion question8 = new TrueOrFalseQuestion(questionText: "Can you spindash in the original Sonic The Hedgehog?", answerAsBool: false);

            TrueOrFalseQuestion question9 = new TrueOrFalseQuestion(questionText: "Can you summersalt in mario 64?", answerAsBool: false);





            _questions.Add(question1);
            _questions.Add(question2);
            _questions.Add(question3);
            _questions.Add(question4);
            _questions.Add(question5);
            _questions.Add(question6);
            _questions.Add(question7);
            _questions.Add(question8);
            _questions.Add(question9);

            Console.WriteLine("Classic Video Game Quiz");

            for(int i = 0; i < _questions.Count; i++)
            {
                _questions[i].Ask();
                _questions[i].CheckAnswer();
            }





        }



        class Question
        {
            protected string _questionText;
            protected string _answerText;


            public Question(string questionText, string answerText)
            {
                _questionText = questionText;
                _answerText = answerText;
            }

            public void Ask()
            {
                Console.WriteLine($"{_questionText}");
            }
            public virtual bool CheckAnswer()
            {
                if(Console.ReadLine() == _answerText)
                {
                    
                    Console.WriteLine("Correct");
                    return true;
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    return false;
                }
            }
        }



        class MultipleChoiceQuestion : Question
        {

            private string[] _answerOptions;
            private int _correctAnswer;
            public MultipleChoiceQuestion(string questionText, string answerText, string[] answerOptions, int correctAnswer) : base(questionText, answerText)
            {
                _questionText = questionText;

                _correctAnswer = correctAnswer;

                _answerOptions = answerOptions;

                
            }

            public override bool CheckAnswer()
            {

                Console.WriteLine("Press the correct key");

                for(int i = 0; i < _answerOptions.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {_answerOptions[i]}");   
                }

                ConsoleKeyInfo input = Console.ReadKey();
                

                char inputAsChar = input.KeyChar;

                string inputAsString = inputAsChar.ToString();

                if(int.Parse(inputAsString) - 1 == _correctAnswer)
                {
                    Console.ReadKey();
                    Console.WriteLine("Correct");
                    return true;
                }
                else if(input !=)
                else
                {
                    Console.WriteLine("Incorrect");
                    return false;
                }
                
                
            }
        }



        class TrueOrFalseQuestion : Question
        {

            

            public TrueOrFalseQuestion(string questionText, bool answerAsBool) : base(questionText, answerAsBool.ToString())
            {
                _questionText = questionText;

                _answerText = answerAsBool.ToString();
            }

            public override bool CheckAnswer()
            {
                return base.CheckAnswer();
            }
        }





    }
}
