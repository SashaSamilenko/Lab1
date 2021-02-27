using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Error: AbstractEvents
    {
        public override void Create(string from, string text)
        {
            DateTime date = DateTime.Now;
            string nowTime = date.ToString();
            InOutFile.Output("Level-errors", from, nowTime, text);
        }
    }
}
