using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            Console.WriteLine("My name is " + this.Name);
            Console.WriteLine("My ears are " + this.EarSize + " inches tall.");
        }
        public void HearMessage(string message, Elephant whoSaidit)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidit.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);
        }
    }
}
