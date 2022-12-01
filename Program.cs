using Object_Orientated;

class Program
{
    static void Main(string[] args)
    {
        People Person1 = new People(" Thabo", " female", " black", 30);
        People Person2 = new People(" john", " male", " black", 20);
        People Person3 = new People(" Lerato", " female", " black", 35);

        Console.WriteLine(Person1.name + " " + Person1.gender + " " + Person1.race + " " + Person1.age);
        Console.WriteLine(Person2.name + " " + Person2.gender + " " + Person2.race + " " + Person2.age);
        Console.WriteLine(Person3.name + " " + Person3.gender + " " + Person3.race + " " + Person3.age);

    }
}