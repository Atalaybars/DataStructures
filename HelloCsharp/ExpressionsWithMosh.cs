using System.Collections.Generic;

namespace HelloCsharp
{
    public class ExpressionsWithMosh
    {
        private readonly List<char> _leftBrackets = new List<char> { '(', '[', '<' };
        private readonly List<char> _rightBrackets = new List<char> { ')', ']', '>' };

        public bool CheckExpression(string expression)
        {
            var chars = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (isLeftBracket(expression[i]))
                {
                    chars.Push(expression[i]);
                    continue;
                }

                if (isRightBracket(expression[i]) && chars.Count == 0)
                {
                    return false;
                }
                
                if (isRightBracket(expression[i]))
                {
                    if (BracketsMatch(expression[i], chars.Peek()))
                    {
                        chars.Pop();
                        continue;
                    }

                    return false;
                }
            }

            if (chars.Count > 0) 
                return false;

            return true;
        }

        private bool isLeftBracket(char character)
        {
            return _leftBrackets.Contains(character);
        }

        private bool isRightBracket(char character)
        {
            return _rightBrackets.Contains(character);
        }

        private bool BracketsMatch(char left, char right)
        {
            return _leftBrackets.IndexOf(left) == _rightBrackets.IndexOf(right);
        }
    }
}