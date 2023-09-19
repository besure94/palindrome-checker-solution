namespace PalindromeChecker.Models
{
  public class Palindrome
  {
    private string _word;
    public string Word
    {
      get { return _word; }
      set { _word = value; }
    }

    public Palindrome(string userWord)
    {
      _word = userWord;
    }
  }
}