using System;
using System.Linq;
using static System.Console;
using System.Collections.Generic;

namespace classes
{
  class Program
  {
    static void Main(string[] args)
    {
      var account = new BankAccount("someone", 1000);
      WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

      account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
      WriteLine(account.Balance);
      account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
      WriteLine(account.Balance);

      // test that the initial balances must be positive
      try
      {
        var invalidAccount = new BankAccount("invalid", -55);
      }
      catch (ArgumentOutOfRangeException e)
      {
        WriteLine("Exception caught creating account with negative balance");
        WriteLine(e.ToString());
      }

      // test for a negative balance.
      try
      {
        account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
      }
      catch (InvalidOperationException e)
      {
        WriteLine("Exception caught trying to overdraw");
        WriteLine(e.ToString());
      }

      Console.WriteLine(account.GetAccountHistory());

      var p = new Person("Jonas", "Something", "Kahnwald");
      Console.WriteLine($"The name, in all caps: {p.AllCaps()}");
      Console.WriteLine($"The name: {p}");

      var phrase = "the quick brown fox jumps over the lazy dog";
      var wordLength = from word in phrase.Split(' ') select word.Length;
      WriteLine($"The average word length is: {wordLength.Average():F2}");

      string s = null;
      Console.WriteLine(s?.Length);

      char? c = s?[0];
      WriteLine(c.HasValue);

      bool? hasMore = s?.ToCharArray()?.GetEnumerator()?.MoveNext() ?? false;
      Console.WriteLine(hasMore.HasValue && hasMore.Value);

      try
      {
        string something = null;
        WriteLine(something.Length);
      }
      catch (System.Exception e) when (LogException(e))
      {
      }
      Console.WriteLine("Exception must have been handled");


      WriteLine(nameof(System.String));
      int j = 5;
      WriteLine(nameof(j));
      List<string> names = new List<string>();
      WriteLine(nameof(names));

      var messages = new Dictionary<int, string>
      {
        [404] = "page not found",
        [302] = "page moved, but left a forwarding address.",
        [500] = "the web server can't come out to play today"
      };


    }

    private static bool LogException(Exception e)
    {
      Console.WriteLine($"\tIn the log routine. Caught {e.GetType()}");
      Console.WriteLine($"\tMessage: {e.Message}");
      return true;
    }


  }
}
