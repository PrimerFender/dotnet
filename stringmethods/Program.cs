using System;

namespace stringmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            string quantityStart = "<span>";
            string quantityStop = "</span>";
            int indexOfQuantityStart = input.IndexOf(quantityStart) + quantityStart.Length;
            int indexOfQuantityStop = input.IndexOf(quantityStop);

            quantity = input.Substring(indexOfQuantityStart, indexOfQuantityStop - indexOfQuantityStart);
            Console.WriteLine(quantity);

            string outputStart = "<div>";
            string outputStop = "</div>";
            int indexOfOutputStart = input.IndexOf(outputStart) + outputStart.Length;
            int indexOfOutputStop = input.IndexOf(outputStop);

            output = input;
            output = output.Substring(indexOfOutputStart, output.Length - indexOfOutputStart - outputStop.Length);
            output = output.Replace("&trade", "&reg");
            Console.WriteLine(output);

            // Correct Output:
            // Quantity: 5000
            // Output: <h2>Widgets &reg;</h2><span>5000</span>
        }
    }
}
