using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ErrorsFactory : MessageFactory
    {
        public override AbstractEvents MakeNewMessage()
        {
            return new Error();
        }
    }
}
