using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Nether_Realms_linq
{
    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse)
                .OrderBy(n => n.Name)
                .ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }

    class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }

        public static Demon Parse(string demonName)
        {
            var demon = new Demon();

            demon.Name = demonName;
            demon.Health = CalculateHealth(demonName);
            demon.Damage = CalculateDamage(demonName);

            return demon;
        }

        public static decimal CalculateDamage(string demonName)
        {
            var damagePattern = @"[+-]?\d+(?:\.?\d+)?";

            var damage = Regex.Matches(demonName, damagePattern)
            .Cast<Match>()
            .Select(a => decimal.Parse(a.Value))
            .Sum();

            var modifiers = demonName
                .Where(a => a == '*' || a == '/')
                .ToArray();

            foreach (var modifier in modifiers)
            {
                switch (modifier)
                {
                    case '*':
                        damage *= 2;
                        break;
                    case '/':
                        damage /= 2;
                        break;
                    default:
                        break;
                }
            }

            return damage;
        }

        public static decimal CalculateHealth(string demonName)
        {
            var healthPattern = @"[^0-9+\-*\/\.]";

            var health = Regex.Matches(demonName, healthPattern)
                .Cast<Match>()
                .Select(a => (int)char.Parse(a.Value))
                .Sum();

            return health;
        }
    }
}