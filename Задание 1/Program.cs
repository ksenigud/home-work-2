Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<100 || n>1000)
    {Console.WriteLine("Введенное число не является трехзначным.Повторите, пожалуйста: ");
     n = Convert.ToInt32(Console.ReadLine());
    }
void secondNumber()
{   
    Console.WriteLine(Convert.ToString (n)[1]);
}

secondNumber ();