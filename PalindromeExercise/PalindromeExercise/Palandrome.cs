using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PalindromeExercise
{
    public class Palandrome
    {
        public string Reverse(string word)
        {
            word.ToLower();
            char[] chars = word.ToCharArray();            
            Array.Reverse(chars);
            return new string(chars);
        }
        public bool Check(string word)
        {
            if (word.ToLower() == Reverse(word).ToLower())
            {
                return true;
            }
            else
            {                 
                return false;
            }
        }
    }
}
