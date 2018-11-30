using System;
using System.Linq;

namespace Exercise2
{
    class Responses 
    {
        // list passed in
        Questions questions;
        public Responses()
        {
            questions = new Questions();
        }
        public void LoopQuestions()
        {// random class called
         // prompt the user for input  
            string userinput = Validation.GetStringValidation("Please input your responce: ").ToLower();
            Random rnd = new Random();
            while (questions.questionslist.Count > 0)
            {                
                // the answer
                string answer = "purse";
                // determin user input
                if (userinput == answer.ToLower() || userinput == "hand bag".ToLower() || userinput == "bag".ToLower())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Great job!\n You got the correct answer! ");
                    Console.ResetColor();
                    // if correct leave program
                    Utility.PauseBeforeContinuing();
                    Environment.Exit(0);
                }
                else
                {
                    while (userinput != answer.ToLower() || userinput != "hand bag".ToLower() || userinput != "bag".ToLower())
                    {

                        if (userinput == "wallet"|| userinput == "billfold"|| userinput == "pocketbook")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("So Close you can almost taste the victory");
                            Console.ResetColor();
                        }
                        
                        //loop through the loop and call the next Questions
                        int currentQuestion = rnd.Next(0, questions.questionslist.Count);
                        // store the item before removing it
                        Questions removed = questions.questionslist[currentQuestion];
                        // remove the question
                        questions.questionslist.RemoveAt(currentQuestion);
                        //display the question
                        Console.Write("Incorrect responce better luck next time!\n"+removed.ToString()+ ": \n" );
                         userinput = Console.ReadLine();
                        if (questions.questionslist.Count <= 0){
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("It seems that you have not been able to guess the correct answer\nTry again another time '' Good Bye!''  ");
                            Console.ResetColor();
                            Utility.PauseBeforeContinuing();
                            Environment.Exit(0);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
              
            }
        }
    }
}
