using System.Text;
using RandomPassword.Classes;

const string letters="abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
const string numbers="0123456789";
const string symbol="~!@#$%^&*";
string Yourletters="";
bool @continue=true;
while (@continue)
{
    try
    {
    Console.WriteLine("How many letters should be in the password? (Maximum 8)(Minimum 4)");
    byte count = Convert.ToByte(Console.ReadLine());
    if (count<4||count>8)
    {
     Console.WriteLine("Lenght is not Okey. Try Again!");
     continue;
    }
    Console.WriteLine("Make it from your list of letters? (y/n)");
    string UseYourletters =Convert.ToString(Console.ReadLine()??"");
    UseYourletters= UseYourletters.ToLower();
    if (UseYourletters =="y")
    {
        Console.WriteLine("Write the list of letters stuck together(Minimum 8).ex => @sd256aD");
        Yourletters =Convert.ToString(Console.ReadLine()??"").Trim();
        if (Yourletters.Length<8)
        {
            Console.WriteLine("The Lenght Of letters is not Okey. Try Again!");
               continue;
        }
        Console.WriteLine(Randomstring.GetRandomString(count,Yourletters));
    }else{
        Console.WriteLine("Use Numbers in it? (y/n)");
        string UseNumber = Convert.ToString(Console.ReadLine()??"");
        UseNumber = UseNumber.ToLower();
        Console.WriteLine("Use Symbol in it? (y/n)");
        string UseSymbol = Convert.ToString(Console.ReadLine()??"");
        UseSymbol =  UseSymbol.ToLower();
        if ( UseNumber=="y"&& UseSymbol=="y")
        {
        Console.WriteLine(Randomstring.GetRandomString(count,letters,numbers,symbol));
        }else if (UseNumber=="y")
        {
            Console.WriteLine(Randomstring.GetRandomString(count,letters,numbers));
        }else if(UseSymbol=="y")
        {
            Console.WriteLine(Randomstring.GetRandomString(count,letters,symbol));
        }else{
         Console.WriteLine(Randomstring.GetRandomString(count,letters));
        }
        }
        Console.WriteLine("You need another one? (y/n)");
        string another =Convert.ToString(Console.ReadLine()??"");
        another= another.ToLower();
        if (another=="y")
        {
            @continue=true;
        }else
        {
            @continue=false;
        } 
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error Massage is {e.Message}");
          @continue=true;
        } 
}

