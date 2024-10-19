namespace btvn
{
    partial class b1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupDeparturePoint;
        private System.Windows.Forms.RadioButton radioHanoi;
        private System.Windows.Forms.RadioButton radioHCMC;
        private System.Windows.Forms.RadioButton radioHaiPhong;
        private System.Windows.Forms.GroupBox groupDestination;
        private System.Windows.Forms.RadioButton radioHalong;
        private System.Windows.Forms.RadioButton radioVungTau;
        private System.Windows.Forms.RadioButton radioDaNang;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupDeparturePoint = new System.Windows.Forms.GroupBox();
            this.radioHanoi = new System.Windows.Forms.RadioButton();
            this.radioHCMC = new System.Windows.Forms.RadioButton();
            this.radioHaiPhong = new System.Windows.Forms.RadioButton();
            this.groupDestination = new System.Windows.Forms.GroupBox();
            this.radioHalong = new System.Windows.Forms.RadioButton();
            this.radioVungTau = new System.Windows.Forms.RadioButton();
            this.radioDaNang = new System.Windows.Forms.RadioButton();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupDeparturePoint.SuspendLayout();
            this.groupDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(150, 22);
            this.txtCustomerName.TabIndex = 0;
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(120, 70);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(150, 22);
            this.dateTimePickerDOB.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 110);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(150, 22);
            this.txtAddress.TabIndex = 2;
            // 
            // groupDeparturePoint
            // 
            this.groupDeparturePoint.Controls.Add(this.radioHanoi);
            this.groupDeparturePoint.Controls.Add(this.radioHCMC);
            this.groupDeparturePoint.Controls.Add(this.radioHaiPhong);
            this.groupDeparturePoint.Location = new System.Drawing.Point(30, 150);
            this.groupDeparturePoint.Name = "groupDeparturePoint";
            this.groupDeparturePoint.Size = new System.Drawing.Size(240, 100);
            this.groupDeparturePoint.TabIndex = 3;
            this.groupDeparturePoint.TabStop = false;
            this.groupDeparturePoint.Text = "Điểm xuất phát";
            // 
            // radioHanoi
            // 
            this.radioHanoi.AutoSize = true;
            this.radioHanoi.Location = new System.Drawing.Point(10, 30);
            this.radioHanoi.Name = "radioHanoi";
            this.radioHanoi.Size = new System.Drawing.Size(70, 20);
            this.radioHanoi.TabIndex = 0;
            this.radioHanoi.TabStop = true;
            this.radioHanoi.Text = "Hà Nội";
            this.radioHanoi.UseVisualStyleBackColor = true;
            // 
            // radioHCMC
            // 
            this.radioHCMC.AutoSize = true;
            this.radioHCMC.Location = new System.Drawing.Point(10, 60);
            this.radioHCMC.Name = "radioHCMC";
            this.radioHCMC.Size = new System.Drawing.Size(76, 20);
            this.radioHCMC.TabIndex = 1;
            this.radioHCMC.TabStop = true;
            this.radioHCMC.Text = "TPHCM";
            this.radioHCMC.UseVisualStyleBackColor = true;
            // 
            // radioHaiPhong
            // 
            this.radioHaiPhong.AutoSize = true;
            this.radioHaiPhong.Location = new System.Drawing.Point(130, 30);
            this.radioHaiPhong.Name = "radioHaiPhong";
            this.radioHaiPhong.Size = new System.Drawing.Size(91, 20);
            this.radioHaiPhong.TabIndex = 2;
            this.radioHaiPhong.TabStop = true;
            this.radioHaiPhong.Text = "Hải Phòng";
            this.radioHaiPhong.UseVisualStyleBackColor = true;
            // 
            // groupDestination
            // 
            this.groupDestination.Controls.Add(this.radioHalong);
            this.groupDestination.Controls.Add(this.radioVungTau);
            this.groupDestination.Controls.Add(this.radioDaNang);
            this.groupDestination.Location = new System.Drawing.Point(30, 270);
            this.groupDestination.Name = "groupDestination";
            this.groupDestination.Size = new System.Drawing.Size(240, 100);
            this.groupDestination.TabIndex = 4;
            this.groupDestination.TabStop = false;
            this.groupDestination.Text = "Điểm đến";
            // 
            // radioHalong
            // 
            this.radioHalong.AutoSize = true;
            this.radioHalong.Location = new System.Drawing.Point(10, 30);
            this.radioHalong.Name = "radioHalong";
            this.radioHalong.Size = new System.Drawing.Size(79, 20);
            this.radioHalong.TabIndex = 0;
            this.radioHalong.TabStop = true;
            this.radioHalong.Text = "Hạ Long";
            this.radioHalong.UseVisualStyleBackColor = true;
            // 
            // radioVungTau
            // 
            this.radioVungTau.AutoSize = true;
            this.radioVungTau.Location = new System.Drawing.Point(10, 60);
            this.radioVungTau.Name = "radioVungTau";
            this.radioVungTau.Size = new System.Drawing.Size(86, 20);
            this.radioVungTau.TabIndex = 1;
            this.radioVungTau.TabStop = true;
            this.radioVungTau.Text = "Vũng Tàu";
            this.radioVungTau.UseVisualStyleBackColor = true;
            // 
            // radioDaNang
            // 
            this.radioDaNang.AutoSize = true;
            this.radioDaNang.Location = new System.Drawing.Point(130, 30);
            this.radioDaNang.Name = "radioDaNang";
            this.radioDaNang.Size = new System.Drawing.Size(81, 20);
            this.radioDaNang.TabIndex = 2;
            this.radioDaNang.TabStop = true;
            this.radioDaNang.Text = "Đà Nẵng";
            this.radioDaNang.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(30, 390);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerStartDate.TabIndex = 5;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(150, 390);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerEndDate.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(30, 430);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 30);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Nhập";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 430);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(300, 30);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.Size = new System.Drawing.Size(250, 400);
            this.richTextBoxInfo.TabIndex = 10;
            this.richTextBoxInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Khach hang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "ngay sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "dia chi";
            // 
            // b1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.groupDestination);
            this.Controls.Add(this.groupDeparturePoint);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "b1";
            this.Text = "Công ty du lịch ABC";
            this.groupDeparturePoint.ResumeLayout(false);
            this.groupDeparturePoint.PerformLayout();
            this.groupDestination.ResumeLayout(false);
            this.groupDestination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

