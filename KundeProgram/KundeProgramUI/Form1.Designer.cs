namespace KundeProgramUI;

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
        lb_customers = new ListBox();
        btn_OpenCustomerRegistration = new Button();
        btn_DeleteCustomer = new Button();
        btn_UpdateCustomer = new Button();
        numericUpDown1 = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        SuspendLayout();
        // 
        // lb_customers
        // 
        lb_customers.FormattingEnabled = true;
        lb_customers.ItemHeight = 25;
        lb_customers.Location = new Point(8, 6);
        lb_customers.Name = "lb_customers";
        lb_customers.Size = new Size(741, 404);
        lb_customers.TabIndex = 1;
        // 
        // btn_OpenCustomerRegistration
        // 
        btn_OpenCustomerRegistration.Location = new Point(12, 416);
        btn_OpenCustomerRegistration.Name = "btn_OpenCustomerRegistration";
        btn_OpenCustomerRegistration.Size = new Size(162, 34);
        btn_OpenCustomerRegistration.TabIndex = 2;
        btn_OpenCustomerRegistration.Text = "Opret ny kunde";
        btn_OpenCustomerRegistration.UseVisualStyleBackColor = true;
        btn_OpenCustomerRegistration.Click += btn_OpenCustomerRegistration_Click;
        // 
        // btn_DeleteCustomer
        // 
        btn_DeleteCustomer.Location = new Point(343, 416);
        btn_DeleteCustomer.Name = "btn_DeleteCustomer";
        btn_DeleteCustomer.Size = new Size(128, 34);
        btn_DeleteCustomer.TabIndex = 3;
        btn_DeleteCustomer.Text = "Slet kunde";
        btn_DeleteCustomer.UseVisualStyleBackColor = true;
        btn_DeleteCustomer.Click += btn_DeleteCustomer_Click;
        // 
        // btn_UpdateCustomer
        // 
        btn_UpdateCustomer.Location = new Point(180, 416);
        btn_UpdateCustomer.Name = "btn_UpdateCustomer";
        btn_UpdateCustomer.Size = new Size(157, 34);
        btn_UpdateCustomer.TabIndex = 4;
        btn_UpdateCustomer.Text = "Opdater kunde";
        btn_UpdateCustomer.UseVisualStyleBackColor = true;
        btn_UpdateCustomer.Click += btn_UpdateCustomer_Click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(518, 419);
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(231, 31);
        numericUpDown1.TabIndex = 5;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(765, 456);
        Controls.Add(numericUpDown1);
        Controls.Add(btn_UpdateCustomer);
        Controls.Add(btn_DeleteCustomer);
        Controls.Add(btn_OpenCustomerRegistration);
        Controls.Add(lb_customers);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private ListBox lb_customers;
    private Button btn_OpenCustomerRegistration;
    private Button btn_DeleteCustomer;
    private Button btn_UpdateCustomer;
    private NumericUpDown numericUpDown1;
}