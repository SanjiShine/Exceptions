namespace Aufgabe03_Lebensalter;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Person john = new Person("John", 130);
            Console.WriteLine("Objekt wurde erstellt!");
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Person alex = new Person("Alex", -2);
            Console.WriteLine("Objekt wurde erstellt!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Person max = new Person("Max", 0);
            Console.WriteLine("Objekt wurde erstellt!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        {
            Person mix = new Person("Mix", 120);
            Console.WriteLine("Objekt wurde erstellt!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        try
        { 
            Person six = new Person("Six", 50);
            Console.WriteLine("Objekt wurde erstellt!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

