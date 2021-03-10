using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using messagesLibrary;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            MessageFactory magazineXML=Client.Create(typeOfFile.xml);
            List<myMessage> txtMessages = new List<myMessage>();
            txtMessages.Add(new myMessage() { From = "main_program", Level = levelMessage.normal, Text = "Excuse me,I am glad to see you!", To = "Log.xml" });
            txtMessages.Add(new myMessage() { From = "main_program", Level = levelMessage.error, Text = "404", To = "Log.xml" });
            txtMessages.Add(new myMessage() { From = "main_program", Level = levelMessage.error, Text = "Do not input null!", To = "Log.xml" });
            magazineXML.Add(txtMessages[0]);
            magazineXML.Add(txtMessages[1]);
            magazineXML.Add(txtMessages[2]);

            MessageFactory magazineTXT = Client.Create(typeOfFile.txt);
            List<myMessage> xmlMessages = new List<myMessage>();
            xmlMessages.Add(new myMessage() { From = "main_program", Level = levelMessage.normal, Text = "Thank you for using my program! Good luck!", To = "Log.txt" });
            xmlMessages.Add(new myMessage() { From = "main_program", Level = levelMessage.remark, Text = "You should use version 8.0 of C#", To = "Log.txt" });
            xmlMessages.Add(new myMessage() { From = "main_program", Level = levelMessage.remark, Text = "Program will be quicklier if you use version 8.0 of C#", To = "Log.txt" });
            magazineTXT.Add(xmlMessages[0]);
            magazineTXT.Add(xmlMessages[1]);
            magazineTXT.Add(xmlMessages[2]);

            Console.WriteLine("Click on any button to close the window!");
            Console.ReadKey();
        }
    }
}
