namespace KundeProgramUI.Forms
{
    partial class UpdateCustomerForm
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
            btn_UpdateCustomer = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txb_zip = new TextBox();
            txb_housenumber = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txb_City = new TextBox();
            label5 = new Label();
            txb_streetname = new TextBox();
            btn_DeleteAddress = new Button();
            SuspendLayout();
            // 
            // txb_email
            // 
            txb_email.Location = new Point(158, 152);
            txb_email.Name = "txb_email";
            txb_email.Size = new Size(185, 31);
            txb_email.TabIndex = 26;
            // 
            // txb_phoneNo
            // 
            txb_phoneNo.Location = new Point(158, 105);
            txb_phoneNo.Name = "txb_phoneNo";
            txb_phoneNo.Size = new Size(185, 31);
            txb_phoneNo.TabIndex = 25;
            // 
            // txb_lastname
            // 
            txb_lastname.Location = new Point(158, 59);
            txb_lastname.Name = "txb_lastname";
            txb_lastname.Size = new Size(185, 31);
            txb_lastname.TabIndex = 24;
            // 
            // txb_firstname
            // 
            txb_firstname.Location = new Point(158, 12);
            txb_firstname.Name = "txb_firstname";
            txb_firstname.Size = new Size(185, 31);
            txb_firstname.TabIndex = 23;
            // 
            // btn_UpdateCustomer
            // 
            btn_UpdateCustomer.Location = new Point(242, 304);
            btn_UpdateCustomer.Name = "btn_UpdateCustomer";
            btn_UpdateCustomer.Size = new Size(101, 37);
            btn_UpdateCustomer.TabIndex = 22;
            btn_UpdateCustomer.Text = "Opdater";
            btn_UpdateCustomer.UseVisualStyleBackColor = true;
            btn_UpdateCustomer.Click += btn_UpdateCustomer_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 155);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 21;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 108);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 20;
            label3.Text = "Phone Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 59);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 19;
            label2.Text = "Lastname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 18;
            label1.Text = "Firstname";
            // 
            // txb_zip
            // 
            txb_zip.Location = new Point(62, 257);
            txb_zip.Name = "txb_zip";
            txb_zip.Size = new Size(90, 31);
            txb_zip.TabIndex = 33;
            // 
            // txb_housenumber
            // 
            txb_housenumber.Location = new Point(253, 220);
            txb_housenumber.Name = "txb_housenumber";
            txb_housenumber.Size = new Size(90, 31);
            txb_housenumber.TabIndex = 32;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 223);
            label7.Name = "label7";
            label7.Size = new Size(57, 25);
            label7.TabIndex = 31;
            label7.Text = "Street";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 260);
            label6.Name = "label6";
            label6.Size = new Size(37, 25);
            label6.TabIndex = 30;
            label6.Text = "Zip";
            // 
            // txb_City
            // 
            txb_City.Location = new Point(158, 257);
            txb_City.Name = "txb_City";
            txb_City.Size = new Size(185, 31);
            txb_City.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 193);
            label5.Name = "label5";
            label5.Size = new Size(75, 25);
            label5.TabIndex = 28;
            label5.Text = "Adresse";
            // 
            // txb_streetname
            // 
            txb_streetname.Location = new Point(62, 221);
            txb_streetname.Name = "txb_streetname";
            txb_streetname.Size = new Size(185, 31);
            txb_streetname.TabIndex = 27;
            // 
            // btn_DeleteAddress
            // 
            btn_DeleteAddress.Location = new Point(19, 304);
            btn_DeleteAddress.Name = "btn_DeleteAddress";
            btn_DeleteAddress.Size = new Size(189, 37);
            btn_DeleteAddress.TabIndex = 34;
            btn_DeleteAddress.Text = "Slet adresse";
            btn_DeleteAddress.UseVisualStyleBackColor = true;
            btn_DeleteAddress.Visible = false;
            btn_DeleteAddress.Click += btn_DeleteAddress_Click;
            // 
            // UpdateCustomerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 355);
            Controls.Add(btn_DeleteAddress);
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
            Controls.Add(btn_UpdateCustomer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateCustomerForm";
            Text = "UpdateCustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txb_email;
        private TextBox txb_phoneNo;
        private TextBox txb_lastname;
        private TextBox txb_firstname;
        private Button btn_UpdateCustomer;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txb_zip;
        private TextBox txb_housenumber;
        private Label label7;
        private Label label6;
        private TextBox txb_City;
        private Label label5;
        private TextBox txb_streetname;
        private Button btn_DeleteAddress;
    }
}