using System;

namespace PatternCraft_Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public interface IVisitor
    {
        void VisitLight(ILightUnit unit);
        void VisitArmored(IArmoredUnit unit);
    }

    public interface IUnit
    {        public int Health { get; set; }
        void Accept(IVisitor visitor);
    }

    public interface ILightUnit : IUnit
    {
        
    }
    public interface IArmoredUnit : IUnit
    {

    }

    public class Marine : ILightUnit
    {
        public int Health { get; set; } = 100;

        public void Accept(IVisitor visitor)
        {
            visitor.VisitLight(this);
        }
    }
    public class Marauder :IArmoredUnit
    {
        public int Health { get; set; } = 125;
        public void Accept(IVisitor visitor)
        {
            visitor.VisitArmored(this);
        }
    }
    public class TankBullet : IVisitor
    {
        public void VisitLight(ILightUnit unit)
        {
            unit.Health -= 21;
        }

        public void VisitArmored(IArmoredUnit unit)
        {
            unit.Health -= 32;
        }
    }
}
