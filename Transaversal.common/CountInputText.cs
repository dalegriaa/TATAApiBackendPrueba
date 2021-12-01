using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Transaversal.common
{
    public static class CountInputText
    {
        public static Array GetNumberTimesRepeatInputText(string inputText)
        {
                  
           var prhase = Regex.Replace(inputText.ToLower(), @"[^\w\.@-]", " ",  RegexOptions.None, TimeSpan.FromSeconds(1.5));
           var listrepetidos = from word in prhase.Split(' ').Cast<string>()
                                group word by word into g
                                select new { Word = g.Key, Count = g.Count() };
            return listrepetidos.ToArray();
        }
    }
}
