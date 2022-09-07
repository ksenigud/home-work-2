void Numb ()
{int n = Convert.ToInt32(Console.ReadLine());
if (n<100)
    Console.WriteLine("третьей цифры нет");
else     
    Console.WriteLine(Convert.ToString (n)[2]);
}

Numb ();
