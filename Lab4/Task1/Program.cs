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
            ATS mts = ATS.GetInstanceATS();
            mts.AdressATS = "Минск";
            mts.Clients = 1000;
            mts.ATSTariffOn();
            mts.TariffCostUp(1.5);
            mts.SubsFee = 30;
            double result = mts.AllSubsFee();
            Console.WriteLine(mts.AdressATS);
            Console.WriteLine(result);
        }
    }

    public class Tariff
    {
        //текущий тариф
        private double currentTariff;
        public double CurrentTariff
        {
            get { return currentTariff; }
        }

        //состояние тарифа 
        private bool isTariffOn;
        public bool IsTariffOn
        {
            get { return isTariffOn; }
        }

        //конструкторы 
        public Tariff()
        {
            isTariffOn = true;
            currentTariff = 10;
        }

        public Tariff(double tariff)
        {
            isTariffOn = true;
            currentTariff = tariff;
        }

        public Tariff(bool isOnOff, double tariff)
        {
            isTariffOn = isOnOff;
            if (!isTariffOn)
                currentTariff = 0;
            else 
                currentTariff = tariff;
        }

        //включить тариф
        public void TariffOn()
        {
            isTariffOn = true;
        }
        public void TariffOn(double tariff)
        {
            isTariffOn = true;
            currentTariff = tariff;
        }
        //выключить тариф
        public void TariffOff()
        {
            isTariffOn = false;
            currentTariff = 0;
        }
        //увеличить тариф
        public void TariffUp(double x)
        {
            if (isTariffOn)
                currentTariff += x;
        }
        //уменьшить тариф
        public void TariffDown(double x)
        {
            currentTariff -= x;
        }
    }

    public class ATS
    {
        private static ATS atsInstance;
        private Tariff atsTariff;
        //закрытый конструктор 
        private ATS()
        {
           atsTariff = new Tariff(false, 0);    
        }
        //реализация шаблона singleton
        public static ATS GetInstanceATS()
        {
            if (atsInstance == null)
                atsInstance = new ATS();
            return atsInstance;
        }
        //название АТС
        private string adressATS;
        public string AdressATS
        {
            get{ return adressATS; }
            set{ adressATS = value; }
        }
        //состояние тарифа 
        public bool IsATSTariffOn
        {
            get { return atsTariff.IsTariffOn; }
        }
        public void ATSTariffOn()
        {
            atsTariff.TariffOn();
        }

        public void ATSTariffOn(double x)
        {
            atsTariff.TariffOn(x);
        }

        public void ATSTariffOff()
        {
            atsTariff.TariffOff();
        }
        //текущая плата по тарифу
        public double ATSCurrentTariff
        {
            get { return atsTariff.CurrentTariff; }
        }
        //увеличить тариф 
        public void TariffCostUp(double x)
        {
            atsTariff.TariffUp(x);
        }
        //уменьшить тариф 
        public void TariffCostDown(double x)
        {
            atsTariff.TariffDown(x);
        }
        //абонентская плата за кол-во дней
        private double subsFee;
        public double SubsFee
        {
            get { return subsFee; }
            set { subsFee = value * ATSCurrentTariff; }
        }
        //число клиентов
        private int clients;
        public int Clients
        {
            get { return clients; }
            set { clients = MaxClients(value); }
        }
        //абонентская плата для всех клиентов 
        public double AllSubsFee()
        {
            return clients * subsFee;
        }

        //статический метод
        static int maxClients = 100000;
        public static int MaxClients(int x)
        {
            if(x > maxClients)
            {
                Console.WriteLine("Вы не можете обслуживать больше 100000 клиентов");
                return maxClients;
            }
            else 
                return x;
        }
    }
}
