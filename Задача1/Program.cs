int Exponentiation(int numberA, int numberB)
{
 int result = 1;
 for(int i=1; i <= numberB; i++)
    {
    result = result * numberA;
    }
    return result;
}

 Console.Write("Введите число A: ");
 int numberA = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите число B: ");
 int numberB = Convert.ToInt32(Console.ReadLine());

 int exponentiation = Exponentiation(numberA, numberB);
 Console.WriteLine("Ответ: " + exponentiation);
