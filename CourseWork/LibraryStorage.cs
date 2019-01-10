using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace CourseWork
{
    class LibraryStorage
    {
        public LibraryStorage()
        {
            Library = this.LoadLibrary();
        }
        public List<SectionStorage> Library { get; set; }
        XmlSerializer formatter = new XmlSerializer(typeof(List<SectionStorage>));

        public void SaveLibrary(List<SectionStorage> library)
        {
            using (var xmlWriter = XmlWriter.Create("librarys.xml"))
            {
                formatter.Serialize(xmlWriter, library);
                xmlWriter.Close();
            }
        }

        public List<SectionStorage> LoadLibrary()
        {
            using (var xmlReader = XmlReader.Create("librarys.xml"))
            {
                Library = (List<SectionStorage>)formatter.Deserialize(xmlReader);
                xmlReader.Close();
            }
            return Library;
        }

        public List<SectionStorage> AddLibrary(SectionStorage sectionStorage)
        {
            Library.Add(sectionStorage);
            return Library;
        }
        public List<SectionStorage> DeleteLibrary(string checkId)
        {
            Library.Remove(Library.Find(u=>u.id==checkId));
            this.SaveLibrary(Library);
            return Library;
        }
        public List<SectionStorage> EditLibrary(SectionStorage oldSectionStorage, SectionStorage newSectionStorage)
        {
            Library[Library.FindIndex(u => u == oldSectionStorage)] = newSectionStorage;
            this.SaveLibrary(Library);
            return Library;
        }
        public SectionStorage SearchLibrary(string checkId)
        {
            if (Library.Find((u) => u.id == checkId) == null)
            {
                SectionStorage searchLibrary = new SectionStorage();
                searchLibrary.id = checkId;
                Library.Add(searchLibrary);
                this.SaveLibrary(Library);
                return searchLibrary;
            }
                return Library[Library.FindIndex((u)=>u.id==checkId)];
            
        }
    }
}
