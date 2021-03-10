using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messagesLibrary
{
    public abstract class MessageFactory
    {
        public virtual void Add(myMessage message) { }
    }
}
