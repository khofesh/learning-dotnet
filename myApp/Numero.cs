using System;
using System.Collections.Generic;

namespace myApp
{
  class Numero
  {
    public void printSomething()
    {
      var names = new List<string> { "<name>", "Ana", "felipe" };
      names.Add("maria");
      names.Add("bill");
      names.Remove("Ana");
      foreach (var name in names)
      {
        Console.WriteLine($"hello {name.ToUpper()}!");
      }

      Console.WriteLine($"The list has {names.Count} people in it");

      var index = names.IndexOf("felipe");
      if (index != -1)
      {
        Console.WriteLine($"The name {names[index]} is at index {index}");
      }

      var notFound = names.IndexOf("Not Found");
      Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

      names.Sort();
      foreach (var name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }

      var fibonacciNumbers = new List<int> { 1, 1 };
      var count = 2;

      while (count < 20)
      {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
        count++;
      }


      foreach (var item in fibonacciNumbers)
        Console.WriteLine(item);

    }
  }
}