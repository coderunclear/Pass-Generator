using System.Text;
namespace RandomPassword.Classes
{
    public class Randomstring
    {
       static StringBuilder pass = new StringBuilder();
        public static StringBuilder GetRandomString(int length, string characterSet1)
        {
            if (characterSet1 == null)
             throw new ArgumentNullException("characterSet");
            pass.Clear();
            Random random = new Random();
            for (int i = 0; i < length; i++)
            {
                pass.Append(characterSet1[random.Next(0,characterSet1.Length-1)]);
            }
            
                return(pass);
        }
    public static StringBuilder GetRandomString(int length, string characterSet1,string characterSet2)
        {
            Random random = new Random();
            pass.Clear();
            for (int i = 0; i < length; i++)
            {
                pass.Append(characterSet1[random.Next(0,characterSet1.Length-1)]);
            }
            pass[random.Next(0,pass.Length)]=Convert.ToChar(characterSet2[random.Next(0,characterSet2.Length)]);
            
                return(pass);
        }
         public static StringBuilder GetRandomString(int length, string characterSet1,string characterSet2,string characterSet3)
        {
            Random random = new Random();
            pass.Clear();
            for (int i = 0; i < length; i++)
            {
                pass.Append(characterSet1[random.Next(0,characterSet1.Length-1)]);
            }
            pass[random.Next(0,pass.Length)]=Convert.ToChar(characterSet2[random.Next(0,characterSet2.Length)]);
            pass[random.Next(0,pass.Length)]=Convert.ToChar(characterSet3[random.Next(0,characterSet3.Length)]);
                return(pass);
        }
    }
    
}