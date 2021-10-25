using System;

namespace Task_2
{
    class Converter
    {
        readonly double usd, eur, rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        // из гривны в выбранную валюту
        public void ConvertTo(double amount, string mode)
        {
            switch (mode)
            {
                case "toUsd":
                    Console.WriteLine("За {0} гривен можно купить {1} долларов США", amount, amount / usd);
                    
                    break;

                case "toEur":
                    Console.WriteLine("За {0} гривен можно купить {1} евро", amount, amount / eur);
                    break;

                case "toRub":
                    Console.WriteLine("За {0} гривен можно купить {1} оккупантских рублей", amount, amount / rub);
                    break;
            }
        }

        public void ConvertFrom(double amount, string mode)
        {
            switch (mode)
            {
                case "fromUsd":
                    Console.WriteLine("За {0} долларов можно купить {1} гривен", amount, amount * usd);
                    break;

                case "fromEur":
                    Console.WriteLine("За {0} евро можно купить {1} гривен", amount, amount * eur);
                    break;

                case "fromRub":
                    Console.WriteLine("За {0} рублей можно купить {1} гривен", amount, amount * rub);
                    break;
            }
        }

    }
}
