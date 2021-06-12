using System.IO;
using System.Xml;
using System;

namespace LabelTrans
{
    public class Trans
    {
        public string Txttrans(XmlDocument xml, XmlElement tasks, string txtpath, int type)
        {
            XmlElement image = xml.CreateElement("image");
            image.SetAttribute("file", "images/" + Path.GetFileNameWithoutExtension(txtpath) + ".jpg");
            int count = 0;
            int small = 0;
            using (StreamReader sr = new StreamReader(txtpath))
            {
                while (!sr.EndOfStream)
                {
                    string box = sr.ReadLine();
                    string[] temp = box.Split(',');
                    if (type == 999)
                    {
                        if (Convert.ToInt32(temp[2]) * Convert.ToInt32(temp[3]) <= 400)
                        {
                            small++;
                        }
                        else
                        {
                            XmlElement boxml = xml.CreateElement("box");
                            boxml.SetAttribute("top", temp[1]);
                            boxml.SetAttribute("left", temp[0]);
                            boxml.SetAttribute("width", temp[2]);
                            boxml.SetAttribute("height", temp[3]);
                            image.AppendChild(boxml);
                            count++;
                        }
                    }
                    else if (temp[5] == type.ToString())
                    {
                        if (Convert.ToInt32(temp[2]) * Convert.ToInt32(temp[3]) <= 400)
                        {
                            small++;
                        }
                        else
                        {
                            XmlElement boxml = xml.CreateElement("box");
                            boxml.SetAttribute("top", temp[1]);
                            boxml.SetAttribute("left", temp[0]);
                            boxml.SetAttribute("width", temp[2]);
                            boxml.SetAttribute("height", temp[3]);
                            image.AppendChild(boxml);
                            count++;
                        }
                    }
                }
            }
            if (count > 0)
            {
                tasks.AppendChild(image);
                if (small > 0)
                {
                    return "small:" + small.ToString();
                }
                return "ok";
            }
            return "zero";
        }
    }
}
