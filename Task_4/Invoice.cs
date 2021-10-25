using System;

namespace Task_4
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;
        public string Article { get; set; }
        public int Quantity { get; set; }
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;

        }
        public void CostShow(bool flagNds)
        {
            double cost;
            switch (Article)
            {
                case "flat-tvs":
                    cost = 14599;
                    break;
                case "mp3-pleers":
                    cost = 999;
                    break;
                case "igrovye-konsoli":
                    cost = 13699;
                    break;
                default:
                    Console.WriteLine("Нет иформации");
                    return;
            }

            cost = flagNds ? cost : cost * 0.14;

            Console.WriteLine(account + " " + customer + " " + provider);
            Console.WriteLine("Общая сумма оплаты: {0} uah\n", cost * Quantity);
        }

    }
}
