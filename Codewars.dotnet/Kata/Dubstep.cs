using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Kata
{
    // https://www.codewars.com/kata/551dc350bf4e526099000ae5/train/csharp
    public class Dubstep
    {
        public static string SongDecoder(string input)
        {
            // var splited = input.Split("WUB");
            // var sb= new StringBuilder();
            // foreach (var str in splited)
            // {
            //     if (!string.IsNullOrEmpty(str))
            //     {
            //         sb.Append(str);
            //         sb.Append(" ");
            //     }
            // }
            //
            // return sb.ToString().Trim();
            
            return Regex.Replace(input, "(WUB)+", " " ).Trim();
        }
    }
}