           // МЕТОДЫ (ФУНКЦИИ, ПРОЦЕДУРЫ)

// Вид 1 Ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор - Алексей");
}
//Method1();  //Как вызываются

void Method2(string msg)
// Вид 2 Что-то принимают, ничего не возвращают
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method2_1(string msg, int count)
// можно явно указать значение аргумента
{
    int i =0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    } 
}
//Method2_1(msg: "Текст", count: 4); //4 - вызов 4 раза
//Method2_1(count: 4, msg: "Текст", 4); //если аргумент именнованный необязательно писать по-порядку

int Method3()
// Вид 3 Ничего не принимают, что-то возвращают
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

//Вид 4 Что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf"); //будет склеивать 10 раз
//Console.WriteLine(res);

