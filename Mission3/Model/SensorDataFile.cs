using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Mission3.Model
{
    public class SensorDataFile : IDataSource<SensorData>
    {
        private readonly string filePath = "SensorRecord.txt";
        public List<SensorData> Load()
        {
            //TODO
            
            // 1. Baca string JSON yang disimpan dalam file “SensorRecord.txt” di folder yang sama.
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                // 2. Kembalikan string ke objek List<SensorData> menggunakan metode kelas JsonConvert.
                List<SensorData> sensorDataList = JsonConvert.DeserializeObject<List<SensorData>>(jsonString);

                // 3. Jika hasil yang dikembalikan bukan null, List dikembalikan. Jika null, objek List<SensorData> kosong dibuat dan dikembalikan.
                return sensorDataList ?? new List<SensorData>();
            }
            else
            {
                // Jika file tidak ada, kembalikan List<SensorData> kosong.
                return new List<SensorData>();
            }
        }

        public void Save(List<SensorData> list)
        {
            //TODO
            
            // 1. Konversikan list yang diterima sebagai parameter menjadi string JSON menggunakan metode kelas JsonConvert.
            string jsonString = JsonConvert.SerializeObject(list, Formatting.Indented);

            // 2. Tulis string menggunakan file “SensorRecord.txt” di folder yang sama.
            File.WriteAllText(filePath, jsonString);
        }

        public Task SaveAsync(List<SensorData> list)
        {
            //TODO
            //1. Kode untuk memanggil metode Save() yang ditulis di atas secara asinkron menggunakan metode Task.Factory.StartNew() 
            //   Tulis kodenya.
            return Task.Factory.StartNew(() => Save(list));
        }
    }
}
