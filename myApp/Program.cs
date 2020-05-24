using System;

namespace myApp
{
  class Program
  {
    static void Main(string[] args)
    {
      DateTime rightNow = DateTime.Now;
      string question = "Que tiempo hace?";
      string greeting = "     Buenas Noches!    ";

      Console.WriteLine($"Hola, {question}");
      Console.WriteLine("Hace calor " + rightNow);

      string trimmedGreeting = greeting.TrimStart();
      Console.WriteLine($"[{trimmedGreeting}]");

      trimmedGreeting = greeting.TrimEnd();
      Console.WriteLine($"[{trimmedGreeting}]");

      trimmedGreeting = greeting.Trim();
      Console.WriteLine($"[{trimmedGreeting}]");

      string greetingModified = greeting.Replace("Noches", "Tardes");
      Console.WriteLine(greetingModified);

      Console.WriteLine(greetingModified.ToUpper());
      Console.WriteLine(greetingModified.ToLower());

      Numero numbers = new Numero();
      numbers.printSomething();
    }
  }
}
