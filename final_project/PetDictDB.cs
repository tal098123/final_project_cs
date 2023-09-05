﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Pets;
using System.IO;


namespace Database
{
    public static class SharedDatabase
    {
        public static Dictionary<string, Dictionary<string, List<Pet>>> Data = new Dictionary<string, Dictionary<string, List<Pet>>>();
        public static event Action OnDataChanged;
        public static int id_counter = 1;
        static SharedDatabase()
        {
            SharedDatabase.LoadFromFile();
            //SharedDatabase.Data["Dog"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Dog"]["Poodle"] = new List<Pet>();
            //SharedDatabase.Data["Dog"]["Poodle"].Add(new Poodle("George", DateTime.Now, DateTime.Now));
            //SharedDatabase.Data["Dog"]["GoldenRetriever"] = new List<Pet>();
            //SharedDatabase.Data["Dog"]["GoldenRetriever"].Add(new GoldenRetriever("Terry", DateTime.Now, DateTime.Now));
            //SharedDatabase.Data["Cat"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Cat"]["Siamese"] = new List<Pet>();
            //SharedDatabase.Data["Cat"]["Siamese"].Add(new Siamese("shimi", DateTime.Now, DateTime.Now));
            //SharedDatabase.Data["Cat"]["British"] = new List<Pet>();
            //SharedDatabase.Data["Cat"]["British"].Add(new British("Sebastian", DateTime.Now, DateTime.Now));
            //SharedDatabase.Data["Fish"] = new Dictionary<string, List<Pet>>();
            //SharedDatabase.Data["Fish"]["Goldfish"] = new List<Pet>();
            //SharedDatabase.Data["Fish"]["Goldfish"].Add(new Goldfish("Danny", DateTime.Now, DateTime.Now));
            //SharedDatabase.Data["Fish"]["Angelfish"] = new List<Pet>();
            //SharedDatabase.Data["Fish"]["Angelfish"].Add(new Angelfish("Kiki", DateTime.Now, DateTime.Now));
            //SaveToFile();
        }


        public static void DataChanged()
        {
            OnDataChanged?.Invoke();
            SaveToFile();
        }

        public static string SerializeData(object Data)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            };

            return JsonConvert.SerializeObject(Data, settings);
        }

        public static void DeserializeData(string jsonData,string id_counter_file)
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Objects
            };

            Data = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, List<Pet>>>>(jsonData, settings);
            string stringValue = File.ReadAllText(id_counter_file);
            id_counter = int.Parse(stringValue);
            DataChanged(); // Notify that the data has changed after deserialization
        }

        public static void SaveToFile()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string path_data = currentDirectory + "\\pets.json";
            string path_id_counter = currentDirectory +"\\pets_id_counter.json";
            var jsonData = SerializeData(Data);
            File.WriteAllText(path_data, jsonData);
            File.WriteAllText(path_id_counter, id_counter.ToString());
        }

        public static void LoadFromFile()
        {
            //string path = "C:\\Users\\Prisma\\source\\repos\\final_project\\final_project\\bin\\Debug\\pets.json";
            //string path_id_counter = "C:\\Users\\Prisma\\source\\repos\\final_project\\final_project\\bin\\Debug\\pets_id_counter.json";
            string currentDirectory = Directory.GetCurrentDirectory();
            string path = currentDirectory +"\\pets.json";
            string path_id_counter = currentDirectory + "\\pets_id_counter.json";

            if (!File.Exists(path))
                throw new FileNotFoundException("File not found.", path);
            if (!File.Exists(path))
                throw new FileNotFoundException("id_counter_file not found.", path_id_counter);

            var jsonData = File.ReadAllText(path);
            //var id_counter_file = File.ReadAllText(path_id_counter);
            //DeserializeData(jsonData, id_counter_file);
            DeserializeData(jsonData, path_id_counter);
        }

    }
}
