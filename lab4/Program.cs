using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        
        List<Case> cases = new List<Case>();

        cases.Add(new Case("iPhone Case", "Black", 19.99));
        cases.Add(new Case("Samsung Case", "Blue", 15.99));
        cases.Add(new Case("Google Pixel Case", "Red", 14.99));

        
        DisplayCases(cases);

        Case newCase = new Case("Huawei Case", "Gree", 17.99);
        cases.Add(newCase);
        Console.WriteLine("\nДоданий новий чохол:");
        DisplayCase(newCase);

        Case updatedCase = cases[0];
        updatedCase.Color = "White";
        updatedCase.Price = 22.99;
        Console.WriteLine("\nОновлений чохол:");
        DisplayCase(updatedCase);

       
        Case removedCase = cases[1];
        cases.Remove(removedCase);
        Console.WriteLine("\nВидалений чохол:");
        DisplayCase(removedCase);

        
        Console.WriteLine("\nЧохли після видалення:");
        DisplayCases(cases);
    }

    static void DisplayCase(Case cas)
    {
        Console.WriteLine($"Назва: {cas.Name}, Колір: {cas.Color}, Ціна: ${cas.Price}");
    }

    
    static void DisplayCases(List<Case> cases)
    {
        Console.WriteLine("Усі чохли в магазині:");
        foreach (var cas in cases)
        {
            DisplayCase(cas);
        }
    }
}


class Case
{
    public string Name { get; set; }
    public string Color { get; set; }
    public double Price { get; set; }

    public Case(string name, string color, double price)
    {
        Name = name;
        Color = color;
        Price = price;
    }
}
