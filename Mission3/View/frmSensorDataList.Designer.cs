namespace Mission3.View
{
    partial class frmSensorDataList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowOutsideTempRange = new System.Windows.Forms.Button();
            this.btnShowInsideTempRange = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numToTemp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numFromTemp = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowOutsideHumidityRange = new System.Windows.Forms.Button();
            this.btnShowInsideHumidityRange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numToHumidity = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numFromHumidity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDevice = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromTemp)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowOutsideTempRange);
            this.groupBox1.Controls.Add(this.btnShowInsideTempRange);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numToTemp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numFromTemp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(591, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kondisi pencarian 1";
            // 
            // btnShowOutsideTempRange
            // 
            this.btnShowOutsideTempRange.Location = new System.Drawing.Point(499, 21);
            this.btnShowOutsideTempRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowOutsideTempRange.Name = "btnShowOutsideTempRange";
            this.btnShowOutsideTempRange.Size = new System.Drawing.Size(80, 40);
            this.btnShowOutsideTempRange.TabIndex = 6;
            this.btnShowOutsideTempRange.Text = "Luar kisaran";
            this.btnShowOutsideTempRange.UseVisualStyleBackColor = true;
            this.btnShowOutsideTempRange.Click += new System.EventHandler(this.btnShowOutsideTempRange_Click);
            // 
            // btnShowInsideTempRange
            // 
            this.btnShowInsideTempRange.Location = new System.Drawing.Point(398, 21);
            this.btnShowInsideTempRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowInsideTempRange.Name = "btnShowInsideTempRange";
            this.btnShowInsideTempRange.Size = new System.Drawing.Size(80, 40);
            this.btnShowInsideTempRange.TabIndex = 5;
            this.btnShowInsideTempRange.Text = "Dalam kisaran";
            this.btnShowInsideTempRange.UseVisualStyleBackColor = true;
            this.btnShowInsideTempRange.Click += new System.EventHandler(this.btnShowInsideTempRange_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "derajat";
            // 
            // numToTemp
            // 
            this.numToTemp.Location = new System.Drawing.Point(248, 29);
            this.numToTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numToTemp.Name = "numToTemp";
            this.numToTemp.Size = new System.Drawing.Size(73, 22);
            this.numToTemp.TabIndex = 3;
            this.numToTemp.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "derajat ~ ";
            // 
            // numFromTemp
            // 
            this.numFromTemp.Location = new System.Drawing.Point(99, 28);
            this.numFromTemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFromTemp.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numFromTemp.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numFromTemp.Name = "numFromTemp";
            this.numFromTemp.Size = new System.Drawing.Size(73, 22);
            this.numFromTemp.TabIndex = 1;
            this.numFromTemp.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kisaran suhu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowOutsideHumidityRange);
            this.groupBox2.Controls.Add(this.btnShowInsideHumidityRange);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numToHumidity);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numFromHumidity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(14, 101);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(592, 75);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kondisi pencarian 2";
            // 
            // btnShowOutsideHumidityRange
            // 
            this.btnShowOutsideHumidityRange.Location = new System.Drawing.Point(500, 16);
            this.btnShowOutsideHumidityRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowOutsideHumidityRange.Name = "btnShowOutsideHumidityRange";
            this.btnShowOutsideHumidityRange.Size = new System.Drawing.Size(80, 41);
            this.btnShowOutsideHumidityRange.TabIndex = 6;
            this.btnShowOutsideHumidityRange.Text = "Luar kisaran";
            this.btnShowOutsideHumidityRange.UseVisualStyleBackColor = true;
            this.btnShowOutsideHumidityRange.Click += new System.EventHandler(this.btnShowOutsideHumidityRange_Click);
            // 
            // btnShowInsideHumidityRange
            // 
            this.btnShowInsideHumidityRange.Location = new System.Drawing.Point(399, 16);
            this.btnShowInsideHumidityRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowInsideHumidityRange.Name = "btnShowInsideHumidityRange";
            this.btnShowInsideHumidityRange.Size = new System.Drawing.Size(80, 41);
            this.btnShowInsideHumidityRange.TabIndex = 5;
            this.btnShowInsideHumidityRange.Text = "Dalam kisaran";
            this.btnShowInsideHumidityRange.UseVisualStyleBackColor = true;
            this.btnShowInsideHumidityRange.Click += new System.EventHandler(this.btnShowInsideHumidityRange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            // 
            // numToHumidity
            // 
            this.numToHumidity.Location = new System.Drawing.Point(249, 23);
            this.numToHumidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numToHumidity.Name = "numToHumidity";
            this.numToHumidity.Size = new System.Drawing.Size(73, 22);
            this.numToHumidity.TabIndex = 3;
            this.numToHumidity.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "% ~ ";
            // 
            // numFromHumidity
            // 
            this.numFromHumidity.Location = new System.Drawing.Point(100, 23);
            this.numFromHumidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numFromHumidity.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numFromHumidity.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numFromHumidity.Name = "numFromHumidity";
            this.numFromHumidity.Size = new System.Drawing.Size(73, 22);
            this.numFromHumidity.TabIndex = 1;
            this.numFromHumidity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 55);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kisaran kelembapan";
            // 
            // dgvDevice
            // 
            this.dgvDevice.AllowUserToAddRows = false;
            this.dgvDevice.AllowUserToDeleteRows = false;
            this.dgvDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDevice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDevice.Location = new System.Drawing.Point(16, 187);
            this.dgvDevice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDevice.MultiSelect = false;
            this.dgvDevice.Name = "dgvDevice";
            this.dgvDevice.ReadOnly = true;
            this.dgvDevice.RowHeadersWidth = 51;
            this.dgvDevice.RowTemplate.Height = 23;
            this.dgvDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDevice.Size = new System.Drawing.Size(590, 477);
            this.dgvDevice.TabIndex = 7;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LogDate";
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Tanggal pencatatan";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "DeviceId";
            this.Column1.HeaderText = "ID perangkat sensor";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Temperature";
            dataGridViewCellStyle3.Format = "N1";
            dataGridViewCellStyle3.NullValue = null;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Suhu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Humidity";
            dataGridViewCellStyle4.Format = "N1";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.FillWeight = 80F;
            this.Column3.HeaderText = "Kelembapan";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 80;
            // 
            // frmSensorDataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 675);
            this.Controls.Add(this.dgvDevice);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSensorDataList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daftar informasi sensor yang dikumpulkan";
            this.Load += new System.EventHandler(this.frmSensorDataList_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromTemp)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numToHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFromHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numToTemp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numFromTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowInsideTempRange;
        private System.Windows.Forms.Button btnShowOutsideTempRange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowOutsideHumidityRange;
        private System.Windows.Forms.Button btnShowInsideHumidityRange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numToHumidity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numFromHumidity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}