using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Operation
{
    public class StringHelper
    {

        public static string DeleteUnnecessarySpaces(string phrase)
        {
            string newPhrase = string.Empty;
            phrase = phrase.Trim();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] == ' ' && phrase[i + 1] == ' ')
                    continue;
                newPhrase  += phrase[i];
            }

            return newPhrase;
        }
    }
}
