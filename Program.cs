int hour = 0;
int min = 0;



while (hour < 24)
{
   

   

    if (hour < 10)
    {
        Console.Write("0" + hour);
    }
    else if (hour >= 10)
    {
        Console.Write(hour);
    }

    if (min < 10)
    {
        Console.WriteLine(":0" + min);
    }
    else if (min >= 10)
    {
        Console.WriteLine(":" + min);
    }

    min++;
    if (min == 60)
    {
        hour++;
        min = 0;
    }
}


