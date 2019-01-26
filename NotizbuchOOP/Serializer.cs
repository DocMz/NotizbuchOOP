using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotizbuchOOP.Notizbuch.Notizen;
using System.ComponentModel;
using System.IO;
using Newtonsoft.Json;

namespace NotizbuchOOP
{
    class Serializer
    {
        public string path = (Directory.GetCurrentDirectory() + "\\ListsJsonMz.txt");
        public string pathArt = (Directory.GetCurrentDirectory() + "\\ArtikelJsonMz.txt");

        public JsonSerializerSettings settings = new JsonSerializerSettings();
        public void save(BindingList<Notizbuch.Notizbuch> notizbuch)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.TypeNameHandling = TypeNameHandling.All;

            //File.Create(path);
            StreamWriter sw = new StreamWriter(path);
            sw.AutoFlush = true;
            JsonWriter writer = new JsonTextWriter(sw);
            {
                serializer.Serialize(writer, notizbuch);
            }
        }
        public BindingList<Notizbuch.Notizbuch> load()
        {
            settings.TypeNameHandling = TypeNameHandling.All;
            if(File.Exists(path))
            {
                try
                {
                    object obj = JsonConvert.DeserializeObject(File.ReadAllText(path), settings);
                }
                catch
                {
                    return null;
                }
                return (BindingList<Notizbuch.Notizbuch>)JsonConvert.DeserializeObject(File.ReadAllText(path), settings);
            }
            return null;
        }
        public void saveArtikel(ArtikelContainer artikelContainer)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.TypeNameHandling = TypeNameHandling.All;

            //File.Create(path);
            StreamWriter sw = new StreamWriter(pathArt);
            sw.AutoFlush = true;
            JsonWriter writer = new JsonTextWriter(sw);
            {
                serializer.Serialize(writer, artikelContainer);
            }
        }
        public ArtikelContainer loadArtikel()
        {
            settings.TypeNameHandling = TypeNameHandling.All;
            if (File.Exists(pathArt))
            {
                try
                {
                    object obj = JsonConvert.DeserializeObject(File.ReadAllText(pathArt), settings);
                }
                catch
                {
                    return null;
                }
                return (ArtikelContainer)JsonConvert.DeserializeObject(File.ReadAllText(pathArt), settings);
            }
            return null;
        }
    }
}
