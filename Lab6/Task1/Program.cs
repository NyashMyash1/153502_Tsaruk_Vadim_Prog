using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Products milk = new Milk(3, 50, 6);
            Products meat = new Meat(7, 10, 1);
            Products bakery = new Bakery(1, 50, 1);
            milk.ShowInfo();
            meat.ShowInfo();
            bakery.ShowInfo();
            milk.Sell(10);  
            meat.Sell(5);
            bakery.Sell(10);
            milk.ShowInfo();
            meat.ShowInfo();
            bakery.ShowInfo();
        }
    }
}

public abstract class Products
{
    public Products(int cost, int amount, int expiration)
    {
        this.cost = cost;
        this.amount = amount;
        this.expiration_date = expiration;
    }
    public Products()
    {
        cost = 0;
        amount = 0;
        expiration_date = 0;
    }

    internal int cost;
    public int Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    internal int amount;
    public int Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    internal int expiration_date;
    public int Expiration_date
    {
        get { return expiration_date; }
        set { expiration_date = value; }
    }

    public abstract bool IsExpired(Products product);

    public virtual void Sell(int number)
    {
        if(!(IsExpired(this)) && number > 0 && this.amount > number)
        {
            this.amount -= number;
        }
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("Cost:{0}", Convert.ToString(this.cost));
        Console.WriteLine("Amount:{0}", Convert.ToString(this.amount));
        Console.WriteLine("Days from delivery: {0}", Convert.ToString(this.expiration_date));
    }

}

public sealed class Milk : Products
{
    public Milk(int cost, int amount, int expiration) : base (cost, amount, expiration)
    {

    }

    public override bool IsExpired(Products product)
    {
        if (product.expiration_date > 5)
            return true;
        else 
            return false;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Milk:");
        base.ShowInfo();
    }
}

public class Meat : Products
{
    public Meat(int cost, int amount, int expiration) : base(cost, amount, expiration)
    {

    }

    public override bool IsExpired(Products product)
    {
        if (product.expiration_date > 4)
            return true;
        else
            return false;
    }

    public override void Sell(int number)
    {
        if(number < 2)
            base.Sell(number);
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Meat:");
        base.ShowInfo();
    }
}

public class Bakery : Products
{
    public Bakery(int cost, int amount, int expiration) : base(cost, amount, expiration)
    {

    }

    public override bool IsExpired(Products product)
    {
        if (product.expiration_date > 2)
            return true;
        else
            return false;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Bakery:");
        base.ShowInfo();
    }
}
