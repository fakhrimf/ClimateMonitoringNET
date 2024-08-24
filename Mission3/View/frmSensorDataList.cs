using Mission3.Business;
using System;
using System.Windows.Forms;

namespace Mission3.View
{
    public partial class frmSensorDataList : Form
    {
        private SensorMonitoringBiz sensorMonitoringBuz;

        public frmSensorDataList()
        {
            InitializeComponent();
        }

        private void btnShowInsideTempRange_Click(object sender, EventArgs e)
        {
            //TODO
            //[Ekspresi Lambda]
            //d => d.Temperature >= (double)numFromTemp.Value && d.Temperature <= (double)numToTemp.Value

            // Menggunakan ekspresi lambda untuk memfilter data berdasarkan rentang suhu
            var filteredData = sensorMonitoringBuz.GetSensorData(
                d => d.Temperature >= (double)numFromTemp.Value && d.Temperature <= (double)numToTemp.Value);

            // Menampilkan hasil di DataGridView atau komponen UI lainnya
            dgvDevice.DataSource = filteredData;
        }

    private void btnShowOutsideTempRange_Click(object sender, EventArgs e)
        {
            //TODO
            // Menggunakan ekspresi lambda untuk memfilter data yang berada di luar rentang suhu
            var filteredData = sensorMonitoringBuz.GetSensorData(
                d => d.Temperature < (double)numFromTemp.Value || d.Temperature > (double)numToTemp.Value);

            // Menampilkan hasil di DataGridView atau komponen UI lainnya
            dgvDevice.DataSource = filteredData;
        }

        private void btnShowInsideHumidityRange_Click(object sender, EventArgs e)
        {
            //TODO
            // Menggunakan ekspresi lambda untuk memfilter data berdasarkan rentang kelembapan
            var filteredData = sensorMonitoringBuz.GetSensorData(
                d => d.Humidity >= (double)numFromHumidity.Value && d.Humidity <= (double)numToHumidity.Value);

            // Menampilkan hasil di DataGridView atau komponen UI lainnya
            dgvDevice.DataSource = filteredData;
        }

        private void btnShowOutsideHumidityRange_Click(object sender, EventArgs e)
        {
            //TODO
            // Menggunakan ekspresi lambda untuk memfilter data yang berada di luar rentang kelembapan
            var filteredData = sensorMonitoringBuz.GetSensorData(
                d => d.Humidity < (double)numFromHumidity.Value || d.Humidity > (double)numToHumidity.Value);

            // Menampilkan hasil di DataGridView atau komponen UI lainnya
            dgvDevice.DataSource = filteredData;
        }

        private void frmSensorDataList_Load(object sender, EventArgs e)
        {
            sensorMonitoringBuz = SensorMonitoringBiz.GetInstance();
            dgvDevice.AutoGenerateColumns = false;
        }
    }
}
