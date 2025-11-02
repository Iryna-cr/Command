using System;

class Order
{
    public void Make() => Console.WriteLine(" Замовлення створено");
}

class MakeOrderCommand
{
    private Order order;
    public MakeOrderCommand(Order o) { order = o; }
    public void Execute() => order.Make();
}

class Program
{
    static void Main()
    {
        var order = new Order();
        var cmd = new MakeOrderCommand(order);
        cmd.Execute();
    }
}









