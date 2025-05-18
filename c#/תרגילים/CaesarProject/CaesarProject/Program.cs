using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CaesarProject
{
    class Caesar
    {
        public char MoveLetter(char l , int steps)
        {
             int byse = 65;
             if (char.IsLower(l)) { byse = 97; }
             else if (!char.IsLetter(l)) { return l; }
               
            return (char)((((int)l + steps - byse) % 26) + byse);
        }

        public string MoveWord(string word , int steps)
        {
            return string.Join("", word.Select(x => MoveLetter(x, steps)).ToArray());
        }

        public string[] MoveSentes(string[] words , int steps)
        {

            return words.Select(x => MoveWord(x, steps)).ToArray();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Caesar caesar = new Caesar();

            string[] aaa = "kyvul dpss msf avdhykz aol uvyao ihzl. haahjr pz lewljalk dpaopu 15 tpubalz".Split(' ');
            for (int i = 0; i < 26; i++) 
            {
                string[] str = caesar.MoveSentes(aaa, i);
                foreach(string w in str) { Console.Write(w +" "); }
                Console.WriteLine(" ");
            
            }
        }
    }
}
