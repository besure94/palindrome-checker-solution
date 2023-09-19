using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker.Models;

namespace PalindromeChecker.Tests
{
  [TestClass]
  public class UserInputTests
  {

    [TestMethod]
    public void UserInputConstructor_CreatesInstanceOfUserInput_UserInput()
    {
      UserInput newUserInput = new UserInput("kayak");
      Assert.AreEqual(typeof(UserInput), newUserInput.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsWord_String()
    {
      string userWord = "kayak";
      UserInput newUserInput = new UserInput(userWord);
      string result = newUserInput.Word;
      Assert.AreEqual(userWord, result);
    }

    [TestMethod]
    public void SetWord_SetsValueOfWord_Void()
    {
      UserInput newUserInput = new UserInput("kayak");
      string newWord = "civic";
      newUserInput.Word = newWord;
      Assert.AreEqual(newWord, newUserInput.Word);
    }

    [TestMethod]
    public void ReverseWord_ReversesWordInUserInput_String()
    {
      UserInput inputtedWord = new UserInput("armadillo");
      string reversedWord = inputtedWord.ReverseWord();
      Assert.AreEqual("ollidamra", reversedWord);
    }
  }
}