// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


///Exception Handling 
///
try
{

    int i = int.Parse(Console.ReadLine());

    int j = 0;
    do
    {
        Console.WriteLine("Enter a value greater than 0 for division ");
       j = int.Parse(Console.ReadLine());

    } while (j == 0);

    Console.WriteLine(i/j);

    


}


catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.GetType().FullName+" : "+ex.Message);
    
}

catch (OverflowException ex)
{
    Console.WriteLine("The value given for the integer value is too high or too small");
}
catch (Exception ex)
{
    Console.WriteLine(ex.GetType().FullName + " : " + ex.Message);
}
finally
{
   // Connecting with Database - Close the connection and dispose the object  used db connection 
   //File Handling  -Close the file and dispose the object used for file handling
}

class DuplicateEmailException : Exception
{
    public DuplicateEmailException(string message):base(message)
    {

    }
}

