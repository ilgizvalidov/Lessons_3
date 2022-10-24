int Method3() // метод возвращает значения типа int
{
    return DateTime.Now.Year; // оператор return возврвщает данные из метода. он обязателен для этого типа метода
}

int year = Method3(); //полученные в результате работы тела Method3 значения типа int будут переопределны в переменную year типа int   
Console.WriteLine(year); 