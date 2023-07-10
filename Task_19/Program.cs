﻿﻿Console.Clear();
Console.Write("Введите пятизначное число:");
int x = Convert.ToInt32(Console.ReadLine());
int b = 0;
int temp = x;
while (temp != 0)
    {
          b = b * 10 + temp % 10; //Переворачиваем число по цифрам
          temp /= 10; //Отбрасываем последнюю цифру
    }
     if (x == b)
          Console.WriteLine("Число является палиндромом");
    else
          Console.WriteLine("Число не является палиндромом");
        return 0;
