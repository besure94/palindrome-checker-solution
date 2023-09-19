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
      _word = userWord;
    }

    public string ReverseWord()
    {
      char[] userStringArray = Word.ToCharArray();
      Array.Reverse(userStringArray);
      string reversedString = new string(userStringArray);
      return reversedString;
    }
  }
}