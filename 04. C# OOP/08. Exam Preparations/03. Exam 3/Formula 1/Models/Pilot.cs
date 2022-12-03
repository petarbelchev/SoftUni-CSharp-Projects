﻿using Formula1.Models.Contracts;
using Formula1.Utilities;
using System;

namespace Formula1.Models
{
    public class Pilot : IPilot
    {
        private string fullName;
        private IFormulaOneCar car;

        public Pilot(string fullName)
        {
            FullName= fullName;
            CanRace = false;
            NumberOfWins = 0;
        }

        public string FullName
        {
            get => fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new ArgumentException(ExceptionMessages.InvalidPilot, value);

                fullName = value;
            }
        }

        public IFormulaOneCar Car 
        { 
            get => car;
            private set
            {
                if (value == null)
                    throw new NullReferenceException(ExceptionMessages.InvalidCarForPilot);

                car = value;
            }
        }

        public int NumberOfWins { get; private set; }

        public bool CanRace { get; private set; }

        public void AddCar(IFormulaOneCar car)
        {
            Car = car;
            CanRace = true;
        }

        public void WinRace()
            => NumberOfWins++;

        public override string ToString()
            => $"Pilot {this.FullName} has {this.NumberOfWins} wins.";
    }
}
