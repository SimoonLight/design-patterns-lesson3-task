namespace design_patterns_lesson3_task
{
    public interface Chair
    {
        public void hasLegs();
        public void sitOn();
    } 
    
    public interface Sofa
    {
        public void hasLegs();
        public void sitOn();
    }
    
    public interface CoffeeTable
    {
        public void hasLegs();
        public void sitOn();
    }

    public class VictorianChair : Chair
    {
        public void hasLegs()
        {
            Console.WriteLine(" Victorian Chair has Legs method ");
        }

        public void sitOn()
        {
            Console.WriteLine(" Victorian Chair sit On method ");
        }
    }
    public class ModernChair : Chair
    {
        public void hasLegs()
        {
            Console.WriteLine(" Modern Chair has Legs method ");
        }

        public void sitOn()
        {
            Console.WriteLine(" Modern Chair sit On method ");
        }
    }

    public class VictorianSofa : Sofa
    {
        public void hasLegs()
        {
            Console.WriteLine(" Victorian Sofa has Legs method ");
        }

        public void sitOn()
        {
            Console.WriteLine(" Victorian Sofa sit On method ");
        }
    }
    public class ModernSofa : Sofa
    {
        public void hasLegs()
        {
            Console.WriteLine(" Modern Sofa has Legs method ");
        }

        public void sitOn()
        {
            Console.WriteLine(" Modern Sofa sit On method ");
        }
    }

    public class VictorianCoffeeTable : CoffeeTable
    {
        public void hasLegs()
        {
            Console.WriteLine(" Victorian Coffee Table has Legs method ");
        }

        public void sitOn()
        {
            Console.WriteLine(" Victorian Coffee Table sit On method ");
        }
    }
    public class ModernCoffeeTable : CoffeeTable
    {
        public void hasLegs()
        {
            Console.WriteLine(" Modern Coffee Table has Legs method ");
        }

        public void sitOn()
        {
            Console.WriteLine(" Modern Coffee Table sit On method ");
        }
    }


    public interface FurnitureFactory
    {
        public Chair createChair();
        public CoffeeTable createCoffeeTable();
        public Sofa createSofa();
    }

    public class VictorianFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            Console.WriteLine(" Victorian Furniture Factory create Chair method ");
            throw new NotImplementedException();
        }

        public CoffeeTable createCoffeeTable()
        {
            Console.WriteLine(" Victorian Furniture Factory create CoffeeTable method ");
            throw new NotImplementedException();
        }

        public Sofa createSofa()
        {
            Console.WriteLine(" Victorian Furniture Factory create Sofa method ");
            throw new NotImplementedException();
        }
    }

    public class ModernFurnitureFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            Console.WriteLine(" Modern Furniture Factory create Chair method ");
            throw new NotImplementedException();
        }

        public CoffeeTable createCoffeeTable()
        {
            Console.WriteLine(" Modern Furniture Factory create CoffeeTable method ");
            throw new NotImplementedException();
        }

        public Sofa createSofa()
        {
            Console.WriteLine(" Modern Furniture Factory create Sofa method ");
            throw new NotImplementedException();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
