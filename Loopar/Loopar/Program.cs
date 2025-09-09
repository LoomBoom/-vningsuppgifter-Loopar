
int myInt = 20;

while(myInt < 31)
{
    Console.WriteLine(myInt);
    myInt++;
}

for(int i = 0; i < 31; i++)
{
    if (i % 2 == 0) Console.WriteLine(i);
}

for (int i = 0; i < 31; i++)
{
    if (i % 3 == 0) {
        Console.WriteLine("Hej");
    }
    else
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine();
Console.WriteLine("Skriv ett tal så ska jag lära dig multplikation.");
int myNumber = Int32.Parse(Console.ReadLine());

for(int i = 0;i < 10; i++)
{
    Console.WriteLine((i+1) * myNumber);
}

Console.WriteLine();

int sumOfAllNumbers = 0;
for(int i = 0;i < 1001 ; i++)
{
    sumOfAllNumbers += i;
}
Console.WriteLine(sumOfAllNumbers);

Console.WriteLine();

long risKorn = 1;
for (int i = 1;i < 65 ; i++)
{
    Console.WriteLine($"Ruta {i}: {risKorn}");
    risKorn *= 2;
}

Console.WriteLine();
Console.WriteLine("Ge mig höjd");
int hight = Int32.Parse(Console.ReadLine());
Console.WriteLine("Ge mig bredd");
int length = Int32.Parse(Console.ReadLine());

for (int i = 0;i < hight ; i++)
{
    for (int j = 0; j < length; j++) Console.Write("x");
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < hight; i++)
{
    for (int j = 0; j < length; j++)
    {
        if(j % 2 == 0)
        {
            Console.Write("X");
        }
        else
        {
            Console.Write("O");
        }
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < hight; i++)
{
    for (int j = 0; j < length; j++)
    {
        if (((i+j) % 2 == 0))
        {
            Console.Write("X");
        }
        else
        {
            Console.Write("O");
        }
    }
    Console.WriteLine();
}

for (int i = 0; i < hight; i++)
{
    for (int j = 0; j < length; j++)
    {
        if (i == 0 || i == hight-1)
        {
            Console.Write('X');
        }
        else
        {
            if (j == 0 || j == length-1)
            {
                Console.Write('X');
            }
            else
            {
                Console.Write(' ');
            }
        }  
    }
    Console.WriteLine();
}

for (int i = 0; i < 11; i++)
{
    for(int j = 1;j < i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

for (int a = 0;a < 11; a++)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 1; j < i; j++)
        {
            Console.Write(j);
        }
        Console.WriteLine();
    }
}

int primTal = 0;
while (primTal < 20)
{
    int i = 0;
}
