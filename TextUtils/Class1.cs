using System;

namespace TextUtilsLibrary
{
    public static class TextUtils
    {
        public static bool IsPalindrome(this string str)
        {
            str = str.ToLower();
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (!char.IsLetterOrDigit(str[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(str[right]))
                {
                    right--;
                    continue;
                }

                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }

        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int SentenceCount(this string str)
        {
            return str.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int CharacterCount(this string str)
        {
            return str.Length;
        }
    }
}