using System;
using System.Threading;


namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

            Converter instance = new Converter(26.2918, 30.5774, 0.37385);

            instance.ConvertTo(500, "toUsd");
            instance.ConvertFrom(50, "fromUsd");
            instance.ConvertTo(30000, "toRub");
            instance.ConvertFrom(67000, "fromRub");
        }
    }
}
