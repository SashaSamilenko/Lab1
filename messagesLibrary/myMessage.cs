using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messagesLibrary
{
    public enum levelMessage
    {
        error,
        remark,
        normal
    }
    public class myMessage
    {
        public levelMessage Level { get; set; }
        public string From { get; set; }
        public string Text { get; set; }
        public string Time{ get; set; }
        public string To { get; set; }
    }
}
