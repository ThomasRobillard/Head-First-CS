using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        int myInt = 10;
        byte myByte = (byte)myInt;
        double myDouble = (double)myByte;
        //bool myBool = (bool)myDouble;
        string myString = "false";
        //myBool = (bool)myString;
        //myString = (string)myInt;
        myString = myInt.ToString();
        //myBool = (bool)myByte;
        //myByte = (byte)myBool;
        short myShort = (short)myInt;
        char myChar = 'x';
        //myString = (string)myChar;
        long myLong = (long)myInt;
        decimal myDecimal = (decimal)myLong;
        myString = myString + myInt + myByte + myDouble + myChar;
        Console.WriteLine(myString);

    }
    public int MyMethod(bool add3)
    {
        int value = 12;

        if (add3)
            value += 3;
        else
            value -= 2;
        return value;
    }
}