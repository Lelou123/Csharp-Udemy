using System;
using System.Collections.Generic;

namespace Dictionaryy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "88912894";
            cookies["phone"] = "98942837"; // sobrescreve anterior
            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["phone"]);

            
            cookies.Remove("email");
            if (cookies.ContainsKey("email")) Console.WriteLine(cookies["email"]);
                else Console.WriteLine("there is no email");

            Console.WriteLine("Size " + cookies.Count);

            Console.WriteLine("All cookies: ");
            foreach( var item in cookies) //KeyValuePair<string, string> alternativa
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
