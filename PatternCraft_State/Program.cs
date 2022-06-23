using System;

namespace PatternCraft_State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IUnit
    {
        IUnitState State { get; set; }
        bool CanMove { get; }
        int Damage { get; }
    }
    public interface IUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }
    public class SiegeState : IUnitState
    {
        public bool CanMove { get; set; } = false;
        public int Damage { get; set; } = 20;
    }
    public class TankState : IUnitState
    {
        public bool CanMove { get; set; } = true;
        public int Damage { get; set; } = 5;
    }
    public class Tank : IUnit
    {
        public Tank()
        {
            State = new TankState();
        }
        public IUnitState State { get; set; }
        public bool CanMove => State.CanMove;
        public int Damage => State.Damage;
    }
}
