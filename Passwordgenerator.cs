using System.Collections.Generic;

namespace passBreak.Services
{
    public static class PasswordGenerator
    {
        public static IEnumerable<string> GeneratePasswords(char[] charset, int maxPasswordLength)
        {
            var stack = new Stack<string>();
            stack.Push(string.Empty);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (current.Length <= maxPasswordLength)
                {
                    yield return current;

                    if (current.Length < maxPasswordLength)
                    {
                        foreach (var ch in charset)
                        {
                            var next = current + ch;
                            stack.Push(next);
                        }
                    }
                }
            }
        }
    }
}