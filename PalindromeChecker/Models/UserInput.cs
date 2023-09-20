using System;

namespace PalindromeChecker.Models
{
  public class UserInput
  {
    private string _word;
    public string Word
    {
      get { return _word; }
      set { _word = value; }
    }

    public UserInput(string userWord)
    {
      _word = userWord.ToLower();
    }

    public bool IsPalindrome()
    {
      char[] userStringArray = Word.ToCharArray();
      Array.Reverse(userStringArray);
      string reversedString = new string(userStringArray);
      int length = reversedString.Length;
      for (int i = 0; i < length / 2; i++)
      {
        if (reversedString[i] != reversedString[length - 1 - i])
        {
          return false;
        }
        else if (reversedString.Contains(' '))
        {
          return true;
        }
      }
      return true;
    }
  }
}