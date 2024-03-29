﻿using System;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            GetTotalPrice(product, quantity);
        }

        static void GetTotalPrice(string product, int quantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee":
                    price = 1.5;
                    break;

                case "water":
                    price = 1.00;
                    break;

                case "coke":
                    price = 1.4;
                    break;

                case "snacks":
                    price = 2.00;
                    break;
            }

            double totalPrice = quantity * price;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
