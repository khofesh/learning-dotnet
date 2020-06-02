using static System.Console;

namespace classes
{
  class Person
  {
    public string FirstName { get; }
    public string LastName { get; }
    public string MiddleName { get; } = "";

    public Person(string first, string middle, string last)
    {
      FirstName = first;
      LastName = last;
    }

    public override string ToString() => $"{FirstName} {LastName}";

    public string AllCaps() => ToString().ToUpper();

  }
}