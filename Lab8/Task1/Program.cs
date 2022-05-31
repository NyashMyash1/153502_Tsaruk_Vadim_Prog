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
            HRD company = new HRD();

            company.AddNoPremiumJob("work1", 10);
            company.AddPremiumJob("work3", 30, 50);
            Console.WriteLine(company.GetTotalSalary());
        }
    }

    interface ISalary
    {
        double GetSalary();
    }

    class NoPremium : ISalary
    {
        double salary;
        public NoPremium(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
    }

    class Premium : ISalary
    {
        double salary;
        double premium;
        public Premium(double salary, double premium)
        {
            this.salary = salary;
            this.premium = premium;
        }
        public double GetSalary()
        {
            return salary + salary * premium / 100;
        }
    }

    class Job
    {
        public Job(string title, ISalary isalary)
        {
            this.title = title;
            this.isalary = isalary;
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }


        ISalary isalary;

        public double GetSalary()
        {
            return isalary.GetSalary();
        }

    }

    public class HRD
    {
        List<Job> lstJob = new List<Job>();

        public void AddNoPremiumJob(string name, double price)
        {
            Job newJob = new Job(name, new NoPremium(price));
            lstJob.Add(newJob);
        }
        public void AddPremiumJob(string name, double price, double premium)
        {
            Job newJob = new Job(name, new Premium(price, premium));
            lstJob.Add(newJob);
        }

        public double GetTotalSalary()
        {
            double result = 0;

            foreach (Job job in lstJob)
            {
                result += job.GetSalary();
            }

            return result;
        }
    }
}


