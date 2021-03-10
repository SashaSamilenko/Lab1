using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace messagesLibrary
{
    public abstract class workingFiles
    {
        public virtual string[] input(string nameOfFile) { return null; }
        public virtual void output(myMessage message) { }
    }
    public class txtFile:workingFiles
    {
        public override string[] input(string nameOfFile)
        {
            return File.ReadAllLines(nameOfFile);
        }
        public override void output(myMessage message) 
        {
            string newText = checkOver(message.To) + message.Level.ToString() + " / " + message.From + " / " + message.Time + " / " + message.Text;
            File.WriteAllText(message.To, newText);
        }
        public string checkOver(string nameFile)
        {
            string[] lines = input(nameFile);
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
                        lines[i] = null;
                    }
                }
            }
            string allText = "";
            foreach (string item in lines)
            {
                if (item != null)
                {
                    allText += item + '\n';
                }
            }
            return allText;
        }
    }
    public class xmlFile:workingFiles
    {
        public override void output(myMessage message)
        {
            checkOver(message.To);
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(message.To);
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
            XmlText levelText = xDoc.CreateTextNode(message.Level.ToString());
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
            xDoc.Save(message.To);
        }
        public void checkOver(string nameFile)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(nameFile);
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList nodes = xDoc.GetElementsByTagName("message");
            while(nodes.Count>=10)
            {
                XmlNode firstNode = xRoot.SelectSingleNode("message");
                xRoot.RemoveChild(firstNode);
            }
            xDoc.Save(nameFile);
        }
    }
}
