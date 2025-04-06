using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace GridView___prograowanie_wizualne_3
{
    [Serializable]
    public class Person
    {
     
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        // Konstruktor

        public Person()
        {
        }
        public Person( int id, string firstName, string lastName, int age, string position)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
          
        }
        // Metoda do serializacji do XML
        public void SerializeToXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (TextWriter writer = new StreamWriter(fileName))
            {
                serializer.Serialize(writer, this);
            }
            Console.WriteLine("Obiekt został zserializowany do pliku XML.");
        }
        // Metoda do deserializacji z XML
        public static Person DeserializeFromXML(string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Person));
            using (TextReader reader = new StreamReader(fileName))
            {
                Person person = (Person)serializer.Deserialize(reader);
                Console.WriteLine("Obiekt został odczytany z pliku XML.");
                return person;
            }
        }
        // Metoda do wyświetlania informacji o osobie
        public void DisplayInfo()
        {
            Console.WriteLine("Imię: " + FirstName);
            Console.WriteLine("Nazwisko: " + LastName);
            Console.WriteLine("Wiek: " + Age);
        }







}


}