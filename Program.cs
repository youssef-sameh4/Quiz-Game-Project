using System.Drawing;

namespace QuizGameProject
{
    internal class Program
    {
        static void PrintTitle(string litter)
        {
            Console.WriteLine("________________________________________");
            Console.WriteLine(litter);
            Console.WriteLine("_________________________________________");

        }
        static void EasyQuestionLevel()
        {
            PrintTitle("[ Easy Question Level ]");

            short CorrectAnswer = 0;

            string Answer = "";
            string[] ArrEasyQ = { "What is the capital of Egypt ?",
                "How many days are in a week ?",
                "What color is the sky on a clear day ?",
                "How many letters are in the English alphabet ?" };

            string[,] ArrChoices = {
        { "a) Cairo", "b) Alexandria", "c) Giza", "d) Luxor" },
        { "a) Five", "b) Six", "c) Seven", "d) Eight" },
        { "a) Blue", "b) Green", "c) Red", "d) Yellow" },
        { "a) 24", "b) 25", "c) 26", "d) 27" }
    };

            string[] ArrAnswerEasy = { "a", "c", "a", "c" };
            for(int i=0;i<ArrEasyQ.Length;i++)
            {
                Console.WriteLine("Q" + (i + 1) + ": " + ArrEasyQ[i]);
                Console.WriteLine("********************************");
                for (int j=0;j<4;j++)
                {
                    Console.WriteLine(ArrChoices[i, j]);
                }
                Console.Write("Your Answer (a/b/c/d)? ");
                Answer = Console.ReadLine();
                if ( ArrAnswerEasy[i].ToUpper() == Answer.ToUpper())
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;   
                    Console.ForegroundColor = ConsoleColor.Black; 
                    Console.WriteLine("\nCorrect Answer :-)\n");
                    Console.ResetColor();
                    CorrectAnswer++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nSorry, Incorrect Answer, the Correct Answer Is [" + ArrAnswerEasy[i] + "]\n");
                    Console.ResetColor();
                }
            }
            if (CorrectAnswer == 4)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("##############################");
                Console.WriteLine("   🎉 Excellent! You Won! 🎉  ");
                Console.WriteLine("   Your Score: [" + CorrectAnswer + " of " + ArrEasyQ.Length + "]");
                Console.WriteLine("##############################");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.WriteLine("   ❌ Game Over, Try Again ❌  ");
                Console.WriteLine("   Your Score: [" + CorrectAnswer + " of " + ArrEasyQ.Length + "]");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.ResetColor();

            }
        }
        static void MediumQuestionLevel()
        {
            PrintTitle("[ Medium Question Level ]");

            short CorrectAnswer = 0;
            string Answer = "";
            string[] ArrMidQ = { "Who developed the theory of relativity ? ",
                "Which planet is known as the Red Planet ? ",
                "What is the largest ocean on Earth ? ", 
                "Which gas do humans need to breathe in order to live ? " };
            string[,] ArrChoices = {
    { "a) Isaac Newton", "b) Albert Einstein", "c) Nikola Tesla", "d) Galileo Galilei" },
    { "a) Venus", "b) Mars", "c) Jupiter", "d) Mercury" },
    { "a) Atlantic Ocean", "b) Indian Ocean", "c) Arctic Ocean", "d) Pacific Ocean" },
    { "a) Carbon dioxide", "b) Oxygen", "c) Nitrogen", "d) Hydrogen" }
};
            string[] AnswerQ = {"b","b","d","b" };
            for (int i = 0; i < ArrMidQ.Length; i++)
            {
                Console.WriteLine("Q" + (i + 1) + ": " + ArrMidQ[i]);
                Console.WriteLine("********************************");
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(ArrChoices[i, j]);
                }
                Console.Write("Your Answer (a/b/c/d)? ");
                Answer = Console.ReadLine();
                if (AnswerQ[i].ToUpper() == Answer.ToUpper())
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;   
                    Console.ForegroundColor = ConsoleColor.Black; 
                    Console.WriteLine("\n Correct Answer :-)\n");
                    Console.ResetColor();
                    CorrectAnswer++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nSorry, Incorrect Answer, the Correct Answer Is [" + AnswerQ[i] + "]\n");
                    Console.ResetColor();
                }
            }
            if (CorrectAnswer == 4)
            {
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("##############################");
                Console.WriteLine("   🎉 Excellent! You Won! 🎉  ");
                Console.WriteLine("   Your Score: [" + CorrectAnswer + " of " + ArrMidQ.Length + "]");
                Console.WriteLine("##############################");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.WriteLine("   ❌ Game Over, Try Again ❌  ");
                Console.WriteLine("   Your Score: [" + CorrectAnswer + " of " + ArrMidQ.Length + "]");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.ResetColor();

            }
        }
        static void HardQuestionLevel()
        {
            PrintTitle("[ Hard Question Level ]");

            short CorrectAnswer = 0;
            string Answer = "";
            string[] ArrHardQ = { "What is the chemical symbol for Gold ? ",
                "In which year did World War II end ?" ,
                "Who is the author of “The Divine Comedy ? ", 
                "Which element has the highest electrical conductivity ? " };
            string[,] ArrChoices = {
    { "a) Ag", "b) Au", "c) Go", "d) Gd" },
    { "a) 1939", "b) 1942", "c) 1945", "d) 1950" },
    { "a) William Shakespeare", "b) Dante Alighieri", "c) Homer", "d) Charles Dickens" },
    { "a) Gold", "b) Silver", "c) Copper", "d) Aluminum" } };
            string[] AnswerQ = { "b", "c", "b", "b" };
            for(int i=0;i<ArrHardQ.Length;i++)
            {
                Console.WriteLine("Q" + (i + 1) + ": " + ArrHardQ[i]);
                Console.WriteLine("********************************");
                for (int j=0;j<4;j++)
                {
                    Console.WriteLine(ArrChoices[i, j]);
                }
                Console.Write("Your Answer (a/b/c/d)? ");
                Answer = Console.ReadLine();
                if (AnswerQ[i].ToUpper() == Answer.ToUpper())
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;  
                    Console.ForegroundColor = ConsoleColor.Black;  
                    Console.WriteLine("\n✅ Correct Answer :-)\n");
                    Console.ResetColor();
                    CorrectAnswer++;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;   
                    Console.ForegroundColor = ConsoleColor.White; 
                    Console.WriteLine("\nSorry, Incorrect Answer, the Correct Answer Is [" + AnswerQ[i] + "]\n");
                    Console.ResetColor(); 

                }
            }
            if (CorrectAnswer == 4)
            {
                Console.WriteLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("##############################");
                Console.WriteLine("   🎉 Excellent! You Won! 🎉  ");
                Console.WriteLine("   Your Score: [" + CorrectAnswer + " of " + ArrHardQ.Length + "]");
                Console.WriteLine("##############################");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.WriteLine("   ❌ Game Over, Try Again ❌  ");
                Console.WriteLine("   Your Score: [" + CorrectAnswer + " of " + ArrHardQ.Length + "]");
                Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
                Console.ResetColor();

            }
        }
        static void MainMenu()
        {

            short Choices;
            while (true) {
                Console.Clear();
                PrintTitle("[ Welcom To Quiz Game ]");
            Console.WriteLine("[1] Easy.");
            Console.WriteLine("[2] Miedium.");
            Console.WriteLine("[3] Hard.");
            Console.WriteLine("[4] Exit.");
            Console.Write("Please enter the question level number ? ");
                Choices = short.Parse(Console.ReadLine());
            switch (Choices)
            {
                case 1:
                    Console.Clear();
                    EasyQuestionLevel();
                    break;
                case 2:
                    Console.Clear();
                    MediumQuestionLevel();
                    break;
                case 3:
                    Console.Clear();
                    HardQuestionLevel();
                    break;
                case 4:
                        Console.Clear();
                        Console.WriteLine("Game End!.");
                    break;
            }
                    Console.WriteLine("\nPress any key to return to menu...");
                    Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            MainMenu();
        }
    }
}
