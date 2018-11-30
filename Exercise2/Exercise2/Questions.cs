using System.Collections.Generic;

namespace Exercise2
{
    class Questions
    {
        // make a list of  10 questions
        public string clue { get; set; }
        internal List<Questions> questionslist;
        internal Questions(string _clues)
        {
            this.clue = _clues;
        }
        public Questions()
        {
            questionslist= new List<Questions>()
        {
                 new Questions("I keep everything you own safe"),
                 new Questions("I get tossed down a lot and sometimes i get loss"),
                 new Questions("You love to show me off to your friends"),
                 new Questions("I am the first thing you take not matter where you go"),
                 new Questions("If you lost me you would come find me "),
                 new Questions("you carry my weight on your sholders day to day"),
                 new Questions("If i get dirty you would wipe me before you washed me"),
                 new Questions("I attract bad guys when your with me in public"),
                 new Questions("You usually change me depending on your outfit"),
                 new Questions("I don't know why this is so hard for you i'm probably next to you")
            };
        }       
        public override string ToString()
        {
            return string.Format($"{this.clue}");
        }
    }
}
