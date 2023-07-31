/*public interface IStrategyMethod
{
    string Move();
}

public class CarMove : IStrategyMethod
{
    public string Move()
    {
       string car = "You are move on Car";
        return car;
    }
}
public class ShipMove : IStrategyMethod
{
    public string Move()
    {
        string ship = "You are move on Ship";
        return ship;
    }
}

public class ContextStrategy
{
  public IStrategyMethod? ContextStrategyProp { get; set; }
    *//*============Реализация с передачей обьекта в конструктор================*/

/*   public ContextStrategy (IStrategyMethod _Strategy)
   {
       ContextStrategyProp = _Strategy;
   }*/

/*===========Реализация с помощью передачи конструктора в метод==============*//*
public void ChoiseMove(IStrategyMethod method)
{
    ContextStrategyProp = method;
}
public string Execute()
{
  string move = ContextStrategyProp.Move();
    return move;
}
}
public class Program
{
   static void Main()
   {
    ContextStrategy context = new ContextStrategy();
    context.ChoiseMove(new CarMove());
    Console.WriteLine(context.Execute());
    context.ChoiseMove(new ShipMove());
    Console.WriteLine(context.Execute());
   }
}
*/


public interface IMove
{
    string CreateTransport();
}

public class CarCreate : IMove
{
    public string CreateTransport()
    {
        string car = "Car";
        return car;
    }
}

public class ShipCreate : IMove
{
    public string CreateTransport()
    {
        string ship = "Ship";
        return ship;
    }
}
public class ContextTransport
{ 
    public IMove MoveApproach { get; set; }

    public void ChoiceTransport(IMove move)
    {
        MoveApproach = move;
    }

    public string Execute ()
    {
        string move = MoveApproach.CreateTransport();
        return move;
    }
}

public class Program
{
    static void Main()
    {
        var context = new ContextTransport();
        context.ChoiceTransport(new CarCreate());
        Console.WriteLine(context.Execute());
        context.ChoiceTransport(new ShipCreate());
        Console.WriteLine(context.Execute());
    }
}
