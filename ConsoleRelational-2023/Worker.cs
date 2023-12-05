using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRelational_2023;

public class Worker
{

    public   void DoWork()
    {
        decimal productPrice = 0.1m;
        decimal freight = 0.2m;
        decimal totalAmount = 0.3m;
        bool comparison = (productPrice + freight) == totalAmount;
        if (comparison)
        {
            Console.WriteLine("The sum is correct");
        }
        else
        {
            Console.WriteLine($"The sum {totalAmount} is NOT {productPrice + freight}");
        }
        .Console.WriteLine("hello");
    }

}
