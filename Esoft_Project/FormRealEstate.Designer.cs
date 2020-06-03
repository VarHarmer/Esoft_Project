﻿namespace Esoft_Project
{
    partial class FormRealEstate
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
            this.textBoxAddress_City = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_latitude = new System.Windows.Forms.TextBox();
            this.textBoxTotalArea = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Street = new System.Windows.Forms.TextBox();
            this.textBoxCoordinate_longitude = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.textBoxAddress_House = new System.Windows.Forms.TextBox();
            this.textBoxFloor = new System.Windows.Forms.TextBox();
            this.textBoxAddress_Number = new System.Windows.Forms.TextBox();
            this.textBoxTotalFloors = new System.Windows.Forms.TextBox();
            this.labelAddress_City = new System.Windows.Forms.Label();
            this.labelCoordinate_latitude = new System.Windows.Forms.Label();
            this.labelTotalArea = new System.Windows.Forms.Label();
            this.labelAddress_Street = new System.Windows.Forms.Label();
            this.labelCoordinate_longitude = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelAddress_House = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelFloor = new System.Windows.Forms.Label();
            this.labelAddress_Number = new System.Windows.Forms.Label();
            this.labelTotalFloors = new System.Windows.Forms.Label();
            this.listViewRealEstateSet_Apartment = new System.Windows.Forms.ListView();
            this.listViewRealEstateSet_House = new System.Windows.Forms.ListView();
            this.listViewRealEstateSet_Land = new System.Windows.Forms.ListView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAddress_City
            // 
            this.textBoxAddress_City.Location = new System.Drawing.Point(13, 17);
            this.textBoxAddress_City.Name = "textBoxAddress_City";
            this.textBoxAddress_City.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_City.TabIndex = 0;
            // 
            // textBoxCoordinate_latitude
            // 
            this.textBoxCoordinate_latitude.Location = new System.Drawing.Point(150, 17);
            this.textBoxCoordinate_latitude.Name = "textBoxCoordinate_latitude";
            this.textBoxCoordinate_latitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordinate_latitude.TabIndex = 1;
            // 
            // textBoxTotalArea
            // 
            this.textBoxTotalArea.Location = new System.Drawing.Point(309, 17);
            this.textBoxTotalArea.Name = "textBoxTotalArea";
            this.textBoxTotalArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalArea.TabIndex = 2;
            // 
            // textBoxAddress_Street
            // 
            this.textBoxAddress_Street.Location = new System.Drawing.Point(12, 61);
            this.textBoxAddress_Street.Name = "textBoxAddress_Street";
            this.textBoxAddress_Street.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_Street.TabIndex = 3;
            // 
            // textBoxCoordinate_longitude
            // 
            this.textBoxCoordinate_longitude.Location = new System.Drawing.Point(150, 61);
            this.textBoxCoordinate_longitude.Name = "textBoxCoordinate_longitude";
            this.textBoxCoordinate_longitude.Size = new System.Drawing.Size(100, 20);
            this.textBoxCoordinate_longitude.TabIndex = 4;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Location = new System.Drawing.Point(309, 61);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.Size = new System.Drawing.Size(100, 20);
            this.textBoxRooms.TabIndex = 5;
            // 
            // textBoxAddress_House
            // 
            this.textBoxAddress_House.Location = new System.Drawing.Point(11, 102);
            this.textBoxAddress_House.Name = "textBoxAddress_House";
            this.textBoxAddress_House.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_House.TabIndex = 6;
            // 
            // textBoxFloor
            // 
            this.textBoxFloor.Location = new System.Drawing.Point(309, 102);
            this.textBoxFloor.Name = "textBoxFloor";
            this.textBoxFloor.Size = new System.Drawing.Size(100, 20);
            this.textBoxFloor.TabIndex = 8;
            // 
            // textBoxAddress_Number
            // 
            this.textBoxAddress_Number.Location = new System.Drawing.Point(11, 143);
            this.textBoxAddress_Number.Name = "textBoxAddress_Number";
            this.textBoxAddress_Number.Size = new System.Drawing.Size(100, 20);
            this.textBoxAddress_Number.TabIndex = 9;
            // 
            // textBoxTotalFloors
            // 
            this.textBoxTotalFloors.Location = new System.Drawing.Point(309, 143);
            this.textBoxTotalFloors.Name = "textBoxTotalFloors";
            this.textBoxTotalFloors.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotalFloors.TabIndex = 10;
            this.textBoxTotalFloors.Visible = false;
            // 
            // labelAddress_City
            // 
            this.labelAddress_City.AutoSize = true;
            this.labelAddress_City.Location = new System.Drawing.Point(10, 1);
            this.labelAddress_City.Name = "labelAddress_City";
            this.labelAddress_City.Size = new System.Drawing.Size(40, 13);
            this.labelAddress_City.TabIndex = 11;
            this.labelAddress_City.Text = "Город ";
            this.labelAddress_City.Click += new System.EventHandler(this.labelAddress_City_Click);
            // 
            // labelCoordinate_latitude
            // 
            this.labelCoordinate_latitude.AutoSize = true;
            this.labelCoordinate_latitude.Location = new System.Drawing.Point(147, 1);
            this.labelCoordinate_latitude.Name = "labelCoordinate_latitude";
            this.labelCoordinate_latitude.Size = new System.Drawing.Size(49, 13);
            this.labelCoordinate_latitude.TabIndex = 12;
            this.labelCoordinate_latitude.Text = "Ширина ";
            // 
            // labelTotalArea
            // 
            this.labelTotalArea.AutoSize = true;
            this.labelTotalArea.Location = new System.Drawing.Point(306, 1);
            this.labelTotalArea.Name = "labelTotalArea";
            this.labelTotalArea.Size = new System.Drawing.Size(57, 13);
            this.labelTotalArea.TabIndex = 13;
            this.labelTotalArea.Text = "Площадь ";
            // 
            // labelAddress_Street
            // 
            this.labelAddress_Street.AutoSize = true;
            this.labelAddress_Street.Location = new System.Drawing.Point(10, 45);
            this.labelAddress_Street.Name = "labelAddress_Street";
            this.labelAddress_Street.Size = new System.Drawing.Size(42, 13);
            this.labelAddress_Street.TabIndex = 14;
            this.labelAddress_Street.Text = "Улица ";
            // 
            // labelCoordinate_longitude
            // 
            this.labelCoordinate_longitude.AutoSize = true;
            this.labelCoordinate_longitude.Location = new System.Drawing.Point(147, 45);
            this.labelCoordinate_longitude.Name = "labelCoordinate_longitude";
            this.labelCoordinate_longitude.Size = new System.Drawing.Size(53, 13);
            this.labelCoordinate_longitude.TabIndex = 15;
            this.labelCoordinate_longitude.Text = "Долгота ";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(306, 45);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(106, 13);
            this.labelRooms.TabIndex = 16;
            this.labelRooms.Text = "Количество комнат";
            // 
            // labelAddress_House
            // 
            this.labelAddress_House.AutoSize = true;
            this.labelAddress_House.Location = new System.Drawing.Point(9, 86);
            this.labelAddress_House.Name = "labelAddress_House";
            this.labelAddress_House.Size = new System.Drawing.Size(70, 13);
            this.labelAddress_House.TabIndex = 17;
            this.labelAddress_House.Text = "Номер дома";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(147, 86);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(149, 13);
            this.labelType.TabIndex = 18;
            this.labelType.Text = "Тип объекта недвижимости";
            // 
            // labelFloor
            // 
            this.labelFloor.AutoSize = true;
            this.labelFloor.Location = new System.Drawing.Point(306, 86);
            this.labelFloor.Name = "labelFloor";
            this.labelFloor.Size = new System.Drawing.Size(36, 13);
            this.labelFloor.TabIndex = 19;
            this.labelFloor.Text = "Этаж ";
            // 
            // labelAddress_Number
            // 
            this.labelAddress_Number.AutoSize = true;
            this.labelAddress_Number.Location = new System.Drawing.Point(9, 127);
            this.labelAddress_Number.Name = "labelAddress_Number";
            this.labelAddress_Number.Size = new System.Drawing.Size(93, 13);
            this.labelAddress_Number.TabIndex = 20;
            this.labelAddress_Number.Text = "Номер квартиры";
            // 
            // labelTotalFloors
            // 
            this.labelTotalFloors.AutoSize = true;
            this.labelTotalFloors.Location = new System.Drawing.Point(306, 127);
            this.labelTotalFloors.Name = "labelTotalFloors";
            this.labelTotalFloors.Size = new System.Drawing.Size(106, 13);
            this.labelTotalFloors.TabIndex = 21;
            this.labelTotalFloors.Text = "Количество этажей";
            this.labelTotalFloors.Visible = false;
            // 
            // listViewRealEstateSet_Apartment
            // 
            this.listViewRealEstateSet_Apartment.HideSelection = false;
            this.listViewRealEstateSet_Apartment.Location = new System.Drawing.Point(11, 179);
            this.listViewRealEstateSet_Apartment.MultiSelect = false;
            this.listViewRealEstateSet_Apartment.Name = "listViewRealEstateSet_Apartment";
            this.listViewRealEstateSet_Apartment.Size = new System.Drawing.Size(673, 220);
            this.listViewRealEstateSet_Apartment.TabIndex = 22;
            this.listViewRealEstateSet_Apartment.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Apartment.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Apartment.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Apartment_SelectedIndexChanged);
            // 
            // listViewRealEstateSet_House
            // 
            this.listViewRealEstateSet_House.FullRowSelect = true;
            this.listViewRealEstateSet_House.GridLines = true;
            this.listViewRealEstateSet_House.HideSelection = false;
            this.listViewRealEstateSet_House.Location = new System.Drawing.Point(12, 179);
            this.listViewRealEstateSet_House.Name = "listViewRealEstateSet_House";
            this.listViewRealEstateSet_House.Size = new System.Drawing.Size(672, 220);
            this.listViewRealEstateSet_House.TabIndex = 23;
            this.listViewRealEstateSet_House.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_House.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_House.Visible = false;
            this.listViewRealEstateSet_House.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_House_SelectedIndexChanged);
            // 
            // listViewRealEstateSet_Land
            // 
            this.listViewRealEstateSet_Land.HideSelection = false;
            this.listViewRealEstateSet_Land.Location = new System.Drawing.Point(11, 179);
            this.listViewRealEstateSet_Land.Name = "listViewRealEstateSet_Land";
            this.listViewRealEstateSet_Land.Size = new System.Drawing.Size(673, 220);
            this.listViewRealEstateSet_Land.TabIndex = 24;
            this.listViewRealEstateSet_Land.UseCompatibleStateImageBehavior = false;
            this.listViewRealEstateSet_Land.View = System.Windows.Forms.View.Details;
            this.listViewRealEstateSet_Land.Visible = false;
            this.listViewRealEstateSet_Land.SelectedIndexChanged += new System.EventHandler(this.listViewRealEstateSet_Land_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(13, 405);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 25;
            this.buttonAdd.Text = "Создать ";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click_1);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(94, 405);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 26;
            this.buttonEdit.Text = "Изменить ";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(175, 405);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 27;
            this.buttonDel.Text = "Удалить ";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click_1);
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(150, 102);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 28;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(439, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // FormRealEstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewRealEstateSet_Land);
            this.Controls.Add(this.listViewRealEstateSet_House);
            this.Controls.Add(this.listViewRealEstateSet_Apartment);
            this.Controls.Add(this.labelTotalFloors);
            this.Controls.Add(this.labelAddress_Number);
            this.Controls.Add(this.labelFloor);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelAddress_House);
            this.Controls.Add(this.labelRooms);
            this.Controls.Add(this.labelCoordinate_longitude);
            this.Controls.Add(this.labelAddress_Street);
            this.Controls.Add(this.labelTotalArea);
            this.Controls.Add(this.labelCoordinate_latitude);
            this.Controls.Add(this.labelAddress_City);
            this.Controls.Add(this.textBoxTotalFloors);
            this.Controls.Add(this.textBoxAddress_Number);
            this.Controls.Add(this.textBoxFloor);
            this.Controls.Add(this.textBoxAddress_House);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxCoordinate_longitude);
            this.Controls.Add(this.textBoxAddress_Street);
            this.Controls.Add(this.textBoxTotalArea);
            this.Controls.Add(this.textBoxCoordinate_latitude);
            this.Controls.Add(this.textBoxAddress_City);
            this.Name = "FormRealEstate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.Load += new System.EventHandler(this.FormRealEstate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress_City;
        private System.Windows.Forms.TextBox textBoxCoordinate_latitude;
        private System.Windows.Forms.TextBox textBoxTotalArea;
        private System.Windows.Forms.TextBox textBoxAddress_Street;
        private System.Windows.Forms.TextBox textBoxCoordinate_longitude;
        private System.Windows.Forms.TextBox textBoxRooms;
        private System.Windows.Forms.TextBox textBoxAddress_House;
        private System.Windows.Forms.TextBox textBoxFloor;
        private System.Windows.Forms.TextBox textBoxAddress_Number;
        private System.Windows.Forms.TextBox textBoxTotalFloors;
        private System.Windows.Forms.Label labelAddress_City;
        private System.Windows.Forms.Label labelCoordinate_latitude;
        private System.Windows.Forms.Label labelTotalArea;
        private System.Windows.Forms.Label labelAddress_Street;
        private System.Windows.Forms.Label labelCoordinate_longitude;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelAddress_House;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelFloor;
        private System.Windows.Forms.Label labelAddress_Number;
        private System.Windows.Forms.Label labelTotalFloors;
        private System.Windows.Forms.ListView listViewRealEstateSet_Apartment;
        private System.Windows.Forms.ListView listViewRealEstateSet_House;
        private System.Windows.Forms.ListView listViewRealEstateSet_Land;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}