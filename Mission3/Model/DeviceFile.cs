using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Mission3.Model
{
    public class DeviceFile : IDataSource<Device>
    {
        private readonly string filePath = "Device.txt";
        public List<Device> Load()
        {
            //TODO
            //1. Baca string JSON yang disimpan dalam file “Device.txt” di folder yang sama.
            //2. Kembalikan string ke objek List<Device> menggunakan metode kelas JsonConvert.
            //3. Jika hasil yang dikembalikan bukan null, List dikembalikan. Jika null, objek List<Device> kosong dibuat dan dikembalikan.
            // 1. Baca string JSON yang disimpan dalam file “Device.txt” di folder yang sama.
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);

                // 2. Kembalikan string ke objek List<Device> menggunakan metode kelas JsonConvert.
                List<Device> devices = JsonConvert.DeserializeObject<List<Device>>(jsonString);

                // 3. Jika hasil yang dikembalikan bukan null, List dikembalikan. Jika null, objek List<Device> kosong dibuat dan dikembalikan.
                return devices ?? new List<Device>();
            }
            else
            {
                // Jika file tidak ada, kembalikan List<Device> kosong.
                return new List<Device>();
            }
        }

        public void Save(List<Device> list)
        {
            //TODO
            // 1. Konversikan list yang diterima sebagai parameter menjadi string JSON menggunakan metode kelas JsonConvert.
            string jsonString = JsonConvert.SerializeObject(list, Formatting.Indented);

            // 2. Tulis string menggunakan file “Device.txt” di folder yang sama.
            File.WriteAllText(filePath, jsonString);
        }

        public Task SaveAsync(List<Device> list)
        {
            //TODO
            //Kode untuk memanggil metode Save() yang ditulis di atas secara asinkron menggunakan metode Task.Factory.StartNew().  
            //Tulis kodenya.
            return Task.Factory.StartNew(() => Save(list));
        }
    }
}
