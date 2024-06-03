using System.ComponentModel;

namespace AutomobileWinApp;

partial class frmCarDetails
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        lbCarID = new Label();
        lbCarName = new Label();
        lbManufacturer = new Label();
        lbPrice = new Label();
        lbReleaseYear = new Label();
        txtCarID = new TextBox();
        txtCarName = new TextBox();
        txtPrice = new MaskedTextBox();
        txtReleaseYear = new MaskedTextBox();
        cboManufacturer = new ComboBox();
        btnSave = new Button();
        btnCancel = new Button();
        SuspendLayout();
        // 
        // lbCarID
        // 
        lbCarID.AutoSize = true;
        lbCarID.Location = new Point(60, 44);
        lbCarID.Name = "lbCarID";
        lbCarID.Size = new Size(50, 20);
        lbCarID.TabIndex = 0;
        lbCarID.Text = "Car ID";
        // 
        // lbCarName
        // 
        lbCarName.AutoSize = true;
        lbCarName.Location = new Point(60, 101);
        lbCarName.Name = "lbCarName";
        lbCarName.Size = new Size(75, 20);
        lbCarName.TabIndex = 1;
        lbCarName.Text = "Car Name";
        // 
        // lbManufacturer
        // 
        lbManufacturer.AutoSize = true;
        lbManufacturer.Location = new Point(60, 158);
        lbManufacturer.Name = "lbManufacturer";
        lbManufacturer.Size = new Size(97, 20);
        lbManufacturer.TabIndex = 2;
        lbManufacturer.Text = "Manufacturer";
        // 
        // lbPrice
        // 
        lbPrice.AutoSize = true;
        lbPrice.Location = new Point(60, 215);
        lbPrice.Name = "lbPrice";
        lbPrice.Size = new Size(41, 20);
        lbPrice.TabIndex = 3;
        lbPrice.Text = "Price";
        // 
        // lbReleaseYear
        // 
        lbReleaseYear.AutoSize = true;
        lbReleaseYear.Location = new Point(60, 272);
        lbReleaseYear.Name = "lbReleaseYear";
        lbReleaseYear.Size = new Size(92, 20);
        lbReleaseYear.TabIndex = 4;
        lbReleaseYear.Text = "Release Year";
        // 
        // txtCarID
        // 
        txtCarID.Location = new Point(171, 41);
        txtCarID.Name = "txtCarID";
        txtCarID.Size = new Size(224, 27);
        txtCarID.TabIndex = 5;
        // 
        // txtCarName
        // 
        txtCarName.Location = new Point(171, 98);
        txtCarName.Name = "txtCarName";
        txtCarName.Size = new Size(224, 27);
        txtCarName.TabIndex = 6;
        // 
        // txtPrice
        // 
        txtPrice.Location = new Point(171, 212);
        txtPrice.Mask = "000000000";
        txtPrice.Name = "txtPrice";
        txtPrice.Size = new Size(224, 27);
        txtPrice.TabIndex = 7;
        txtPrice.Text = "0";
        // 
        // txtReleaseYear
        // 
        txtReleaseYear.Location = new Point(171, 269);
        txtReleaseYear.Mask = "0000";
        txtReleaseYear.Name = "txtReleaseYear";
        txtReleaseYear.Size = new Size(224, 27);
        txtReleaseYear.TabIndex = 8;
        txtReleaseYear.Text = "0";
        // 
        // cboManufacturer
        // 
        cboManufacturer.FormattingEnabled = true;
        cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Huyndai", "Kia", "Suzuki", "Toyota" });
        cboManufacturer.Location = new Point(171, 158);
        cboManufacturer.Name = "cboManufacturer";
        cboManufacturer.Size = new Size(224, 28);
        cboManufacturer.TabIndex = 9;
        // 
        // btnSave
        // 
        btnSave.DialogResult = DialogResult.OK;
        btnSave.Location = new Point(78, 330);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(94, 29);
        btnSave.TabIndex = 10;
        btnSave.Text = "Save";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // btnCancel
        // 
        btnCancel.DialogResult = DialogResult.Cancel;
        btnCancel.Location = new Point(264, 330);
        btnCancel.Name = "btnCancel";
        btnCancel.Size = new Size(94, 29);
        btnCancel.TabIndex = 11;
        btnCancel.Text = "Cancel";
        btnCancel.UseVisualStyleBackColor = true;
        btnCancel.Click += btnCancel_Click;
        // 
        // frmCarDetails
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(437, 385);
        Controls.Add(btnCancel);
        Controls.Add(btnSave);
        Controls.Add(cboManufacturer);
        Controls.Add(txtReleaseYear);
        Controls.Add(txtPrice);
        Controls.Add(txtCarName);
        Controls.Add(txtCarID);
        Controls.Add(lbReleaseYear);
        Controls.Add(lbPrice);
        Controls.Add(lbManufacturer);
        Controls.Add(lbCarName);
        Controls.Add(lbCarID);
        Name = "frmCarDetails";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "frmCarDetails";
        Load += frmCarDetails_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lbCarID;
    private Label lbCarName;
    private Label lbManufacturer;
    private Label lbPrice;
    private Label lbReleaseYear;
    private TextBox txtCarID;
    private TextBox txtCarName;
    private MaskedTextBox txtPrice;
    private MaskedTextBox txtReleaseYear;
    private ComboBox cboManufacturer;
    private Button btnSave;
    private Button btnCancel;
}