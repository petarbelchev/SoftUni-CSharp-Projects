﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _05._Dragon_Army
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, Dictionary<string, DragonStats>>();

            int numOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfDragons; i++)
            {
                string[] dragonDetails = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string newDragonType = dragonDetails[0];
                string newDragonName = dragonDetails[1];
                var newDragonStats = new DragonStats(dragonDetails[2], dragonDetails[3], dragonDetails[4]);

                if (!dragons.ContainsKey(newDragonType))
                {
                    dragons.Add(newDragonType, new Dictionary<string, DragonStats>());
                    dragons[newDragonType].Add(newDragonName, newDragonStats);
                }
                else
                {
                    if (dragons[newDragonType].Keys.Contains(newDragonName))
                    {
                        dragons[newDragonType][newDragonName] = newDragonStats;
                    }
                    else
                    {
                        dragons[newDragonType].Add(newDragonName, newDragonStats);
                    }
                }
            }

            foreach (var type in dragons)
            {
                double avDamage = type.Value.Select(x => x.Value.Damage).Average();
                double avHealth = type.Value.Select(x => x.Value.Health).Average();
                double avArmor = type.Value.Select(x => x.Value.Armor).Average();

                Console.WriteLine($"{type.Key}::({avDamage:f2}/{avHealth:f2}/{avArmor:f2})");

                foreach (var dragon in type.Value.OrderBy(name => name.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }
    }

    class DragonStats
    {
        public DragonStats(string damage, string health, string armor)
        {
            Damage = damage == "null" ? 45 : Damage = int.Parse(damage);
            Health = health == "null" ? 250 : Health = int.Parse(health);
            Armor = armor == "null" ? 10 : Armor = int.Parse(armor);
        }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
    }
}
