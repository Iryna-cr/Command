# Command
Ідея команди: 

перетворює дію на об’єкт.

Як працює код: 

Замість виклику функції створюється “команда”, яку можна зберігати, відміняти або виконувати пізніше.
Це часто використовується в кнопках “Замовити”, “Скасувати”, “Повернути”.

Навіщо: зручно для кнопок, історії дій, undo/redo.


## Код
```csharp
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
```
## Результат
![Результат виконання](sc13.png)
