using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab1
{
    class InOutFile
    {
        static public string[] Input()
        {
            string[] lines = File.ReadAllLines("Log.txt");
            return lines;
        }
        static public void Output(string level, string from, string time, string text) 
        {
            string[] lines = Input();
            string allText = level + " / " + from + " / " + time + " / " + text;
            if (lines.Length == 10)
            {
                for (int i = 0; i < lines.Length; i++)
                {
                    if (i != lines.Length - 1)
                    {
                        lines[i] = lines[i + 1];
                    }
                    else
                    {
                        lines[i] = allText;
                    }
                }
                allText = "";
                foreach (string item in lines)
                {
                    allText += item + '\n';
                }
                File.WriteAllText("Log.txt", allText);
            }
            else
            {
                string new_text = allText;
                allText = "";
                foreach (string item in lines)
                {
                    allText += item + '\n';
                }
                allText += new_text;
                File.WriteAllText("Log.txt", allText);
            }
        }
    }
}
