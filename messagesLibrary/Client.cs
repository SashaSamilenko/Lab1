using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messagesLibrary
{  
    public enum typeOfFile
    {
        txt,
        xml
    }
    public class Client
    {
        static public MessageFactory Create(typeOfFile type)
        {
            switch(type)
            {
                case typeOfFile.txt: return new txtMessagesFactory();
                case typeOfFile.xml: return new xmlMessagesFactory();
                default: throw new System.Exception("Please, input again all parametrs, especially typeOfFile in one from formats: txt or xml!");
            }
        }
    }
}
