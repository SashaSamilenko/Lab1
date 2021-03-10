using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messagesLibrary
{
    public class xmlMessagesFactory : MessageFactory
    {
         override public void Add(myMessage message)
        {
            xmlFile myXML = new xmlFile();
            message.Time=DateTime.Now.ToString();
            myXML.output(message);
        }
    }
    public class txtMessagesFactory:MessageFactory
    {
        override public void Add(myMessage message)
        {
            txtFile myTXT = new txtFile();
            message.Time = DateTime.Now.ToString();
            myTXT.output(message);
        }
    }
}
