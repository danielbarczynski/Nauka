﻿using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

// With serialization you can store the state 
// of an object in a file stream, pass it to
// a remote network

namespace CSharpTutA.cs
{
    // Defines that you want to serialize this class
    [Serializable()]
    public class Animal : ISerializable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public int AnimalID { get; set; }

        public Animal() { }

        public Animal(string name = "No Name",
            double weight = 0,
            double height = 0)
        {
            Name = name;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("{0} weighs {1} lbs and is {2} inches tall",
                Name, Weight, Height);
        }

        // Serialization function (Stores Object Data in File)
        // SerializationInfo holds the key value pairs
        // StreamingContext can hold additional info
        // but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Weight", Weight);
            info.AddValue("Height", Height);
            info.AddValue("AnimalID", AnimalID);
        }

        // The deserialize function (Removes Object Data from File)
        public Animal(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Weight = (double)info.GetValue("Weight", typeof(double));
            Height = (double)info.GetValue("Height", typeof(double));
            AnimalID = (int)info.GetValue("AnimalID", typeof(int));
        }
    }

    public class MyClass
    {
        public string Name { get; set; } = "Daniel"; // changed to test in main
        public int Age { get; set; } = 23;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal bowser = new Animal("Bowser", 45, 25);

            // Serialize the object data to a file
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            // Send the object data to the file
            bf.Serialize(stream, bowser);
            stream.Close();

            // Delete the bowser data
            bowser = null;

            // Read object data from the file
            stream = File.Open("AnimalData.dat", FileMode.Open);

            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();

            Console.WriteLine("bowser 1 file");
            Console.WriteLine(bowser.ToString());
            Console.WriteLine();

            //-----------------------------------------------------------------------------------
            //XML

            // Change bowser to show changes were made
            bowser.Weight = 50;

            // XmlSerializer writes object data as XML
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"C:\Users\itsmy\bowser.xml"))
            {
                serializer.Serialize(tw, bowser);
            }

            // Delete bowser data
            bowser = null;

            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"C:\Users\itsmy\bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();
            Console.WriteLine("bowser file2");
            Console.WriteLine(bowser.ToString());
            Console.WriteLine();
            // Save a collection of Animals
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60, 30),
                new Animal("Luigi", 55, 24),
                new Animal("Peach", 40, 20)
            };

            using (Stream fs = new FileStream(@"C:\Users\itsmy\animals.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                serializer2.Serialize(fs, theAnimals);
            }

            // Delete list data
            theAnimals = null;

            // Read data from XML
            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"C:\Users\itsmy\animals.xml"))
            {
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }

            Console.WriteLine("animals list");
            foreach (Animal a in theAnimals)
            {
                Console.WriteLine(a.ToString());
            }

            //-----------------------------------------------------------------------------------

            MyClass myClass = new MyClass();
            myClass.Name = "Test";
            XmlSerializer xmlSerializer = new(typeof(MyClass)); // without typeof() not accessible

            using (StreamWriter streamWriter = new("myclass.xml"))
            {
                xmlSerializer.Serialize(streamWriter, myClass);
            }

            StreamReader streamReader = new("myclass.xml");
            object obj2 = xmlSerializer.Deserialize(streamReader);
            myClass.Name = "Test2"; // not included!!
            myClass = (MyClass)obj2;
            streamReader.Close();
            Console.WriteLine(myClass.Name.ToString());
        }
    }
}