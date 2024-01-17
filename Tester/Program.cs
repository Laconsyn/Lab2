using Library;

void test1()
{
    Console.WriteLine(Class1.Evaluate("5"));
}

void test2()
{
    if (Class1.Evaluate("5+5") != 10)
    {
        Console.WriteLine("Error in simple addition!");
    }
}

test1();
test2();

Console.Read();