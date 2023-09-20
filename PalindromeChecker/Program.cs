using System;
using PalindromeChecker.Models;

namespace PalindromeChecker
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Hello!");
      Console.WriteLine("A palindrome is any word, number, or string of words that reads the same both backwards or forwards.");
      Console.WriteLine("Would you like to check if a word, number, or string of words is a palindrome?");
      Console.WriteLine("Please enter a word, number, or a string of words.");
      string userInput = Console.ReadLine();
      string userInfo = userInput;
      UserInput user = new UserInput(userInfo);
      ConfirmOrEditUserInput(user);
    }

    static void ConfirmOrEditUserInput(UserInput user)
    {
      Console.WriteLine("Please confirm that you have inputted your information correctly:");
      Console.WriteLine($"{user.Word}");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter your information.");
      string userDecision = Console.ReadLine();
      if (userDecision == "yes" || userDecision == "Yes")
      {
        CheckPalindrome(user);
      }
      else
      {
        Console.WriteLine("Let's fix your information. Please enter it again!");
        Console.WriteLine("Please enter a word, number, or a string of words.");
        string userString = Console.ReadLine();
        ConfirmOrEditUserInput(user);
      }
    }

    static void CheckPalindrome(UserInput user)
    {
      bool result = user.IsPalindrome();
      Console.WriteLine("-----------------------------------------");
      if (result == true)
      {
        Console.WriteLine("Your result is: " + result + "." + " " + "It's a palindrome!");
      }
      else
      {
        Console.WriteLine("Your result is: " + result + "." + " " + "It's not a palindrome! Please try again.");
        Console.WriteLine("-----------------------------------------");
        Main();
      }
      Console.WriteLine("-----------------------------------------");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check another palindrome (new)?");
      Console.WriteLine("Please enter 'new' to check another palindrome.");
      Console.WriteLine("Otherwise, you can enter 'quit' to exit this program.");
      string userResponse = Console.ReadLine();
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "quit" || userResponse == "Quit")
      {
        Console.WriteLine("Goodbye!");
      }
    }
  }
}