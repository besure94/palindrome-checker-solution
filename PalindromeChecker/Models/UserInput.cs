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
  }
}