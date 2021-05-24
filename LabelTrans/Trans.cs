using System.IO;
using System.Xml;

namespace LabelTrans
{
    public class Trans
    {
        public void Txttrans(XmlDocument xml, XmlElement tasks, string txtpath)
        {
            XmlElement image = xml.CreateElement("image");
            image.SetAttribute("file", "image/" + Path.GetFileNameWithoutExtension(txtpath) + ".jpg");
            tasks.AppendChild(image);
            using (StreamReader sr = new StreamReader(txtpath))
            {
                while (!sr.EndOfStream)
                {
                    string box = sr.ReadLine();
                    string[] temp = box.Split(',');
                    if (temp[5] == "4")
                    {
                        XmlElement boxml = xml.CreateElement("box");
                        boxml.SetAttribute("top", temp[1]);
                        boxml.SetAttribute("left", temp[0]);
                        boxml.SetAttribute("width", temp[2]);
                        boxml.SetAttribute("height", temp[3]);
                        image.AppendChild(boxml);
                    }
                }
            }
        }
    }
}
