using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class xmlMessagesFactory:MessageFactory
    {
        internal myMessage Композиция
        {
            get => default;
            set
            {
            }
        }

        internal txtFile Composition
        {
            get => default;
            set
            {
            }
        }

        static public new void Create(string from, string level, string text)
        {
            xmlFile myXML = new xmlFile();
            string dateNow = DateTime.Now.ToString();
            switch(level)
            {
                case "normal": myMessage message = new myMessage() { From = from, Level = "Normal message", Text = text,Time=dateNow }; myXML.output(message); break;
                case "error": myMessage message2 = new myMessage() { From = from, Level = "Error message", Text = text, Time = dateNow }; myXML.output(message2); break;
                case "remark": myMessage message3 = new myMessage() { From = from, Level = "Remark", Text = text, Time = dateNow }; myXML.output(message3); break;
                default: throw new System.Exception("Please, input again all parametrs, especially level in one from formats: normal, error or remark!");
            }
        }
    }
    class txtMessagesFactory:MessageFactory
    {
        internal myMessage Композиция
        {
            get => default;
            set
            {
            }
        }

        internal xmlFile Composition
        {
            get => default;
            set
            {
            }
        }

        static public new void Create(string from, string level, string text)
        {
            txtFile myTXT = new txtFile();
            string dateNow = DateTime.Now.ToString();
            switch (level)
            {
                case "normal": myMessage message = new myMessage() { From = from, Level = "Normal message", Text = text, Time = dateNow }; myTXT.output(message); break;
                case "error": myMessage message2 = new myMessage() { From = from, Level = "Error message", Text = text, Time = dateNow }; myTXT.output(message2); break;
                case "remark": myMessage message3 = new myMessage() { From = from, Level = "Remark", Text = text, Time = dateNow }; myTXT.output(message3); break;
                default: throw new System.Exception("Please, input again all parametrs, especially level in one from formats: normal, error or remark!");
            }
        }
    }
}
