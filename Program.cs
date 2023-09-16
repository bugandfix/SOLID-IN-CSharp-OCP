using SOLID_IN_CSharp.RulesIndicator;
using System;

namespace SOLID_IN_CSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bug&Fix Tax Calculation System Starting...");

        var taxengine = new AssetTaxEngine();
        taxengine.CalculateTaxRate();

        if (taxengine.TaxRate > 0)
        {
            Console.WriteLine($"Tax Rate is: {taxengine.TaxRate}");
        }
        else
        {
            Console.WriteLine("Something was wrong.");
        }

    }
}
