using System;

namespace PatternCraft_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }              
    }
    
    public interface IMarine
    {
        int Damage { get; }
        int Armor { get; }
    }

    public class Marine : IMarine
    {
        public int Damage { get; }
        public int Armor { get; }
        public Marine(int damage, int armor)
        {
            Damage = damage;
            Armor = armor;
        }
    }    
    
    public class MarineWeaponUpgrade :IMarine
    {
        public int Damage { get; }
        public int Armor { get; }
        public MarineWeaponUpgrade(IMarine marine)
        {
            Damage = marine.Damage + 1;
            Armor = marine.Armor;
        }        
    }

    public class MarineArmorUpgrade : IMarine
    {
        public int Damage { get; }
        public int Armor { get; }
        public MarineArmorUpgrade(IMarine marine)
        {
            Damage = marine.Damage;
            Armor = marine.Armor + 1;
        }
    }
}

