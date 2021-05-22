using System;
using System.Collections.Generic;

namespace HelloCsharp
{
    public class Challenges
    {
        public static void Reverse(Queue<int> queue)
        {
            var stack = new Stack<int>();
            
            for (int i = 0; i < queue.Count; i++)
            {
                stack.Push(queue.Dequeue());
            }

            for (int i = 0; i < stack.Count; i++)
            {
                queue.Enqueue(stack.Pop());   
            }
        }

        public static char FindFirstNonRepeatedCharacter(string stringo)
        {
            var dictionary = new Dictionary<char, int>();

            for (int i = 0; i < stringo.Length; i++)
            {
                if (dictionary.ContainsKey(stringo[i]))
                {
                    dictionary[stringo[i]]++;
                    continue;
                }
                
                dictionary.Add(stringo[i], 1);
            }

            for (int i = 0; i < stringo.Length; i++)
            {
                if (dictionary[stringo[i]] == 1)
                {
                    return stringo[i];
                }
            }

            return char.MinValue;
        }

        public static char FindFirstRepeatedCharacter(string stringo)
        {
            var set = new HashSet<char>();

            for (int i = 0; i < stringo.Length; i++)
            {
                if (set.Contains(stringo[i]))
                    return stringo[i];

                set.Add(stringo[i]);
            }

            return char.MinValue;
        }
        // naming can be improved
        public static int FindTheDifference(int[] a, int[] b)
        {
            int result1 = 1;
            int result2 = 1;

            foreach (int item in a)
            {
                result1 *= item;
            }

            foreach (int item in b)
            {
                result2 *= item; 
            }

            return Math.Abs(result1 - result2);
        }

        public static string NameShuffler(string str)
        {
            string[] arr = str.Split(" ");
            System.Array.Reverse(arr);
            return string.Join(" ", arr);
        }
        
        /*
        public static IEnumerable<int> PaintLetterBoxes(int start, int end)
        {
            List<int> numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            // under construction...
        }
        */ 
    }
}