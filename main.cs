using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter wind speed: ");
    double windSpeed = Convert.ToDouble(Console.ReadLine());
    string cat;

    switch(windSpeed)
    {
    case var _ when windSpeed >= 157:
      cat = "Category Five Hurricane";
        break;
    case var _ when windSpeed >= 130:
      cat = "Category Four Hurricane";
        break;
    case var _ when windSpeed >= 111:
      cat = "Category Three Hurricane";
        break;
    case var _ when windSpeed >= 96:
      cat = "Category Two Hurricane";
        break;
    case var _ when windSpeed >= 74:
      cat = "Category One Hurricane";
        break;
    default:
      cat = "Not a Hurricane";
        break;
        }

        Console.WriteLine(cat);
    }
}