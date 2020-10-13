using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encourage
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int rIntro = rnd.Next(intros.Count);
            string intro = intros[rIntro];
            int rNotes = rnd.Next(notes.Count);
            string note = notes[rNotes];

			string person = "Hey you";
			if(args.Length == 1) 
			{
				person = args[0].ToString();
			}
				
            string outputText = string.Format("{0}{1} {2}", person, intro, note);
            System.Console.WriteLine(outputText);
        }

        static List<string> intros = new List<string>{
            ", I just want you to know...",
            ", I want you to remember...",
            ", don't ever forget...",
            ", no matter what anyone else says..."
        };

        static List<string> notes = new List<string>{
            "I know you can do it. Don't give up.",
            "You are __so__ special!",
            "You are amazing!",
            "I am so proud of you 😊",
            "God has very special plans for your life!",
            "You are strong 💪",
            "I'm so glad I get to be your Dad!",
            "Don't believe the lies the world keeps throwing at you.",
            "You are smart 🧠",
            "You are brave! 👊",
            "You are uniquely gifted to do incredible things!",
            "Always look for the sacred in the ordinary things.",
            "Treat others with kindness ❤️",
            "There is always something you can be grateful for.",
            "You can change lives by serving others.",
            "You are loved ❤️",
            "You can sing 🎶",
            "You can be someone others can always trust.",
            "Focus on staying pure of heart ❤️",
            "Don't forget to pray 🙏",
            "It's okay to ask for help.",
            "No matter what happens, I will will always love you.",
            "I am so blessed you are my son.",
            "Your mistakes do not make you a failure. Learn and grow.",
            "Do good for those around you.",
            "Be patient with yourself.",
            "Forgive others, and be sure to forgive yourself.",
            "Happiness will come and go, but you can always have hope and joy.",
            "I need you. Your family needs you. Your friends need you. The world needs you.",
            "Amazing things are yet to come!",
            "You are not responsible for the actions of others.",
            "Keep a good attitude!"
        };
}
}
