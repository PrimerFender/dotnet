using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {   
            // First Challenge
            // Better than foreach loop because it replaces each index with a new string; doesn't add extra spaces
            /* string pangram = "The quick brown fox jumps over the lazy dog";
            string[] message = pangram.Split(" ");
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = String.Join(" ", newMessage);
            Console.WriteLine(result); */

            // Second Challenge
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] orders = orderStream.Split(",");
            string[] fraudOrders = {};
            
            foreach (string order in orders)
            {
                if (order.ToUpper().StartsWith("B"))
                {
                    // Console.WriteLine(order); // This is the actual answer 🤣
                    Array.Resize(ref fraudOrders, fraudOrders.Length + 1);
                    fraudOrders[fraudOrders.Length - 1] = order;
                }
            }
            Console.WriteLine(String.Join("\n", fraudOrders));
        }
    }
}
