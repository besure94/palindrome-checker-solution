using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker.Models;

namespace PalindromeChecker.Tests
{
  [TestClass]
  public class PalindromeTests
  {

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfPalindrome_Palindrome()
    {
      Palindrome newPalindrome = new Palindrome("kayak");
      Assert.AreEqual(typeof(Palindrome), newPalindrome.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string userWord = "kayak";
      Palindrome newPalindrome = new Palindrome(userWord);
      string result = newPalindrome.Word;
      Assert.AreEqual(userWord, result);
    }
  }
}