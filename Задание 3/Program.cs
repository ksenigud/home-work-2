Console.Write("Введите число недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n>8)
    {Console.WriteLine("Введенное число не является числом дня недели, повторите ");
     n = Convert.ToInt32(Console.ReadLine());
    }
void Week()
{   
    if (n>5)
    Console.WriteLine("да, выходной");
    else 
    Console.WriteLine("нет");

}

Week ();
