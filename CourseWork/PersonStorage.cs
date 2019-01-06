using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace CourseWork
{
    public class PersonStorage
    { 
        public PersonStorage()
        {
            persons = this.LoadPersons();
        }
        List<Person> persons = new List<Person>();
        XmlSerializer formatter = new XmlSerializer(typeof(List<Person>));
        
        public void SavePersons(List<Person> persons)
        {
            using (var xmlWriter = XmlWriter.Create("persons.xml"))
            {
                formatter.Serialize(xmlWriter, persons);
                xmlWriter.Close();
            }
        }

        public List<Person> LoadPersons()
        {
            using (var xmlReader = XmlReader.Create("persons.xml"))
            {
                persons = (List<Person>)formatter.Deserialize(xmlReader);
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
            persons.Remove(person);
            return persons;
        }

        public List<Person> EditPerson(Person oldPerson, Person newPerson)
        {
            persons[persons.FindIndex(p => p == oldPerson)] = newPerson;
            return persons;
        }
        public bool PersonInStorage(Person person)
        {
            if (persons.Contains(person))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LoginInStorage(string loginPerson)
        {
           if ((persons.Find((u)=>u.Login == loginPerson))!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
