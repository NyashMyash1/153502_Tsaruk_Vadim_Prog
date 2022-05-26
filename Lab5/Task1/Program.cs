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
            Shop ozon = new Shop();
            ozon.AddProduct("Jacket", 25);
            ozon.AddProduct("Cap", 10);
            ozon.AddProduct("Boots", 30);
            ozon.AddClient("Ivan", ClientCountry.Russia);
            ozon.AddClient("Masha", ClientCountry.Belarus);
            ozon.StartCall("Ivan");
            ozon.BuyProduct("Jacket");
            ozon.BuyProduct("Cap");
            ozon.EndCall();  
            Console.WriteLine(ozon.GetProductsByName("Ivan"));
            Console.WriteLine(ozon.GetSumByName("Ivan"));
        }
    }

    public class Shop
    {
        Client currentCl;
        List<Product> products = new List<Product>();
        List<Client> clients = new List<Client>();
        public void AddClient(string s, ClientCountry ct)
        {
            clients.Add(new Client(s, ct));
        }
        public void AddProduct(string s, int a)
        {
            products.Add(new Product(s, a));
        }
        Client GetClientByName(string s)
        {
            foreach (Client c in clients)
            {
                if (c.Name == s) return c;
            }
            return null;
        }
        Product GetProductByTitle(string s)
        {
            foreach(Product p in products)
            {
                if(p.Title == s) return p;
            }
            return null;
        }
        public void StartCall(string n)
        {
            if(currentCl == null)
                currentCl = GetClientByName(n); 
        }
        public void EndCall()
        {
            currentCl = null;
        }
        public void BuyProduct(string titel)
        {
            Product p = GetProductByTitle(titel);
            currentCl. BuyProduct(p);
        }
        public string GetProductsByName(string name)
        {
            Client c = GetClientByName(name);
            string s = "Client:" + c.Name + "\n";
            foreach (Product p in c.ProdOfCl)
            {
                s += p.Title + "\n";
            }
            return s;
        }

        public string GetSumByName(string name)
        {
            Client c = GetClientByName(name);
            string s = "Client:" + c.Name + "\n" + "Sum:";
            int sum = 0;
            foreach (Product p in c.ProdOfCl)
            {
                sum += p.Price;
            }
            string t = Convert.ToString(sum);
            s += t;
            return s;
        }

        public int GetSumByNameTest(string name)
        {
            Client c = GetClientByName(name);
            int sum = 0;
            foreach (Product p in c.ProdOfCl)
            {
                sum += p.Price;
            }
            return sum;
        }
    }

    public class Client
    {
        public string Name { get; set; }
        public ClientCountry CCountry { get; set; }
        List<Product> prodOfCl= new List<Product>();
        public List<Product> ProdOfCl
        {
            get { return prodOfCl; }
        }
        public Client(string s, ClientCountry cc)
        {
            Name = s;
            CCountry = cc;
        }
        public void BuyProduct(Product p)
        {
            prodOfCl.Add(p);
        }
        public int GetSum()
        {
            int s = 0;
            foreach (Product p in prodOfCl)
            {
                s += p.Price;
            }
            return s;
        }

    }

    public class Product
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public Product(string s, int n)
        {
            Title = s;
            Price = n;
        }
    }
    public enum ClientCountry { Belarus, Russia, Ukraine };
}
