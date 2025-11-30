using System;


public interface ITree
{
   string GetDescription();
   void Shine();
}


public class ChristmasTree : ITree
{
   public string GetDescription()
   {
       return "Проста ялинка";
   }


   public void Shine()
   {
       Console.WriteLine("Ялинка не має гірлянд і не світиться");
   }
}


public abstract class TreeDecorator : ITree
{
   protected ITree _tree;


   protected TreeDecorator(ITree tree)
   {
       _tree = tree;
   }


   public virtual string GetDescription()
   {
       return _tree.GetDescription();
   }


   public virtual void Shine()
   {
       _tree.Shine();
   }
}


public class ToysDecorator : TreeDecorator
{
   public ToysDecorator(ITree tree) : base(tree) {}


   public override string GetDescription()
   {
       return _tree.GetDescription() + ", прикрашена іграшками";
   }
}


public class GarlandDecorator : TreeDecorator
{
   public GarlandDecorator(ITree tree) : base(tree) {}


   public override string GetDescription()
   {
       return _tree.GetDescription() + ", з гірляндами";
   }


   public override void Shine()
   {
       Console.WriteLine("Гірлянди світяться");
   }
}


public class Program
{
   public static void Main()
   {
       ITree tree = new ChristmasTree();


       tree = new ToysDecorator(tree);


       tree = new GarlandDecorator(tree);


       Console.WriteLine(tree.GetDescription());
       tree.Shine();
   }
}
