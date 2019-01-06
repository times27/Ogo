using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace CourseWork
{
    public class LibraryStorage
    {
        public LibraryStorage()
        {
            Library = this.LoadLibrary();
            id = "1";
        }
        public string id;

        List<WordStorage> Library { get; set; }
        XmlSerializer formatter = new XmlSerializer(typeof(List<WordStorage>));

        public void SaveLibrary(List<WordStorage> library)
        {
            using (var xmlWriter = XmlWriter.Create("librarys.xml"))
            {
                formatter.Serialize(xmlWriter, library);
                xmlWriter.Close();
            }
        }

        public List<WordStorage> LoadLibrary()
        {
            using (var xmlReader = XmlReader.Create("librarys.xml"))
            {
                Library = (List<WordStorage>)formatter.Deserialize(xmlReader);
                xmlReader.Close();
            }
            return Library;
        }

        public List<WordStorage> AddLibrary(WordStorage wordStorage)
        {
            Library.Add(wordStorage);
            return Library;
        }
    }
}
