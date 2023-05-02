using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyProject.Models
{
    internal class MyString
    {
        public string[] Split(string word, char symbol)
        {

            int count = CountOfResultArray(word, symbol);
            var res = Expression(word, symbol, count);
            return !word.Contains(symbol) ? new string[] { word } : res;
        }
        int CountOfResultArray(string word,char symbol)
        {
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == symbol) count++;
            }
            return count;
        }
        string[] Expression(string word, char symbol,int count)
        {
            string[] res = new string[count + 1];
            string sb = string.Empty;
            int index = 0;
            int counter = 0;
            foreach (var item in word)
            {

                if (symbol != item)
                {
                    sb += item;
                }
                else
                {
                    res[index] = sb;
                    sb = string.Empty;
                    index++;
                }
                counter++;
                if (counter == word.Length)
                {
                    res[index] = sb;
                }
            }
            return res;
        }
    }
}
