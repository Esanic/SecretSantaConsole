using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        /*
          "Irene",
          "Lasse",
          "Toffe",
          "Anna",
          "Daniel",
          "Frida",
          "Sven-Eric",
          "Hunden",
          "Katten"
         */
        List<string> from = new List<string>
    {
      "Toffe",
      "Anna",
      "Lena",
      "Stefan",
      "Isak",
      "Emma",
      "Olof",
      "Fredrik",
      "Kerstin"
    };

        List<string> to = new List<string>
    {
      "Toffe",
      "Anna",
      "Lena",
      "Stefan",
      "Isak",
      "Emma",
      "Olof",
      "Fredrik",
      "Kerstin"
    };

        for (int i = 0; i < from.Count; i = 0)
        {
            Random r = new Random();
            int randNumFrom = r.Next(0, from.Count);

            Random ra = new Random();
            int randNumTo = r.Next(0, to.Count);

            if (!(from[randNumFrom] == to[randNumTo]))
            {
                Console.WriteLine($"{from[randNumFrom]} -> {to[randNumTo]}");
                from.Remove(from[randNumFrom]);
                to.Remove(to[randNumTo]);
            }
        }
    }
}
