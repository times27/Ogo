using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace CourseWork
{
    public class Person
    {
        public Person()
        {
            Sections = new List<Section>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public List<Section> Sections { get; set; }

       // XmlSerializer formatterSection = new XmlSerializer(typeof(List<Section>));
        XmlSerializer formatterSection = new XmlSerializer(typeof(List<Person>));

        public void SaveSections(List<Section> sections)
        {
            PersonStorage personStorage = new PersonStorage();
            personStorage.persons[personStorage.LoginSearch(Login)].Sections = sections;
            personStorage.SavePersons();
        }

        public List<Section> LoadSections()
        {
            
            PersonStorage personStorage = new PersonStorage();
            Sections = personStorage.persons[personStorage.LoginSearch(Login)].Sections;
            return Sections;
        }
        public Section AddSection()
        {
            Section section = new Section();
            if (Sections != null)
            {
                section.nameSection = "Секция " + this.Sections.Count().ToString();
            }
            else
            {
                section.nameSection = "Секция 0";
            }
            Sections.Add(section);
            SaveSections(Sections);
            return section;
        }
        public string DeleteSection(string sectionName)
        {
            Sections.Remove(Sections[Sections.FindIndex(u => u.nameSection == sectionName)]);
            SaveSections(Sections);
            return sectionName;
        }

        public Section SectionSearch(string sectionName)
        {
            return Sections[Sections.FindIndex(u => u.nameSection == sectionName)]; 
        }
    }
}
