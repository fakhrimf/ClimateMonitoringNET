using Mission3.Model;
using System;
using System.Collections.Generic;

namespace Mission3.Business
{
    public class SensorMonitoringBiz
    {
        private List<Device> deviceList;
        private Dictionary<int, Device> deviceMap;
        private List<SensorData> sensorDataList;
        private IDataSource<SensorData> sensorDataFile;
        private IDataSource<Device> deviceFile;

        //TODO
        //1. Tambahkan konstruktor SensorMonitoringBiz() {} } pribadi untuk mencegah orang luar membuat objek dengan kelas ini.
        //2. Menambahkan anggota private static SensorMonitoringBiz sensorMonitoringBiz;
        //3. Tambahkan metode public static SensorMonitoringBizGetInstance(),
        //   Jika sensorMonitoringBiz bernilai null, buat objek SensorMonitoringBiz baru dan tetapkan ke sensorMonitoringBiz
        //   Mengembalikan nilai sensorMonitoringBiz.

        // 1. Tambahkan konstruktor pribadi untuk mencegah instansiasi dari luar kelas.
        private SensorMonitoringBiz()
        {
            deviceList = new List<Device>();
            deviceMap = new Dictionary<int, Device>();
            sensorDataList = new List<SensorData>();
        }

        // 2. Menambahkan anggota private static SensorMonitoringBiz.
        private static SensorMonitoringBiz sensorMonitoringBiz;

        // 3. Tambahkan metode public static GetInstance().
        public static SensorMonitoringBiz GetInstance()
        {
            if (sensorMonitoringBiz == null)
            {
                sensorMonitoringBiz = new SensorMonitoringBiz();
            }
            return sensorMonitoringBiz;
        }

        public void SetSensorDataFile(IDataSource<SensorData> dataSource)
        {
            //TODO
            //Copy nilai dataSource yang diterima sebagai parameter ke variabel anggota sensorDataFile.
            sensorDataFile = dataSource;
        }

        public void SetDeviceFile(IDataSource<Device> dataSource)
        {
            //TODO
            //Copy nilai dataSource yang diterima sebagai parameter ke variabel anggota deviceFile.
            deviceFile = dataSource;
        }

        public void LoadData()
        {
            //TODO
            
            // 1. Jika sensorDataFile bukan null, panggil sensorDataFile.Load() dan simpan hasilnya di sensorDataList.
            if (sensorDataFile != null)
            {
                sensorDataList = sensorDataFile.Load();
            }

            // 2. Jika deviceFile bukan null, panggil deviceFile.Load() dan simpan hasilnya di deviceList.
            if (deviceFile != null)
            {
                deviceList = deviceFile.Load();
                deviceMap = PutToDeviceMap(deviceList);
            }
        }

        public Dictionary<int, Device> PutToDeviceMap(List<Device> deviceList)
        {
            //TODO
            //1. var deviceMap = new Dictionary<int, Device>();
            //2. Di loop foreach, masukkan Device di parameter DeviceList ke dalam DeviceMap
            //   Saat ini, Device.Id di objek Device dengan nilai int digunakan sebagai kunci Dictionary.
            //3. Mengembalikan deviceMap.

            // 1. Buat dictionary baru.
            var deviceMap = new Dictionary<int, Device>();

            // 2. Masukkan setiap device ke dalam dictionary dengan Device.Id sebagai kunci.
            foreach (var device in deviceList)
            {
                deviceMap[device.DeviceId] = device;
            }

            // 3. Kembalikan dictionary.
            return deviceMap;
        }

        public List<SensorData> GetSensorData(Func<SensorData, Boolean> filter)
        {
            //TODO
            
            // 1. Buat list baru untuk menyimpan hasil filter.
            var list = new List<SensorData>();

            // 2. Iterasi melalui sensorDataList dan filter data menggunakan delegasi filter.
            foreach (var sensorData in sensorDataList)
            {
                if (filter(sensorData))
                {
                    list.Add(sensorData);
                }
            }

            // 3. Kembalikan list yang sudah difilter.
            return list;

        }

        public void AddDevice(Device device)
        {
            //TODO
            //1. Menambahkan nilai parameter device ke DeviceList.
            //2. Tambahkan device ke koleksi deviceMap dengan device.DeviceId sebagai kunci.
            //3. Gunakan metode deviceFile.Save() untuk menyimpan objek List<Device> yang ditunjuk oleh deviceList ke sebuah file.

            // 1. Tambahkan device ke deviceList.
            deviceList.Add(device);

            // 2. Tambahkan device ke deviceMap dengan DeviceId sebagai kunci.
            deviceMap[device.DeviceId] = device;

            // 3. Simpan deviceList ke file menggunakan deviceFile.Save().
            deviceFile.Save(deviceList);
        }

        public void AddSensorData(SensorData sensorData)
        {
            //TODO
            //Tambahkan sensorData ke dalam sensorDataList.
            sensorDataList.Add(sensorData);
        }

        public List<Device> GetDeviceList()
        {
            //TODO
            //Mengembalikan koleksi List<Device> deviceList.
            return deviceList;
        }
        public Dictionary<int, Device> GetDeviceMap()
        {
            //TODO
            //return deviceMap;
            return deviceMap;
        }

        public async void SaveToDataSource()
        {
            //TODO
                        
            //1. Panggil metode sensorDataFile.SaveAsync() untuk menyimpan sensorDataList secara asinkron.
            if (sensorDataFile != null)
            {
                await sensorDataFile.SaveAsync(sensorDataList);
            }

            //2. Panggil metode deviceFile.SaveAsync() untuk menyimpan deviceList secara asinkron.
            if (deviceFile != null)
            {
                await deviceFile.SaveAsync(deviceList);
            }
        }
    }
}
