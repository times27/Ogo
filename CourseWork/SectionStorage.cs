using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class SectionStorage
    {
       public SectionStorage()
        {
            this.Sections = new List<WordStorage>();
        }
        public string id=null; 

        public List<WordStorage> Sections { get; set; }

        public List<WordStorage> AddSection()
        {
            WordStorage wordStorage = new WordStorage();
            if (Sections != null)
            {
                wordStorage.nameSection = "Секция " + Sections.Count().ToString();
            }
            else
            {
                wordStorage.nameSection = "Секция 0";
            }
            Sections.Add(wordStorage);
            return Sections;
        }
        public List<WordStorage> DeleteSection(string nameSection)
        {
            Sections.Remove(Sections[Sections.FindIndex(u=> u.nameSection==nameSection)]);
            return Sections;
        }
        public WordStorage SearchSection(SectionStorage sectionStorage, string nameSection)
        {
            WordStorage wordStorage;
            wordStorage = Sections[Sections.FindIndex(u => u.nameSection == nameSection)];
            return wordStorage;
        }

    }
}
