Console.WriteLine("Hello, Jerry");
E();

PrintABC();
Thread.Sleep(500);
PrintABC();
Thread.Sleep(500);
PrintABC();

A();
A();
A();

Console.ReadKey();

void PrintABC()
{
    Console.WriteLine("A");
    Console.WriteLine("B");
    Console.WriteLine("C");
}

void A()
{
    B();
    C();
}

void B()
{
    Console.WriteLine("Функция B");
}

void C()
{
    Console.WriteLine("Функция C");
}

void D()
{
    Console.WriteLine("Я никогда не выполнюсь");
}

void E()
{
Console.WriteLine("Поряядок не важен!");
}
