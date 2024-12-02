namespace ResponsiJuniorProject
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
            textBoxDepartment = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).BeginInit();
            SuspendLayout();
            // 
            // labelNama
            // 
            labelNama.AutoSize = true;
            labelNama.Location = new Point(54, 78);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(39, 15);
            labelNama.TabIndex = 0;
            labelNama.Text = "Nama";
            // 
            // labelDepartment
            // 
            labelDepartment.AutoSize = true;
            labelDepartment.Location = new Point(54, 128);
            labelDepartment.Name = "labelDepartment";
            labelDepartment.Size = new Size(66, 15);
            labelDepartment.TabIndex = 1;
            labelDepartment.Text = "Deparment";
            // 
            // textBoxNama
            // 
            textBoxNama.Location = new Point(144, 78);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(121, 23);
            textBoxNama.TabIndex = 2;
            // 
            // comboBoxDep
            // 
            comboBoxDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDep.FormattingEnabled = true;
            comboBoxDep.Location = new Point(144, 159);
            comboBoxDep.Name = "comboBoxDep";
            comboBoxDep.Size = new Size(121, 23);
            comboBoxDep.TabIndex = 3;
            comboBoxDep.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(81, 188);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(321, 191);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(556, 196);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Location = new Point(538, 71);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "ID Departmen";
            // 
            // dgvDataTable
            // 
            dgvDataTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDataTable.Location = new Point(54, 269);
            dgvDataTable.Name = "dgvDataTable";
            dgvDataTable.RowTemplate.Height = 25;
            dgvDataTable.Size = new Size(589, 150);
            dgvDataTable.TabIndex = 8;
            dgvDataTable.CellContentClick += dgvDataTable_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Location = new Point(538, 86);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 9;
            label1.Text = "HR: Human Resource";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Location = new Point(538, 101);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 10;
            label2.Text = "ENG: Engineering";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Location = new Point(538, 116);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 11;
            label4.Text = "DEV: Developer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Popup;
            label5.Location = new Point(538, 131);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 12;
            label5.Text = "PM: Product Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Location = new Point(538, 146);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 13;
            label6.Text = "FIN: Finance";
            // 
            // textBoxDepartment
            // 
            textBoxDepartment.Location = new Point(81, 369);
            textBoxDepartment.Name = "textBoxDepartment";
            textBoxDepartment.Size = new Size(121, 23);
            textBoxDepartment.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxDepartment);
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
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDataTable).EndInit();
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
        private TextBox textBoxDepartment;
    }
}