using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainConsoleApp.OOP.Operators
{
    public struct Temperature
    {
        public Units Units;
        public int Value;

        public static Temperature operator +(Temperature temp, int value)
        {
            return new Temperature
            {
                Value = temp.Value + value,
                Units = temp.Units
            };
        }

        public static Temperature operator -(Temperature temp, int value)
        {
            return new Temperature
            {
                Value = temp.Value - value,
                Units = temp.Units
            };
        }

        public static bool operator >(Temperature a, Temperature b)
        {
            return a.ToCelsius().Value > b.ToCelsius().Value;
        }
        
        public static bool operator <(Temperature a, Temperature b)
        {
            return a.ToCelsius().Value < b.ToCelsius().Value;
        }

        public bool Equals(Temperature other)
        {
            return Units == other.Units && Value == other.Value;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Temperature && Equals((Temperature) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((int) Units*397) ^ Value;
            }
        }

        public static bool operator ==(Temperature left, Temperature right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Temperature left, Temperature right)
        {
            return !left.Equals(right);
        }

        public static implicit operator string(Temperature t)
        {
            return t.ToString();
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", Value, Units);
        }

        public static explicit operator int(Temperature t)
        {
            return t.ToCelsius().Value;
        }
    }
}
