namespace KundeProgramUI.Forms
{
    partial class RegisterCustomerForm
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
            txb_email = new TextBox();
            txb_phoneNo = new TextBox();
            txb_lastname = new TextBox();
            txb_firstname = new TextBox();
            btn_CreateCustomer = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txb_streetname = new TextBox();
            label5 = new Label();
            txb_City = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txb_housenumber = new TextBox();
            txb_zip = new TextBox();
            SuspendLayout();
            // 
            // txb_email
            // 
            txb_email.Location = new Point(159, 149);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(185, 31);
            txb_email.TabIndex = 17;
            // 
            // txb_phoneNo
            // 
            txb_phoneNo.Location = new Point(159, 102);
            txb_phoneNo.Name = "txb_phoneNo";
            txb_phoneNo.Size = new Size(185, 31);
            txb_phoneNo.TabIndex = 16;
            // 
            // txb_lastname
            // 
            txb_lastname.Location = new Point(159, 56);
            txb_lastname.Name = "txb_lastname";
            txb_lastname.Size = new Size(185, 31);
            txb_lastname.TabIndex = 15;
            // 
            // txb_firstname
            // 
            txb_firstname.Location = new Point(159, 9);
            txb_firstname.Name = "txb_firstname";
            txb_firstname.Size = new Size(185, 31);
            txb_firstname.TabIndex = 14;
            // 
            // btn_CreateCustomer
            // 
            btn_CreateCustomer.Location = new Point(264, 295);
            btn_CreateCustomer.Name = "btn_CreateCustomer";
            btn_CreateCustomer.Size = new Size(80, 37);
            btn_CreateCustomer.TabIndex = 13;
            btn_CreateCustomer.Text = "Opret";
            btn_CreateCustomer.UseVisualStyleBackColor = true;
            btn_CreateCustomer.Click += btn_CreateCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 12;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 11;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 10;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 9;
            label1.Text = "Firstname";
            // 
            // txb_streetname
            // 
            txb_streetname.Location = new Point(63, 214);
            txb_streetname.Name = "txb_streetname";
            txb_streetname.Size = new Size(185, 31);
            txb_streetname.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 186);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 20;
            label5.Text = "Adresse";
            // 
            // txb_City
            // 
            txb_City.Location = new Point(159, 250);
            txb_City.Name = "txb_City";
            txb_City.Size = new Size(185, 31);
            txb_City.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 253);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 23;
            label6.Text = "Zip";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 216);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 24;
            label7.Text = "Street";
            // 
            // txb_housenumber
            // 
            txb_housenumber.Location = new Point(254, 213);
            txb_housenumber.Name = "txb_housenumber";
            txb_housenumber.Size = new Size(90, 31);
            txb_housenumber.TabIndex = 25;
            // 
            // txb_zip
            // 
            txb_zip.Location = new Point(63, 250);
            txb_zip.Name = "txb_zip";
            txb_zip.Size = new Size(90, 31);
            txb_zip.TabIndex = 26;
            // 
            // RegisterCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 344);
            Controls.Add(txb_zip);
            Controls.Add(txb_housenumber);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txb_City);
            Controls.Add(label5);
            Controls.Add(txb_streetname);
            Controls.Add(txb_email);
            Controls.Add(txb_phoneNo);
            Controls.Add(txb_lastname);
            Controls.Add(txb_firstname);
            Controls.Add(btn_CreateCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegisterCustomerForm";
            Text = "RegisterCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_email;
        private TextBox txb_phoneNo;
        private TextBox txb_lastname;
        private TextBox txb_firstname;
        private Button btn_CreateCustomer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txb_streetname;
        private Label label5;
        private TextBox txb_City;
        private Label label6;
        private Label label7;
        private TextBox txb_housenumber;
        private TextBox txb_zip;
    }
}