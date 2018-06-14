using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace GreenHorn.Essentials
{
    public class Serialization
    {
        public string SerializeJsonFrom<T>(T objecToSerialize)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            using (StreamReader streamReader = new StreamReader(memoryStream, Encoding.ASCII, true))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
                dataContractJsonSerializer.WriteObject(memoryStream, objecToSerialize);
                memoryStream.Position = 0;
                return streamReader.ReadToEnd();
            }
        }

        public static T DeserializeJsonOptimized<T>(string jsonString) where T : class, new()
        {
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(jsonString)))
            {
                DataContractJsonSerializer dataContractJsonSerializer = new DataContractJsonSerializer(typeof(T));
                return dataContractJsonSerializer.ReadObject(memoryStream) as T;
            }
        }
    }
}
