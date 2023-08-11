using System;
namespace EnumsDemo
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            var method2 = ShippingMethod.RegularAirMail;
            Console.WriteLine((int)method);
            Console.WriteLine((int)method2);

            var methodId = 3;

            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(method.ToString());

            Console.WriteLine(method2.ToString());

            var methodName = "RegularAirMail";

            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            Console.WriteLine(shippingMethod);
        }
    }
}