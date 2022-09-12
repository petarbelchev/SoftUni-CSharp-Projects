﻿namespace T05.Restaurant
{
    public class Cake : Dessert
    {
        private const double Grams = 250;
        private const double Calories = 1000;
        private const decimal Price = 5;

        public Cake(string name)
            : base(name, Price, Grams, Calories)
        {

        }
    }
}
