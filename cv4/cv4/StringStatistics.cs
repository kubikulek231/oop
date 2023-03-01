using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cv4
{
    internal class StringStatistics
    {
        private string input_string { get; set; }

        public StringStatistics(string input)
        {
            this.input_string = input;
        }

        public int getWordCount()
        {
            char[] slicers = { ',', ' ', '.', '?', '.', '!', '\n' };
            string[] words = input_string.Split(slicers, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            return words.Length;
        }
        public int getRowCount()
        {
            int count = 0;
            foreach (char c in this.input_string)
            {
                if (c == '\n')
                {
                    count++;
                }
            }
            return count;
        }
        public int getSentenceCount()
        {
            int count = -1;
            bool upperCase = false;
            foreach (char c in input_string)
            {
                if (char.IsUpper(c) && (char.IsLetter(c)))
                {
                    upperCase = true;
                }
                if (upperCase && (c == '.' || c == '?' || c == '!')) {
                    count++;
                }
            }
            return count;
        }
        public StringBuilder getWordLongest()
        {
            string longest_word = "";
            StringBuilder longest_words = new StringBuilder{};

            char[] slicers = { ',', ' ', '.', '?', '.', '!', '\n' };
            string[] words = input_string.Split(slicers, StringSplitOptions.RemoveEmptyEntries);
            
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > longest_word.Length)
                {
                    longest_word = words[i];
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == longest_word.Length)
                {
                    longest_words.AppendLine(words[i]);
                }
            }
            return longest_words;
        }
        public StringBuilder getWordShortest()
        {
            char[] slicers = { ',', ' ', '.', '?', '.', '!', '\n' };
            string[] words = input_string.Split(slicers, StringSplitOptions.RemoveEmptyEntries);
            string shortest_word = words[0];
            StringBuilder shortest_words = new StringBuilder { };

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length < shortest_word.Length)
                {
                    shortest_word = words[i];
                }
            }
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == shortest_word.Length)
                {
                    shortest_words.AppendLine(words[i]);
                }
            }
            return shortest_words;
        }
    

        public string getWordMostOccuring()
        {
            char[] slicers = { ',', ' ', '.', '?', '.', '!', '\n' };
            string[] words = input_string.Split(slicers, StringSplitOptions.RemoveEmptyEntries);
            int[] occurances = new int[words.Length];
            for (int i = 0; i < occurances.Length; i++)
            {
                for (int j = 0; i < occurances.Length; i++)
                {
                    if (words[i] == words[j])
                    {
                        occurances[i]++;
                    }
                }
            }
            int biggest = 0;
            int biggest_index = 0;
            for (int i = 0; i < occurances.Length; i++)
            {
                if (occurances[i] > biggest)
                {
                    biggest = occurances[i];
                    biggest_index = i;
                }

            }

            return words[biggest_index];
        }
        public string[] getWordSort()
        {
            char[] slicers = { ',', ' ', '.', '?', '.', '!', '\n' };
            string[] words = input_string.Split(slicers, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Replace(")", string.Empty);
                words[i] = words[i].Replace("(", string.Empty);
            }
            Array.Sort<string>(words);
            return words;
        }
    }
}
