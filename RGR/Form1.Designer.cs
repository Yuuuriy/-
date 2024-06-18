namespace Lab2
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
            comboBoxCity = new ComboBox();
            comboBoxCountry = new ComboBox();
            lblResult = new Label();
            txtApartment = new TextBox();
            txtHouse = new TextBox();
            txtStreet = new TextBox();
            txtIndex = new TextBox();
            label8 = new Label();
            btnDelete = new Button();
            btnShow = new Button();
            btnEdit = new Button();
            btnCreate = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(179, 144);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(125, 28);
            comboBoxCity.TabIndex = 58;
            comboBoxCity.KeyPress += comboBoxCity_KeyPress;
            // 
            // comboBoxCountry
            // 
            comboBoxCountry.FormattingEnabled = true;
            comboBoxCountry.Location = new Point(179, 94);
            comboBoxCountry.Name = "comboBoxCountry";
            comboBoxCountry.Size = new Size(125, 28);
            comboBoxCountry.TabIndex = 57;
            comboBoxCountry.KeyPress += comboBoxCountry_KeyPress;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(493, 53);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(50, 20);
            lblResult.TabIndex = 56;
            lblResult.Text = "label9";
            // 
            // txtApartment
            // 
            txtApartment.Location = new Point(179, 283);
            txtApartment.Name = "txtApartment";
            txtApartment.Size = new Size(125, 27);
            txtApartment.TabIndex = 55;
            txtApartment.KeyPress += txtApartment_KeyPress;
            // 
            // txtHouse
            // 
            txtHouse.Location = new Point(179, 238);
            txtHouse.Name = "txtHouse";
            txtHouse.Size = new Size(125, 27);
            txtHouse.TabIndex = 48;
            txtHouse.KeyPress += txtHouse_KeyPress;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(179, 194);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(125, 27);
            txtStreet.TabIndex = 47;
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(179, 46);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(125, 27);
            txtIndex.TabIndex = 46;
            txtIndex.KeyPress += txtIndex_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(393, 53);
            label8.Name = "label8";
            label8.Size = new Size(50, 20);
            label8.TabIndex = 54;
            label8.Text = "label8";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(637, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(151, 43);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "button4";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(450, 380);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(151, 43);
            btnShow.TabIndex = 52;
            btnShow.Text = "button3";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(240, 358);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(151, 43);
            btnEdit.TabIndex = 51;
            btnEdit.Text = "button2";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(27, 380);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(151, 43);
            btnCreate.TabIndex = 50;
            btnCreate.Text = "button1";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 290);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 49;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 245);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 45;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 201);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 44;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 152);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 43;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 102);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 42;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 41;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 40;
            label1.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(240, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(151, 31);
            btnSave.TabIndex = 59;
            btnSave.Text = "button2";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(comboBoxCity);
            Controls.Add(comboBoxCountry);
            Controls.Add(lblResult);
            Controls.Add(txtApartment);
            Controls.Add(txtHouse);
            Controls.Add(txtStreet);
            Controls.Add(txtIndex);
            Controls.Add(label8);
            Controls.Add(btnDelete);
            Controls.Add(btnShow);
            Controls.Add(btnEdit);
            Controls.Add(btnCreate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxCity;
        private ComboBox comboBoxCountry;
        private Label lblResult;
        private TextBox txtApartment;
        private TextBox txtHouse;
        private TextBox txtStreet;
        private TextBox txtIndex;
        private Label label8;
        private Button btnDelete;
        private Button btnShow;
        private Button btnEdit;
        private Button btnCreate;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSave;
    }
}
