namespace ResponsiJuniorProject
{
    partial class ResponsiJuniorProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResponsiJuniorProject));
            labelNama = new Label();
            labelDepartment = new Label();
            textBoxNama = new TextBox();
            comboBoxDep = new ComboBox();
            btnInsert = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            label3 = new Label();
            dgvDataTable = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            labelJabatan = new Label();
            comboBoxJabatan = new ComboBox();
            label7 = new Label();
            pictureBoxLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(80, 179);
            labelNama.Margin = new Padding(4, 0, 4, 0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(59, 25);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            labelNama.Click += labelNama_Click;
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(80, 238);
            labelDepartment.Margin = new Padding(4, 0, 4, 0);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(101, 25);
            labelDepartment.TabIndex = 1;
            labelDepartment.Text = "Deparment";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(209, 179);
            textBoxNama.Margin = new Padding(4, 5, 4, 5);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(171, 31);
            textBoxNama.TabIndex = 2;
            // 
            // comboBoxDep
            // 
            comboBoxDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(209, 235);
            comboBoxDep.Margin = new Padding(4, 5, 4, 5);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(171, 33);
            comboBoxDep.TabIndex = 3;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(77, 360);
            btnInsert.Margin = new Padding(4, 5, 4, 5);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(107, 38);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(313, 360);
            btnEdit.Margin = new Padding(4, 5, 4, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 38);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(579, 360);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(107, 38);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(470, 181);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 7;
            label3.Text = "Departmen";
            // 
            // dgvDataTable
            // 
            dgvDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataTable.Location = new Point(77, 427);
            dgvDataTable.Margin = new Padding(4, 5, 4, 5);
            dgvDataTable.Name = "dgvDataTable";
            dgvDataTable.RowHeadersWidth = 62;
            dgvDataTable.RowTemplate.Height = 25;
            dgvDataTable.Size = new Size(609, 250);
            dgvDataTable.TabIndex = 8;
            dgvDataTable.CellContentClick += dgvDataTable_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(470, 206);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(179, 25);
            label1.TabIndex = 9;
            label1.Text = "HR: Human Resource";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(470, 231);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 25);
            label2.TabIndex = 10;
            label2.Text = "ENG: Engineering";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Location = new Point(470, 256);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(135, 25);
            label4.TabIndex = 11;
            label4.Text = "DEV: Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(470, 281);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(184, 25);
            label5.TabIndex = 12;
            label5.Text = "PM: Product Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Location = new Point(470, 306);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 25);
            label6.TabIndex = 13;
            label6.Text = "FIN: Finance";
            // 
            // labelJabatan
            // 
            labelJabatan.AutoSize = true;
            labelJabatan.Location = new Point(80, 311);
            labelJabatan.Margin = new Padding(4, 0, 4, 0);
            labelJabatan.Name = "labelJabatan";
            labelJabatan.Size = new Size(72, 25);
            labelJabatan.TabIndex = 14;
            labelJabatan.Text = "Jabatan";
            // 
            // comboBoxJabatan
            // 
            comboBoxJabatan.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxJabatan.FormattingEnabled = true;
            comboBoxJabatan.Location = new Point(209, 308);
            comboBoxJabatan.Margin = new Padding(4, 5, 4, 5);
            comboBoxJabatan.Name = "comboBoxJabatan";
            comboBoxJabatan.Size = new Size(171, 33);
            comboBoxJabatan.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(77, 682);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(422, 19);
            label7.TabIndex = 16;
            label7.Text = "*choose one row (it not being shown in the input box but it works)";
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.AccessibleRole = AccessibleRole.None;
            pictureBoxLogo.BackgroundImage = (Image)resources.GetObject("pictureBoxLogo.BackgroundImage");
            pictureBoxLogo.Location = new Point(220, 82);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(330, 64);
            pictureBoxLogo.TabIndex = 17;
            pictureBoxLogo.TabStop = false;
            // 
            // ResponsiJuniorProject
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 750);
            Controls.Add(pictureBoxLogo);
            Controls.Add(label7);
            Controls.Add(comboBoxJabatan);
            Controls.Add(labelJabatan);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDataTable);
            Controls.Add(label3);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnInsert);
            Controls.Add(comboBoxDep);
            Controls.Add(textBoxNama);
            Controls.Add(labelDepartment);
            Controls.Add(labelNama);
            Margin = new Padding(4, 5, 4, 5);
            Name = "ResponsiJuniorProject";
            Text = "Responsi Junior Project";
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNama;
        private Label labelDepartment;
        private TextBox textBoxNama;
        private ComboBox comboBoxDep;
        private Button btnInsert;
        private Button btnEdit;
        private Button btnDelete;
        private Label label3;
        private DataGridView dgvDataTable;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label labelJabatan;
        private ComboBox comboBoxJabatan;
        private Label label7;
        private PictureBox pictureBoxLogo;
    }
}