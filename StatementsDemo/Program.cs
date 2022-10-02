using StatementsDemo;


Employee emp;

static void WelcomeAliens()
{
    Console.WriteLine("Enter your Name");
    string name=Console.ReadLine();
    Console.WriteLine("Hello {0} !. Welcome to Planet Earth",name);

}

static float CalculateGainPercentage(float priceOfOldScooter,float repairAmount,float sellingPrice)
{
    float percentage = sellingPrice / (sellingPrice - (priceOfOldScooter + repairAmount)* 100);
    return percentage;
}

int i = 10;

float f = i;//implicitly

float l = f;


Console.WriteLine(f);

int j =(int) f;//explicitly
Console.WriteLine(j);

