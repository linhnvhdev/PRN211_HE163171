using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;
using SerializationExample1;

Console.WriteLine("***** Fun with Object Serialization *****\n");
// Make a JamesBondCar and set state.

JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
{
    PropertyNameCaseInsensitive = true,
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
    IncludeFields = true,
    WriteIndented = true,
    NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
};

JamesBondCar jbc = new()
{
    CanFly = true,
    CanSubmerge = false,
    TheRadio = new()
    {
        StationPresets = new() { 89.3, 105.1, 97.1 },
        HasTweeters = true
    }
};
Person p = new()
{
    FirstName = "James",
    IsAlive = true
};

// Demo serialization using xml
//ObjectSerializationUsingXML();

// Demo serialization using json
ObjectSerializationUsingJSON(options);
Console.ReadLine();

void ObjectSerializationUsingJSON(JsonSerializerOptions options)
{
    SaveAsJsonFormat(jbc, "CarData.json");
    Console.WriteLine("=> Saved car in JSON format!");
    SaveAsJsonFormat(p, "PersonData.json");
    Console.WriteLine("=> Saved person in JSON format!");
    SaveListOfCarsAsJson(options, "CarCollection.json");
    JamesBondCar savedJsonCar = ReadAsJsonFormat<JamesBondCar>(options, "CarData.json");
    Console.WriteLine("Read Car: {0}", savedJsonCar.ToString());
    List<JamesBondCar> savedJsonCars = ReadAsJsonFormat<List<JamesBondCar>>(options,
    "CarCollection.json");
    foreach(JamesBondCar car in savedJsonCars)
    {
        Console.WriteLine("Car: {0}", car.CanFly);
    }
}


void ObjectSerializationUsingXML()
{

    SaveAsXmlFormat(jbc, "CarData.xml");
    Console.WriteLine("=> Saved car in XML format!");
    SaveAsXmlFormat(p, "PersonData.xml");
    Console.WriteLine("=> Saved person in XML format!");
    SaveListOfCarsAsXml();

    JamesBondCar savedCar = ReadAsXmlFormat<JamesBondCar>("CarData.xml");
    Console.WriteLine("Original Car: {0}", savedCar.ToString());
    Console.WriteLine("Read Car: {0}", savedCar.ToString());
    List<JamesBondCar> savedCars = ReadAsXmlFormat<List<JamesBondCar>>("CarCollection.xml");
    foreach (var car in savedCars)
    {
        Console.WriteLine(car);
    }
}

static void SaveAsXmlFormat<T>(T objGraph, string fileName)
{
    //Must declare type in the constructor of the XmlSerializer
    XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
    using (Stream fStream = new FileStream(fileName,
    FileMode.Create, FileAccess.Write, FileShare.None))
    {
        xmlFormat.Serialize(fStream, objGraph);
    }
}

static void SaveListOfCarsAsXml()
{
    //Now persist a List<T> of JamesBondCars.
    List<JamesBondCar> myCars = new()
     {
     new JamesBondCar{CanFly = true, CanSubmerge = true},
     new JamesBondCar{CanFly = true, CanSubmerge = false},
     new JamesBondCar{CanFly = false, CanSubmerge = true},
     new JamesBondCar{CanFly = false, CanSubmerge = false},
     };
    using (Stream fStream = new FileStream("CarCollection.xml",FileMode.Create, FileAccess.Write, FileShare.None))
    {
        XmlSerializer xmlFormat = new XmlSerializer(typeof(List<JamesBondCar>));
        xmlFormat.Serialize(fStream, myCars);
    }
    Console.WriteLine("=> Saved list of cars!");
}

static T ReadAsXmlFormat<T>(string fileName)
{
    // Create a typed instance of the XmlSerializer
    XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
    using (Stream fStream = new FileStream(fileName, FileMode.Open))
    {
        T obj = default;
        obj = (T)xmlFormat.Deserialize(fStream);
        return obj;
    }
}

static void SaveAsJsonFormat<T>(T objGraph, string fileName)
{
    JsonSerializerOptions options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        IncludeFields = true,
        WriteIndented = true,
        NumberHandling = JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString
    };
    File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(objGraph,options));
}

static void SaveListOfCarsAsJson(JsonSerializerOptions options, string fileName)
{
    //Now persist a List<T> of JamesBondCars.
    List<JamesBondCar> myCars = new()
    {
        new JamesBondCar { CanFly = true, CanSubmerge = true },
         new JamesBondCar { CanFly = true, CanSubmerge = false },
         new JamesBondCar { CanFly = false, CanSubmerge = true },
         new JamesBondCar { CanFly = false, CanSubmerge = false },
     };
    File.WriteAllText(fileName, System.Text.Json.JsonSerializer.Serialize(myCars, options));
    Console.WriteLine("=> Saved list of cars!");
}

static T ReadAsJsonFormat<T>(JsonSerializerOptions options, string fileName) =>
 System.Text.Json.JsonSerializer.Deserialize<T>(File.ReadAllText(fileName), options);