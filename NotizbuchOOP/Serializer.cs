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
    /// <summary>
    /// Klasse die zu Serialisierung der Notizbuchdaten verwendet wird.
    /// </summary>
    class Serializer
    {
        public string path = (Directory.GetCurrentDirectory() + "\\ListsJsonMz.txt");
        public string pathArt = (Directory.GetCurrentDirectory() + "\\ArtikelJsonMz.txt");

        public JsonSerializerSettings settings = new JsonSerializerSettings();

        /// <summary>
        /// Funktion welche das Notizbuch in JSON Umwandelt und abspeichert.
        /// </summary>
        /// <param name="notizbuch">Übergibt der Funktion die komplette List der Notizbücher</param>
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

        /// <summary>
        /// Deserialisiert die Daten aus der JSON Datei und wandelt diese in eine BindingList um
        /// </summary>
        /// <returns>Gibt die Bindinglist zurück</returns>
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

        /// <summary>
        /// Ist gleich der save-Funktion bloß dass diese den Artikelcontainer abspeichert.
        /// </summary>
        /// <param name="artikelContainer"></param>
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

        /// <summary>
        /// Lädt den Artikelcontainer aus dem gespeicherten JSON.
        /// </summary>
        /// <returns></returns>
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
