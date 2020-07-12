using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace VfioUsbClient.Profiles
{
    [Serializable]
    [XmlRoot("VfioUsbClient")]
    [XmlInclude(typeof(Profile))]
    public class ProfileManager
    {
        [XmlArray("Profiles")]
        [XmlArrayItem("Profile", typeof(Profile))]
        public List<Profile> Profiles { get; set; } = new List<Profile>();

        [NonSerialized]
        private static readonly string SavePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData), "VfioUsbClient.xml");

        private ProfileManager()
        {
        }

        public void AddProfile(Profile profile)
        {
            Profiles.Add(profile);
            Save();
        }

        public Profile GetProfileByName(string name)
        {
            foreach (var profile in  Profiles)
            {
                if (profile.Name == name)
                    return profile;
            }

            return null;
        }

        public void RemoveProfile(Profile profile)
        {
            Profiles.Remove(profile);
            Save();
        }

        public void Save()
        {
            var serializer = new XmlSerializer(typeof(ProfileManager), new[] { typeof(Profile), typeof(UsbDevice) });
            using (var sw = new StringWriter())
            {
                using (var writer = new XmlTextWriter(sw) { Formatting = Formatting.Indented })
                {
                    serializer.Serialize(writer, this);
                    File.WriteAllText(SavePath, sw.ToString());
                }
            }
        }

        public static ProfileManager Load()
        {
            if (!File.Exists(SavePath))
                return new ProfileManager();

            var serializer = new XmlSerializer(typeof(ProfileManager), new[] {typeof(Profile), typeof(UsbDevice)});
            var reader = new StreamReader(SavePath);
            var manager = (ProfileManager)serializer.Deserialize(reader);
            reader.Close();

            return manager;
        }
    }
}
