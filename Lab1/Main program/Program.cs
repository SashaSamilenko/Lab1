using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            myMessage message = new myMessage() { From = "main_program", Level = "Normal message", Text = "That is alright!" };
            xmlFile myXML = new xmlFile();
            myXML.output(message);



            /*myMessage message1 = new myMessage() { From = "main_program", Level = "Normal message", Text = "That is alright!" };
            myMessage message2 = new myMessage() { From = "main_program", Level = "Erro", Text = "No! Stop do it!" };
            myMessage message3 = new myMessage() { From = "main_program", Level = "Remark", Text = "Okey, but in our opinion you should check your Log list!" };
            myMessage message4 = new myMessage() { From = "main_program", Level = "Erro", Text = "404!!!" };
            myXML.output(message1);
            myXML.output(message2);
            myXML.output(message3);
            myXML.output(message4);*/




            txtFile txtMessage = new txtFile();
            txtMessage.output(message);
            Console.WriteLine("Thank you for using our program!\nGood luck!\nClick on any button to close the window!");
            Console.ReadKey();
        }
    }
}
