using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class myMessage
    {

        public string Level { get; set; }
        public string From { get; set; }
        public string Text { get; set; }
        public string Time{ get; set; }
        public myMessage()
        {
            //Time = DateTime.Now.ToString();
        }
    }
}
