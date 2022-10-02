////// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//////Console.WriteLine("Enter the Firstname");
//////string firstname = Console.ReadLine();
//////Console.WriteLine("Enter the lastname ");
//////string lastname=Console.ReadLine();

//////string name=firstname+" "+lastname;

////////Concatnting the strings
//////Console.WriteLine("Name : "+name.Trim());

//////name = name.TrimStart();
//////if (name.Equals("Dhivya Rajendren"))
//////{
//////    Console.WriteLine("Yes the name AVailable");
//////}
//////else
//////{
//////    Console.WriteLine("No Name available");
//////}

//////Split a string into a string array

//////Console.WriteLine("Enter the address in Given Format (Door No, Street Name, City, State)");
//////string address = Console.ReadLine();

//////string[] details = new string[address.Split(',').Length];

//////string[] addressDetials = address.Split(',');

//////for (int i = 0; i < addressDetials.Length; i++)
//////{

//////    Console.WriteLine(addressDetials[i].Trim());
//////}


////string s = "This is an apple; Apple keeps the doctor way; Red apples are good for health; "; 


////Console.WriteLine( s.Substring(0,6) );
////Console.WriteLine(s.Replace(';','.'));

////string fruits = "apples";
////char[] cArray = fruits.ToCharArray();

////foreach (var item in cArray)
////{
////    if (char.IsWhiteSpace(item))
////    {
////        Console.WriteLine("Yes White space present");
////        break;
////    }

////}
////string name = "Dhivya";
////bool isValidName = true;
////cArray = name.ToCharArray();

////foreach (var item in cArray)
////{
////    if(char.IsDigit(item))
////    {
////        isValidName = false;
////        break;
////    }
////}


////Console.WriteLine();
////Console.WriteLine(isValidName?"Yes valid Name":"Not"+ " valid name");



////Console.WriteLine(   name.ToUpper());
////Console.WriteLine();
////Console.WriteLine(name.ToLower());

////Console.WriteLine("Enter the UserName");
////string userName = "Dhivya@cloudkampus.com";

////if (userName.Equals("dhivya@cloudkampus.com",StringComparison.OrdinalIgnoreCase))
////{
////    Console.WriteLine("UserName  avaiable");
////}
////else
////{
////    Console.WriteLine("UserName not available");
////}

////Console.WriteLine("Enter the Password");
////string password=Console.ReadLine();
////Console.WriteLine("Enter to confirm the password");
////string confirmPassword=Console.ReadLine() ;

////if (password.Equals(confirmPassword))
////{
////    Console.WriteLine("Password Matched");
////}
////else
////{
////    Console.WriteLine("Password Mismatch");
////}


//string str = "This is a C# Course.Learning the Programming Fundas";
//if (str.Contains("course",StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("The Sequence course was found");
//}
//else
//{
//    Console.WriteLine("The Sequence course is not found");
//}
//Console.WriteLine();

//string[] fruits = { "Apple", "Mango", "Grapes", "Orange" };
////string s=string.Empty;
////foreach (string fruit in fruits)
////{
////  s+= fruit + ",";

////}
////s = s.TrimEnd(',');
////Console.Write(s);

//string s = string.Join(".", fruits);

//Console.WriteLine(s);
//Console.WriteLine();





string name = "Mark";
var date = DateTime.Now;




//composite formatting
Console.WriteLine("Hello {0}! Today is{1}, its{2:HH:mm} now",name,date.DayOfWeek,date);
Console.WriteLine();
//string interpolation
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, its {date:HH:mm} now");
Console.WriteLine();
int number = int.Parse(Console.ReadLine());
string result = $"The answer for Square of {number} is : {Math.Pow(number,2)}";
Console.WriteLine(result);



