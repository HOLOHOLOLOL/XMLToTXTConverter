using System;
using System.IO;
using System.Xml;

namespace XMLToTXTConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFileName = "test.xml"; // имя файла XML, который нужно конвертировать в TXT файл 

            XmlDocument doc = new XmlDocument(); // создаем объект XmlDocument (для работы с XML-файлом)

            doc.Load(xmlFileName); // загружаем xml-документ

            string txtFileName = Path.ChangeExtension(xmlFileName, ".txt"); // создаем имя txt-файла

            StreamWriter writer = new StreamWriter(txtFileName); // создаем StreamWriter (для записи данных)

            foreach (XmlNode node in doc.DocumentElement) // проходимся foreach-ом по всем узлам xml-документa
            {   // node - указывает, что foreach-ом нужно "вытянуть" (или "выдрать") - Node'ы  

                writer.WriteLine("{0}: {1}", node.Name, node.InnerText); // node.Name - Name Node'a; node.InnerText - Text Node'a   

            }   // writer - WriteLine() - "zapisyvaet stroku v fail"  

            writer.Close(); // zakryvaem StreamWriter  

        }
    }
}