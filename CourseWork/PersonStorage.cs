using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace CourseWork
{
    [Serializable]
    public class PersonStorage
    { 
       public PersonStorage()
        {
            this.LoadPersons();
        }
        public List<Person> persons = new List<Person>();
        XmlSerializer formatterPersons = new XmlSerializer(typeof(List<Person>));
        XmlSerializer formatterSections = new XmlSerializer(typeof(List<Person>));

        public void SavePersons()
        {
            using (var xmlWriter = XmlWriter.Create("persons.xml"))
            {
                formatterPersons.Serialize(xmlWriter, this.persons);
                xmlWriter.Close();
            }
        }

        public List<Person> LoadPersons()
        {
            using (var xmlReader = XmlReader.Create("persons.xml"))
            {
                persons = (List<Person>)formatterPersons.Deserialize(xmlReader);
                xmlReader.Close();
            }
            return persons;
        }
        
        public List<Person> AddPerson(Person person)
        {
            persons.Add(person);
            return persons;
        }

        public List<Person> DeletePerson(Person person)
        {
            persons.Remove(persons.Find((u)=>u.Login==person.Login));
            return persons;
        }

        public List<Person> EditPerson(Person oldPerson, Person newPerson)
        {
            persons[persons.FindIndex((p) => p.Login == oldPerson.Login)] = newPerson;
            return persons;
        }
        
        public bool LoginInStorage(string loginPerson)
        {
            return (persons.Find((u) => u.Login == loginPerson)) != null;  
        }    
        public int LoginSearch(string loginPerson)
        {
            return (persons.FindIndex((u) => u.Login == loginPerson));
        }
    }
}
