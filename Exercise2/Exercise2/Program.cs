using System;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            // the story
                    Console.WriteLine("----------------------------------------------------------------------\n"+
                                        "In this program you will have upto 10 "+
                                        "attemps to get the correct answer.\n"+
                                 "The topic is fashon and the item is an accessory.\n"+
                                  "Make your best attempt to get the correct answer\n"+
                                  "Hint:****This is a must have item for girl and women.***");
            System.Console.WriteLine("\n");
            Console.ResetColor();
            Responses responses = new Responses();
            responses.LoopQuestions();
        }
    }
}
