namespace WApp
{
    partial class Econtact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Econtact));
            pictureBoxLogo = new PictureBox();
            lblContactID = new Label();
            txtBoxContactID = new TextBox();
            textBoxFirstName = new TextBox();
            lblFirstName = new Label();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxContactNumber = new TextBox();
            lblContactNumber = new Label();
            txtBoxAddress = new TextBox();
            lblAddress = new Label();
            cmbGender = new ComboBox();
            lblGender = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            txtBoxSearch = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(543, 26);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(128, 128);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.BackColor = Color.Transparent;
            lblContactID.Font = new Font("Segoe UI", 12.75F);
            lblContactID.Location = new Point(53, 222);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(101, 23);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID :";
            // 
            // txtBoxContactID
            // 
            txtBoxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxContactID.Location = new Point(171, 220);
            txtBoxContactID.Name = "txtBoxContactID";
            txtBoxContactID.Size = new Size(241, 29);
            txtBoxContactID.TabIndex = 2;
            txtBoxContactID.TextChanged += textBox1_TextChanged;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxFirstName.Location = new Point(171, 279);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(241, 29);
            textBoxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 12.75F);
            lblFirstName.Location = new Point(53, 281);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(96, 23);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "FirstName :";
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxLastName.Location = new Point(171, 336);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(241, 29);
            txtBoxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 12.75F);
            lblLastName.Location = new Point(53, 338);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 23);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "LastName :";
            // 
            // txtBoxContactNumber
            // 
            txtBoxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxContactNumber.Location = new Point(171, 387);
            txtBoxContactNumber.Name = "txtBoxContactNumber";
            txtBoxContactNumber.Size = new Size(241, 29);
            txtBoxContactNumber.TabIndex = 10;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Segoe UI", 12.75F);
            lblContactNumber.Location = new Point(53, 389);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(106, 23);
            lblContactNumber.TabIndex = 9;
            lblContactNumber.Text = "ContactNo. :";
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAddress.Location = new Point(171, 515);
            txtBoxAddress.Multiline = true;
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(241, 110);
            txtBoxAddress.TabIndex = 12;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12.75F);
            lblAddress.Location = new Point(53, 517);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(79, 23);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address :";
            lblAddress.Click += lblAddress_Click;
            // 
            // cmbGender
            // 
            cmbGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(171, 447);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(241, 29);
            cmbGender.TabIndex = 13;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12.75F);
            lblGender.Location = new Point(53, 449);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(75, 23);
            lblGender.TabIndex = 14;
            lblGender.Text = "Gender :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(301, 711);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(135, 55);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Blue;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(457, 711);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(135, 55);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(613, 711);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 55);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(771, 711);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 55);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(464, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(670, 344);
            dataGridView1.TabIndex = 19;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(464, 220);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 20;
            lblSearch.Text = "Search";
            lblSearch.Click += label1_Click;
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearch.Location = new Point(543, 218);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(591, 29);
            txtBoxSearch.TabIndex = 21;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1125, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Econtact
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 847);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxSearch);
            Controls.Add(lblSearch);
            Controls.Add(dataGridView1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(lblGender);
            Controls.Add(cmbGender);
            Controls.Add(txtBoxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtBoxContactNumber);
            Controls.Add(lblContactNumber);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtBoxContactID);
            Controls.Add(lblContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Econtact";
            Text = "Econtact";
            Load += Econtact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblContactID;
        private TextBox txtBoxContactID;
        private TextBox textBoxFirstName;
        private Label lblFirstName;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxContactNumber;
        private Label lblContactNumber;
        private TextBox txtBoxAddress;
        private Label lblAddress;
        private ComboBox cmbGender;
        private Label lblGender;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Label lblSearch;
        private TextBox txtBoxSearch;
        private PictureBox pictureBox1;
    }
}
