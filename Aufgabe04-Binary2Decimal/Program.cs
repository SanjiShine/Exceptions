namespace Aufgabe04_Binary2Decimal;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Geben Sie eine Binärezahl ein: ");
            string? userinput = Console.ReadLine();
            Console.WriteLine(Bin2Dec(userinput));
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }

    static int Bin2Dec(string binaryString)
    {
       for(int i = 0; i < binaryString.Length; i++)
        {
            char c = binaryString[i];

            if(c != '0' && c != '1')
            {
                throw new Exception("Not a binary number");
            }
        }

        int decimalValue = 0;
        int baseValue = 1;

        for (int i = binaryString.Length - 1; i >= 0; i--)
        {
            if (binaryString[i] == '1')
                decimalValue += baseValue;

            baseValue *= 2;
        }

        return decimalValue;
    }
}

