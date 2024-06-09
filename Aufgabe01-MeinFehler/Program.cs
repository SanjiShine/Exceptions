namespace Aufgabe01_MeinFehler;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("*******************************");
            Methode1();
            Console.WriteLine("*******************************");
        }
        catch (Exception)
        {
            Console.WriteLine("Hier ist noch etwas schief gegangen");
        }
    }

    static void Methode1()
    {
        try
        {
            Methode2();
        }
        catch (MeinFehler e)
        {
            Console.WriteLine($"Message: {e.Message}\nFehlercode:{e.Fehlercode}");

        } catch(SystemException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            // Nicht zu tun
        }
    }

    static void Methode2()
    {
        try
        {
            Methode3();
        }
        catch (MeinFehler e)
        {
            Console.WriteLine($"Message: {e.Message}\nFehlercode:{e.Fehlercode}");
            e.Fehlercode = 24;
            throw e;

        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
            throw e; 
        }

        finally
        {
            //Nicht zu tun
        }
    }

    static void Methode3()
    {
        throw new MeinFehler("Error in method 3",  123);
    }


}

