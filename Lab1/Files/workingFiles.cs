using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Lab1
{
    abstract class workingFiles
    {
        public virtual string[] input() { return null; }
        public virtual void output(myMessage message) { }
    }
    class txtFile:workingFiles
    {
        public override string[] input()
        {
            string[] lines = File.ReadAllLines("Log.txt");
            return lines;
        }
        public override void output(myMessage message) 
        {
            string[] lines = input();
            string allText = message.Level + " / " + message.From + " / " + message.Time + " / " + message.Text;
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
    class xmlFile:workingFiles
    {
        public override string[] input()
        {
            string[] lines = File.ReadAllLines("Log.txt");
            return lines;
        }
        public override void output(myMessage message)
        {
            checkOver("XMLFile1.xml");
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFile1.xml");
            //Create root of our XMLdocument
            XmlElement xRoot = xDoc.DocumentElement;
            //Create new child node of our root!
            XmlElement First_element = xDoc.CreateElement("message");
            //Create inner elements
            XmlElement _level = xDoc.CreateElement("level");
            XmlElement _from = xDoc.CreateElement("from");
            XmlElement _time = xDoc.CreateElement("time");
            XmlElement _text = xDoc.CreateElement("text");
            //Create text with is included in elements
            XmlText levelText = xDoc.CreateTextNode(message.Level);
            XmlText fromText = xDoc.CreateTextNode(message.From);
            XmlText timeText = xDoc.CreateTextNode(message.Time);
            XmlText Text = xDoc.CreateTextNode(message.Text);

            //Add text in the elements
            _level.AppendChild(levelText);
            _from.AppendChild(fromText);
            _time.AppendChild(timeText);
            _text.AppendChild(Text);

            //Add insiding elements in outsiding
            First_element.AppendChild(_level);
            First_element.AppendChild(_from);
            First_element.AppendChild(_time);
            First_element.AppendChild(_text);

            //Add new message in our root
            xRoot.AppendChild(First_element);
            //Save document
            xDoc.Save("XMLFile1.xml");
        }
        public void checkOver(string nameFile)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(nameFile);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList nodes = xDoc.GetElementsByTagName("message");
            while(nodes.Count>=10)
            {
                XmlNode firstNode = xRoot.SelectSingleNode("message");//xRoot.FirstChild;
                xRoot.RemoveChild(firstNode);
            }
            xDoc.Save(nameFile);
        }
    }
}
