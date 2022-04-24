
using System;

namespace CryptoBlockChainApp
{
    partial class CryptoRide
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CryptoRide));
            this.OfferTravels = new System.Windows.Forms.ListView();
            this.ColumnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MyTravels = new System.Windows.Forms.ListView();
            this.ColumnIDUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnImageUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnDateUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHourUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnLocationUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rideofferGroupBox = new System.Windows.Forms.GroupBox();
            this.bidresultLabel = new System.Windows.Forms.Label();
            this.bidButton = new System.Windows.Forms.Button();
            this.publishrideGroupBox = new System.Windows.Forms.GroupBox();
            this.publishridewarningLabel = new System.Windows.Forms.Label();
            this.moneysimbol = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.offerpublishButton = new System.Windows.Forms.Button();
            this.availableseatsComboBox = new System.Windows.Forms.ComboBox();
            this.offerseatsLabel = new System.Windows.Forms.Label();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.offerlocationLabel = new System.Windows.Forms.Label();
            this.offerdateLabel = new System.Windows.Forms.Label();
            this.publishrideLabel = new System.Windows.Forms.Label();
            this.myridesGroupBox = new System.Windows.Forms.GroupBox();
            this.unbidButton = new System.Windows.Forms.Button();
            this.profileGroupBox = new System.Windows.Forms.GroupBox();
            this.currentavatarnumLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.ethereumaddressLabel = new System.Windows.Forms.Label();
            this.ethereumaddressTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.previousavatarButton = new System.Windows.Forms.Button();
            this.nextavatarButton = new System.Windows.Forms.Button();
            this.avatarPictureBox = new System.Windows.Forms.PictureBox();
            this.rideofferGroupBox.SuspendLayout();
            this.publishrideGroupBox.SuspendLayout();
            this.myridesGroupBox.SuspendLayout();
            this.profileGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OfferTravels
            // 
            this.OfferTravels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OfferTravels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnID,
            this.ColumnImage,
            this.ColumnDate,
            this.ColumnHour,
            this.ColumnLocation,
            this.ColumnSeats,
            this.ColumnCost});
            this.OfferTravels.GridLines = true;
            this.OfferTravels.HideSelection = false;
            this.OfferTravels.Location = new System.Drawing.Point(6, 19);
            this.OfferTravels.Name = "OfferTravels";
            this.OfferTravels.Size = new System.Drawing.Size(426, 256);
            this.OfferTravels.TabIndex = 1;
            this.OfferTravels.UseCompatibleStateImageBehavior = false;
            this.OfferTravels.View = System.Windows.Forms.View.Details;
            this.OfferTravels.SelectedIndexChanged += new System.EventHandler(this.OfferTravels_SelectedIndexChanged);
            // 
            // ColumnID
            // 
            this.ColumnID.Text = "ID";
            this.ColumnID.Width = 24;
            // 
            // ColumnImage
            // 
            this.ColumnImage.Text = "Avatar";
            this.ColumnImage.Width = 80;
            // 
            // ColumnDate
            // 
            this.ColumnDate.Text = "Date";
            this.ColumnDate.Width = 64;
            // 
            // ColumnHour
            // 
            this.ColumnHour.Text = "Hour";
            // 
            // ColumnLocation
            // 
            this.ColumnLocation.Text = "Location";
            this.ColumnLocation.Width = 90;
            // 
            // ColumnSeats
            // 
            this.ColumnSeats.Text = "Seats";
            this.ColumnSeats.Width = 40;
            // 
            // ColumnCost
            // 
            this.ColumnCost.Text = "Cost";
            this.ColumnCost.Width = 72;
            // 
            // MyTravels
            // 
            this.MyTravels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnIDUser,
            this.ColumnImageUser,
            this.ColumnDateUser,
            this.ColumnHourUser,
            this.ColumnLocationUser});
            this.MyTravels.GridLines = true;
            this.MyTravels.HideSelection = false;
            this.MyTravels.Location = new System.Drawing.Point(6, 19);
            this.MyTravels.Name = "MyTravels";
            this.MyTravels.Size = new System.Drawing.Size(405, 256);
            this.MyTravels.TabIndex = 2;
            this.MyTravels.UseCompatibleStateImageBehavior = false;
            this.MyTravels.View = System.Windows.Forms.View.Details;
            // 
            // ColumnIDUser
            // 
            this.ColumnIDUser.Text = "ID";
            this.ColumnIDUser.Width = 32;
            // 
            // ColumnImageUser
            // 
            this.ColumnImageUser.Text = "Avatar";
            this.ColumnImageUser.Width = 80;
            // 
            // ColumnDateUser
            // 
            this.ColumnDateUser.Text = "Date";
            this.ColumnDateUser.Width = 100;
            // 
            // ColumnHourUser
            // 
            this.ColumnHourUser.Text = "Hour";
            // 
            // ColumnLocationUser
            // 
            this.ColumnLocationUser.Text = "Location";
            this.ColumnLocationUser.Width = 90;
            // 
            // rideofferGroupBox
            // 
            this.rideofferGroupBox.Controls.Add(this.bidresultLabel);
            this.rideofferGroupBox.Controls.Add(this.bidButton);
            this.rideofferGroupBox.Controls.Add(this.publishrideGroupBox);
            this.rideofferGroupBox.Controls.Add(this.OfferTravels);
            this.rideofferGroupBox.Location = new System.Drawing.Point(12, 16);
            this.rideofferGroupBox.Name = "rideofferGroupBox";
            this.rideofferGroupBox.Size = new System.Drawing.Size(437, 530);
            this.rideofferGroupBox.TabIndex = 5;
            this.rideofferGroupBox.TabStop = false;
            this.rideofferGroupBox.Text = "Ride Offer";
            // 
            // bidresultLabel
            // 
            this.bidresultLabel.AutoSize = true;
            this.bidresultLabel.Location = new System.Drawing.Point(225, 286);
            this.bidresultLabel.Name = "bidresultLabel";
            this.bidresultLabel.Size = new System.Drawing.Size(81, 13);
            this.bidresultLabel.TabIndex = 4;
            this.bidresultLabel.Text = "//BID STATUS";
            // 
            // bidButton
            // 
            this.bidButton.Location = new System.Drawing.Point(350, 281);
            this.bidButton.Name = "bidButton";
            this.bidButton.Size = new System.Drawing.Size(75, 23);
            this.bidButton.TabIndex = 4;
            this.bidButton.Text = "Bid";
            this.bidButton.UseVisualStyleBackColor = true;
            // 
            // publishrideGroupBox
            // 
            this.publishrideGroupBox.Controls.Add(this.publishridewarningLabel);
            this.publishrideGroupBox.Controls.Add(this.moneysimbol);
            this.publishrideGroupBox.Controls.Add(this.costTextBox);
            this.publishrideGroupBox.Controls.Add(this.costLabel);
            this.publishrideGroupBox.Controls.Add(this.dateTimePicker2);
            this.publishrideGroupBox.Controls.Add(this.dateTimePicker1);
            this.publishrideGroupBox.Controls.Add(this.offerpublishButton);
            this.publishrideGroupBox.Controls.Add(this.availableseatsComboBox);
            this.publishrideGroupBox.Controls.Add(this.offerseatsLabel);
            this.publishrideGroupBox.Controls.Add(this.locationComboBox);
            this.publishrideGroupBox.Controls.Add(this.offerlocationLabel);
            this.publishrideGroupBox.Controls.Add(this.offerdateLabel);
            this.publishrideGroupBox.Controls.Add(this.publishrideLabel);
            this.publishrideGroupBox.Location = new System.Drawing.Point(6, 310);
            this.publishrideGroupBox.Name = "publishrideGroupBox";
            this.publishrideGroupBox.Size = new System.Drawing.Size(425, 209);
            this.publishrideGroupBox.TabIndex = 3;
            this.publishrideGroupBox.TabStop = false;
            this.publishrideGroupBox.Text = "Publish Ride";
            // 
            // publishridewarningLabel
            // 
            this.publishridewarningLabel.AutoSize = true;
            this.publishridewarningLabel.ForeColor = System.Drawing.Color.Red;
            this.publishridewarningLabel.Location = new System.Drawing.Point(9, 185);
            this.publishridewarningLabel.Name = "publishridewarningLabel";
            this.publishridewarningLabel.Size = new System.Drawing.Size(70, 13);
            this.publishridewarningLabel.TabIndex = 14;
            this.publishridewarningLabel.Text = "//WARNING";
            // 
            // moneysimbol
            // 
            this.moneysimbol.AutoSize = true;
            this.moneysimbol.Location = new System.Drawing.Point(111, 163);
            this.moneysimbol.Name = "moneysimbol";
            this.moneysimbol.Size = new System.Drawing.Size(13, 13);
            this.moneysimbol.TabIndex = 13;
            this.moneysimbol.Text = "$";
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(130, 160);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(82, 20);
            this.costTextBox.TabIndex = 12;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(105, 144);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(28, 13);
            this.costLabel.TabIndex = 11;
            this.costLabel.Text = "Cost";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(117, 67);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(53, 20);
            this.dateTimePicker2.TabIndex = 10;
            this.dateTimePicker2.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 67);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2022, 4, 23, 0, 0, 0, 0);
            // 
            // offerpublishButton
            // 
            this.offerpublishButton.Location = new System.Drawing.Point(344, 180);
            this.offerpublishButton.Name = "offerpublishButton";
            this.offerpublishButton.Size = new System.Drawing.Size(75, 23);
            this.offerpublishButton.TabIndex = 9;
            this.offerpublishButton.Text = "Post offer";
            this.offerpublishButton.UseVisualStyleBackColor = true;
            this.offerpublishButton.Click += new System.EventHandler(this.offerpublishButton_Click);
            // 
            // availableseatsComboBox
            // 
            this.availableseatsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.availableseatsComboBox.FormattingEnabled = true;
            this.availableseatsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.availableseatsComboBox.Location = new System.Drawing.Point(12, 160);
            this.availableseatsComboBox.Name = "availableseatsComboBox";
            this.availableseatsComboBox.Size = new System.Drawing.Size(45, 21);
            this.availableseatsComboBox.TabIndex = 8;
            // 
            // offerseatsLabel
            // 
            this.offerseatsLabel.AutoSize = true;
            this.offerseatsLabel.Location = new System.Drawing.Point(9, 144);
            this.offerseatsLabel.Name = "offerseatsLabel";
            this.offerseatsLabel.Size = new System.Drawing.Size(78, 13);
            this.offerseatsLabel.TabIndex = 7;
            this.offerseatsLabel.Text = "Available seats";
            // 
            // locationComboBox
            // 
            this.locationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Items.AddRange(new object[] {
            "Azcapotzalco",
            "Álvaro Obregón",
            "Benito Juárez",
            "Coyoacán",
            "Cuajimalpa de Morelos",
            "Cuauhtémoc",
            "Gustavo A. Madero",
            "Iztacalco",
            "Iztapalapa",
            "La Magdalena Contreras",
            "Miguel Hidalgo",
            "Milpa Alta",
            "Tlalpan",
            "Tláhuac",
            "Venustiano Carranza",
            "Xochimilco"});
            this.locationComboBox.Location = new System.Drawing.Point(12, 112);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(200, 21);
            this.locationComboBox.TabIndex = 6;
            // 
            // offerlocationLabel
            // 
            this.offerlocationLabel.AutoSize = true;
            this.offerlocationLabel.Location = new System.Drawing.Point(9, 96);
            this.offerlocationLabel.Name = "offerlocationLabel";
            this.offerlocationLabel.Size = new System.Drawing.Size(48, 13);
            this.offerlocationLabel.TabIndex = 5;
            this.offerlocationLabel.Text = "Location";
            // 
            // offerdateLabel
            // 
            this.offerdateLabel.AutoSize = true;
            this.offerdateLabel.Location = new System.Drawing.Point(9, 51);
            this.offerdateLabel.Name = "offerdateLabel";
            this.offerdateLabel.Size = new System.Drawing.Size(73, 13);
            this.offerdateLabel.TabIndex = 4;
            this.offerdateLabel.Text = "Date and time";
            // 
            // publishrideLabel
            // 
            this.publishrideLabel.AutoSize = true;
            this.publishrideLabel.Location = new System.Drawing.Point(9, 18);
            this.publishrideLabel.Name = "publishrideLabel";
            this.publishrideLabel.Size = new System.Drawing.Size(299, 13);
            this.publishrideLabel.TabIndex = 3;
            this.publishrideLabel.Text = "Select the desired date and hour for the ride you want to offer.";
            // 
            // myridesGroupBox
            // 
            this.myridesGroupBox.Controls.Add(this.unbidButton);
            this.myridesGroupBox.Controls.Add(this.MyTravels);
            this.myridesGroupBox.Location = new System.Drawing.Point(455, 16);
            this.myridesGroupBox.Name = "myridesGroupBox";
            this.myridesGroupBox.Size = new System.Drawing.Size(417, 310);
            this.myridesGroupBox.TabIndex = 6;
            this.myridesGroupBox.TabStop = false;
            this.myridesGroupBox.Text = "My future trips";
            // 
            // unbidButton
            // 
            this.unbidButton.Location = new System.Drawing.Point(336, 281);
            this.unbidButton.Name = "unbidButton";
            this.unbidButton.Size = new System.Drawing.Size(75, 23);
            this.unbidButton.TabIndex = 3;
            this.unbidButton.Text = "Unbid";
            this.unbidButton.UseVisualStyleBackColor = true;
            // 
            // profileGroupBox
            // 
            this.profileGroupBox.Controls.Add(this.currentavatarnumLabel);
            this.profileGroupBox.Controls.Add(this.saveButton);
            this.profileGroupBox.Controls.Add(this.ethereumaddressLabel);
            this.profileGroupBox.Controls.Add(this.ethereumaddressTextBox);
            this.profileGroupBox.Controls.Add(this.usernameLabel);
            this.profileGroupBox.Controls.Add(this.usernameTextBox);
            this.profileGroupBox.Controls.Add(this.previousavatarButton);
            this.profileGroupBox.Controls.Add(this.nextavatarButton);
            this.profileGroupBox.Controls.Add(this.avatarPictureBox);
            this.profileGroupBox.Location = new System.Drawing.Point(455, 326);
            this.profileGroupBox.Name = "profileGroupBox";
            this.profileGroupBox.Size = new System.Drawing.Size(417, 220);
            this.profileGroupBox.TabIndex = 4;
            this.profileGroupBox.TabStop = false;
            this.profileGroupBox.Text = "Profile";
            // 
            // currentavatarnumLabel
            // 
            this.currentavatarnumLabel.AutoSize = true;
            this.currentavatarnumLabel.Location = new System.Drawing.Point(173, 110);
            this.currentavatarnumLabel.Name = "currentavatarnumLabel";
            this.currentavatarnumLabel.Size = new System.Drawing.Size(13, 13);
            this.currentavatarnumLabel.TabIndex = 11;
            this.currentavatarnumLabel.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(285, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ethereumaddressLabel
            // 
            this.ethereumaddressLabel.AutoSize = true;
            this.ethereumaddressLabel.Location = new System.Drawing.Point(25, 156);
            this.ethereumaddressLabel.Name = "ethereumaddressLabel";
            this.ethereumaddressLabel.Size = new System.Drawing.Size(92, 13);
            this.ethereumaddressLabel.TabIndex = 10;
            this.ethereumaddressLabel.Text = "Ethereum address";
            // 
            // ethereumaddressTextBox
            // 
            this.ethereumaddressTextBox.Location = new System.Drawing.Point(123, 153);
            this.ethereumaddressTextBox.Name = "ethereumaddressTextBox";
            this.ethereumaddressTextBox.Size = new System.Drawing.Size(237, 20);
            this.ethereumaddressTextBox.TabIndex = 9;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(62, 127);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(55, 13);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(123, 127);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(237, 20);
            this.usernameTextBox.TabIndex = 7;
            // 
            // previousavatarButton
            // 
            this.previousavatarButton.Location = new System.Drawing.Point(114, 43);
            this.previousavatarButton.Name = "previousavatarButton";
            this.previousavatarButton.Size = new System.Drawing.Size(21, 44);
            this.previousavatarButton.TabIndex = 6;
            this.previousavatarButton.Text = "<";
            this.previousavatarButton.UseVisualStyleBackColor = true;
            this.previousavatarButton.Click += new System.EventHandler(this.previousavatarButton_Click);
            // 
            // nextavatarButton
            // 
            this.nextavatarButton.Location = new System.Drawing.Point(227, 43);
            this.nextavatarButton.Name = "nextavatarButton";
            this.nextavatarButton.Size = new System.Drawing.Size(21, 44);
            this.nextavatarButton.TabIndex = 5;
            this.nextavatarButton.Text = ">";
            this.nextavatarButton.UseVisualStyleBackColor = true;
            this.nextavatarButton.Click += new System.EventHandler(this.nextavatarButton_Click);
            // 
            // avatarPictureBox
            // 
            this.avatarPictureBox.Location = new System.Drawing.Point(141, 26);
            this.avatarPictureBox.Name = "avatarPictureBox";
            this.avatarPictureBox.Size = new System.Drawing.Size(80, 80);
            this.avatarPictureBox.TabIndex = 4;
            this.avatarPictureBox.TabStop = false;
            // 
            // CryptoRide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.profileGroupBox);
            this.Controls.Add(this.rideofferGroupBox);
            this.Controls.Add(this.myridesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CryptoRide";
            this.Text = "CryptoRide";
            this.rideofferGroupBox.ResumeLayout(false);
            this.rideofferGroupBox.PerformLayout();
            this.publishrideGroupBox.ResumeLayout(false);
            this.publishrideGroupBox.PerformLayout();
            this.myridesGroupBox.ResumeLayout(false);
            this.profileGroupBox.ResumeLayout(false);
            this.profileGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView OfferTravels;
        private System.Windows.Forms.ColumnHeader ColumnID;
        private System.Windows.Forms.ColumnHeader ColumnImage;
        private System.Windows.Forms.ColumnHeader ColumnDate;
        private System.Windows.Forms.ColumnHeader ColumnHour;
        private System.Windows.Forms.ColumnHeader ColumnSeats;
        private System.Windows.Forms.ListView MyTravels;
        private System.Windows.Forms.ColumnHeader ColumnIDUser;
        private System.Windows.Forms.ColumnHeader ColumnImageUser;
        private System.Windows.Forms.ColumnHeader ColumnDateUser;
        private System.Windows.Forms.ColumnHeader ColumnLocationUser;
        private System.Windows.Forms.ColumnHeader ColumnLocation;
        private System.Windows.Forms.ColumnHeader ColumnHourUser;
        private System.Windows.Forms.GroupBox rideofferGroupBox;
        private System.Windows.Forms.GroupBox myridesGroupBox;
        private System.Windows.Forms.GroupBox publishrideGroupBox;
        private System.Windows.Forms.Label publishrideLabel;
        private System.Windows.Forms.GroupBox profileGroupBox;
        private System.Windows.Forms.Label offerdateLabel;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.Label offerlocationLabel;
        private System.Windows.Forms.ComboBox availableseatsComboBox;
        private System.Windows.Forms.Label offerseatsLabel;
        private System.Windows.Forms.Button offerpublishButton;
        private System.Windows.Forms.Button unbidButton;
        private System.Windows.Forms.PictureBox avatarPictureBox;
        private System.Windows.Forms.Button previousavatarButton;
        private System.Windows.Forms.Button nextavatarButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button bidButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label ethereumaddressLabel;
        private System.Windows.Forms.TextBox ethereumaddressTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label bidresultLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label currentavatarnumLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label moneysimbol;
        private System.Windows.Forms.Label publishridewarningLabel;
        private System.Windows.Forms.ColumnHeader ColumnCost;
    }
}

