void Method2 (string msg)
{
    Console.WriteLine (msg); // вывод аргумента msg типа string. будут выведены значения полученные в процессе вызова Method2
}

Method2("этот текст передается в аргумент msg типа string. Дале в теле метода выполняются операции с данными переданными в аргумент msg");

void Method21 (string msg, string msg1, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine (msg);
        Console.WriteLine (msg1);
        i++;
    }
}

Method21 (msg:"именные аргументы используются для передачи значений в аргументы с соответствующими именами при вызове метода.", msg1:" пример msg: текст, count: число", count: 3 );