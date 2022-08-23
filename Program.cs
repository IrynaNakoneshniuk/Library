using System.IO;
using System.Xml;
using static System.Console;

namespace SaveInXML
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            try
            {
                var userJohn = new User() { Name = "John", Email = "John@john.com" };
                SerializerXML.SerializeObject<User>(@"C:\Users\ZbooK\source\repos\SaveInXML\MyFile.xml", userJohn);
                User userJohnReloaded = SerializerXML.DeSerializeObject<User>(@"C:\Users\ZbooK\source\repos\SaveInXML\MyFile.xml");
                Console.WriteLine(userJohnReloaded.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
          
        }
    }
    
}