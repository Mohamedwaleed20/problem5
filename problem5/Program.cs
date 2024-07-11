// See https://aka.ms/new-console-template for more information
int id;
string name;
int age;

while (true)
{
    Console.Write("Enter ID: ");
    id = int.Parse(Console.ReadLine());

    Console.Write("Enter Name: ");
    name = Console.ReadLine();

    Console.Write("Enter Age: ");
    age = int.Parse(Console.ReadLine());

    if (age <= 0)
    {
        Console.WriteLine("Age must be greater than zero. Please try again.");
        continue;
    }

    Console.WriteLine("your data");
    Console.WriteLine("id : {0} ", id);
    Console.WriteLine("name : {0} ", name);
    Console.WriteLine("age : {0} ", age);
    break;
}

Console.ReadLine();
        
    




