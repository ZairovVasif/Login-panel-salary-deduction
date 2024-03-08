using System;

class Program
{
    static void Main()
    {
        string admin = "admin";
        string password = "123456";

        Console.WriteLine("Salam, xoş gəldiniz. Şirkət hesabınızı daxil edin: ");
        string username = Console.ReadLine();

        if (username != admin)
        {
            Console.WriteLine("Sadəcə idarəçi giriş edə bilər.");
        }
        else
        {
            Console.WriteLine("Salam, Admin, \nŞifrəni daxil edin: ");
            string enteredPassword = Console.ReadLine();

            if (enteredPassword == password)
            {
                Console.WriteLine("Təbriklər, giriş etdiniz.");

                CalculateDeduction();
            }
            else
            {
                Console.WriteLine("Şifrə yanlışdır.");
            }
        }
    }

    static void CalculateDeduction()
    {
        Console.WriteLine("Maaşınızı daxil edin: ");
        int salary = Convert.ToInt32(Console.ReadLine());

        int deduction = 0;
        if (salary >= 1000 && salary <= 2500)
        {
            deduction = 200;
        }
        else if (salary >= 2501 && salary <= 4000)
        {
            deduction = 350;
        }
        else if (salary > 4000)
        {
            deduction = 450;
        }

        Console.WriteLine($"Maaşınızda {deduction} AZN kesinti olacaq.");
    }
}
