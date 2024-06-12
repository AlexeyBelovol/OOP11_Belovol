namespace lab11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBoxModel = new TextBox();
            textBoxYear = new TextBox();
            textBoxMileage = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBoxStatus = new TextBox();
            buttonAddCar = new Button();
            buttonAddDriver = new Button();
            textBoxAssignedCarID = new TextBox();
            textBoxPhoneNumber = new TextBox();
            label4 = new Label();
            label6 = new Label();
            textBoxLicenseNumber = new TextBox();
            textBoxName = new TextBox();
            label9 = new Label();
            label10 = new Label();
            dataGridViewCars = new DataGridView();
            dataGridViewDrivers = new DataGridView();
            textBoxSearchCriterion = new TextBox();
            buttonSearchCar = new Button();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(22, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Додавання автомобілю";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(233, 25);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 1;
            label2.Text = "Додавання водія";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 56);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Модель";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 117);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 4;
            label5.Text = "Рік";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(43, 74);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 6;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(43, 135);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(100, 23);
            textBoxYear.TabIndex = 7;
            // 
            // textBoxMileage
            // 
            textBoxMileage.Location = new Point(43, 192);
            textBoxMileage.Name = "textBoxMileage";
            textBoxMileage.Size = new Size(100, 23);
            textBoxMileage.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(72, 235);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 9;
            label7.Text = "Статус";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(43, 174);
            label8.Name = "label8";
            label8.Size = new Size(100, 15);
            label8.TabIndex = 8;
            label8.Text = "Пробіг (в милях)";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Location = new Point(43, 253);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.Size = new Size(100, 23);
            textBoxStatus.TabIndex = 11;
            // 
            // buttonAddCar
            // 
            buttonAddCar.Location = new Point(43, 323);
            buttonAddCar.Name = "buttonAddCar";
            buttonAddCar.Size = new Size(100, 75);
            buttonAddCar.TabIndex = 12;
            buttonAddCar.Text = "Додати автомобіль";
            buttonAddCar.UseVisualStyleBackColor = true;
            buttonAddCar.Click += buttonAddCar_Click;
            // 
            // buttonAddDriver
            // 
            buttonAddDriver.Location = new Point(233, 323);
            buttonAddDriver.Name = "buttonAddDriver";
            buttonAddDriver.Size = new Size(100, 75);
            buttonAddDriver.TabIndex = 21;
            buttonAddDriver.Text = "Додати водія";
            buttonAddDriver.UseVisualStyleBackColor = true;
            buttonAddDriver.Click += buttonAddDriver_Click;
            // 
            // textBoxAssignedCarID
            // 
            textBoxAssignedCarID.Location = new Point(233, 253);
            textBoxAssignedCarID.Name = "textBoxAssignedCarID";
            textBoxAssignedCarID.Size = new Size(100, 23);
            textBoxAssignedCarID.TabIndex = 20;
            // 
            // textBoxPhoneNumber
            // 
            textBoxPhoneNumber.Location = new Point(233, 192);
            textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            textBoxPhoneNumber.Size = new Size(100, 23);
            textBoxPhoneNumber.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(239, 235);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 18;
            label4.Text = "ID автомобілю";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(233, 174);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 17;
            label6.Text = "Номер телефону";
            // 
            // textBoxLicenseNumber
            // 
            textBoxLicenseNumber.Location = new Point(233, 135);
            textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            textBoxLicenseNumber.Size = new Size(100, 23);
            textBoxLicenseNumber.TabIndex = 16;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(233, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(239, 117);
            label9.Name = "label9";
            label9.Size = new Size(89, 15);
            label9.TabIndex = 14;
            label9.Text = "Номер ліцензії";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(267, 56);
            label10.Name = "label10";
            label10.Size = new Size(28, 15);
            label10.TabIndex = 13;
            label10.Text = "Ім'я";
            // 
            // dataGridViewCars
            // 
            dataGridViewCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCars.Location = new Point(415, 25);
            dataGridViewCars.Name = "dataGridViewCars";
            dataGridViewCars.Size = new Size(329, 373);
            dataGridViewCars.TabIndex = 22;
            // 
            // dataGridViewDrivers
            // 
            dataGridViewDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDrivers.Location = new Point(819, 25);
            dataGridViewDrivers.Name = "dataGridViewDrivers";
            dataGridViewDrivers.Size = new Size(329, 373);
            dataGridViewDrivers.TabIndex = 23;
            // 
            // textBoxSearchCriterion
            // 
            textBoxSearchCriterion.Location = new Point(708, 468);
            textBoxSearchCriterion.Name = "textBoxSearchCriterion";
            textBoxSearchCriterion.Size = new Size(155, 23);
            textBoxSearchCriterion.TabIndex = 24;
            // 
            // buttonSearchCar
            // 
            buttonSearchCar.Location = new Point(901, 441);
            buttonSearchCar.Name = "buttonSearchCar";
            buttonSearchCar.Size = new Size(231, 77);
            buttonSearchCar.TabIndex = 25;
            buttonSearchCar.Text = "Пошук";
            buttonSearchCar.UseVisualStyleBackColor = true;
            buttonSearchCar.Click += buttonSearchCar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.Location = new Point(488, 472);
            label11.Name = "label11";
            label11.Size = new Size(206, 15);
            label11.TabIndex = 26;
            label11.Text = "Введіть в це поле критерії пошуку";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 543);
            Controls.Add(label11);
            Controls.Add(buttonSearchCar);
            Controls.Add(textBoxSearchCriterion);
            Controls.Add(dataGridViewDrivers);
            Controls.Add(dataGridViewCars);
            Controls.Add(buttonAddDriver);
            Controls.Add(textBoxAssignedCarID);
            Controls.Add(textBoxPhoneNumber);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(textBoxLicenseNumber);
            Controls.Add(textBoxName);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(buttonAddCar);
            Controls.Add(textBoxStatus);
            Controls.Add(textBoxMileage);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxModel);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label label1;
        public Label label2;
        private Label label3;
        private Label label5;
        private TextBox textBoxModel;
        private TextBox textBoxYear;
        private TextBox textBoxMileage;
        private Label label7;
        private Label label8;
        private TextBox textBoxStatus;
        private Button buttonAddCar;
        private Button buttonAddDriver;
        private TextBox textBoxAssignedCarID;
        private TextBox textBoxPhoneNumber;
        private Label label4;
        private Label label6;
        private TextBox textBoxLicenseNumber;
        private TextBox textBoxName;
        private Label label9;
        private Label label10;
        private DataGridView dataGridViewCars;
        private DataGridView dataGridViewDrivers;
        private TextBox textBoxSearchCriterion;
        private Button buttonSearchCar;
        private Label label11;
    }
}
