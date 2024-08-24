namespace SensorDevice
{
    partial class frmMain
    {
        /// <summary>
        /// Ini adalah variabel desainer yang diperlukan.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Bereskan semua sumber daya yang digunakan.
        /// </summary>
        /// <param name="disposing">Jika sumber daya yang dikelola harus dihapus, maka true, jika tidak, maka false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kode yang dihasilkan oleh Windows Form Designer

        /// <summary>
        /// Metode ini diperlukan untuk dukungan desainer.
        /// Jangan ubah konten metode ini dengan editor kode.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numDeviceId = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tmrSensing = new System.Windows.Forms.Timer(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(14, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kelembapan saat ini";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTemperature.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTemperature.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTemperature.Location = new System.Drawing.Point(134, 139);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(66, 49);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHumidity
            // 
            this.lblHumidity.BackColor = System.Drawing.Color.AliceBlue;
            this.lblHumidity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHumidity.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHumidity.Location = new System.Drawing.Point(400, 139);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(67, 49);
            this.lblHumidity.TabIndex = 3;
            this.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Honeydew;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(273, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 49);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kelembapan saat ini";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numDeviceId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.txtPortNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(451, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi koneksi";
            // 
            // numDeviceId
            // 
            this.numDeviceId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numDeviceId.Location = new System.Drawing.Point(112, 53);
            this.numDeviceId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDeviceId.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDeviceId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDeviceId.Name = "numDeviceId";
            this.numDeviceId.Size = new System.Drawing.Size(77, 26);
            this.numDeviceId.TabIndex = 11;
            this.numDeviceId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID perangkat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(364, 23);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(82, 60);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Konek";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPortNo
            // 
            this.txtPortNo.Location = new System.Drawing.Point(312, 23);
            this.txtPortNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Size = new System.Drawing.Size(45, 22);
            this.txtPortNo.TabIndex = 8;
            this.txtPortNo.Text = "9999";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(207, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nomor port";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(112, 23);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(76, 22);
            this.txtServerIP.TabIndex = 6;
            this.txtServerIP.Text = "127.0.0.1";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(21, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alamat server";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(202, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "derajat";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(471, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 49);
            this.label7.TabIndex = 6;
            this.label7.Text = "%";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrSensing
            // 
            this.tmrSensing.Enabled = true;
            this.tmrSensing.Interval = 1000;
            this.tmrSensing.Tick += new System.EventHandler(this.tmrSensing_Tick);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Black;
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMessage.ForeColor = System.Drawing.Color.Yellow;
            this.lblMessage.Location = new System.Drawing.Point(-1, 236);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(526, 27);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 259);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Perangkat sensor suhu dan kelembaban";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDeviceId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtPortNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDeviceId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer tmrSensing;
        private System.Windows.Forms.Label lblMessage;
    }
}

