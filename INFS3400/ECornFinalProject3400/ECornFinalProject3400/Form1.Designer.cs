namespace ECornFinalProject3400
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelAnimal = new System.Windows.Forms.Label();
            this.comboBoxAnimal = new System.Windows.Forms.ComboBox();
            this.labelSubType = new System.Windows.Forms.Label();
            this.comboBoxSubType = new System.Windows.Forms.ComboBox();
            this.checkBoxUniqueFeature = new System.Windows.Forms.CheckBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDisplayAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // labelAnimal
            this.labelAnimal.AutoSize = true;
            this.labelAnimal.Location = new System.Drawing.Point(30, 18);
            this.labelAnimal.Name = "labelAnimal";
            this.labelAnimal.Size = new System.Drawing.Size(38, 13);
            this.labelAnimal.TabIndex = 10;
            this.labelAnimal.Text = "Animal";

            // comboBoxAnimal
            this.comboBoxAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnimal.FormattingEnabled = true;
            this.comboBoxAnimal.Items.AddRange(new object[] { "Mammal", "Bird", "Fish" });
            this.comboBoxAnimal.Location = new System.Drawing.Point(30, 37);
            this.comboBoxAnimal.Name = "comboBoxAnimal";
            this.comboBoxAnimal.Size = new System.Drawing.Size(200, 21);
            this.comboBoxAnimal.TabIndex = 0;
            this.comboBoxAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnimal_SelectedIndexChanged);

            // labelSubType
            this.labelSubType.AutoSize = true;
            this.labelSubType.Location = new System.Drawing.Point(30, 72);
            this.labelSubType.Name = "labelSubType";
            this.labelSubType.Size = new System.Drawing.Size(49, 13);
            this.labelSubType.TabIndex = 11;
            this.labelSubType.Text = "SubType";

            // comboBoxSubType
            this.comboBoxSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubType.FormattingEnabled = true;
            this.comboBoxSubType.Location = new System.Drawing.Point(30, 91);
            this.comboBoxSubType.Name = "comboBoxSubType";
            this.comboBoxSubType.Size = new System.Drawing.Size(200, 21);
            this.comboBoxSubType.TabIndex = 1;

            // checkBoxUniqueFeature
            this.checkBoxUniqueFeature.AutoSize = true;
            this.checkBoxUniqueFeature.Location = new System.Drawing.Point(30, 128);
            this.checkBoxUniqueFeature.Name = "checkBoxUniqueFeature";
            this.checkBoxUniqueFeature.Size = new System.Drawing.Size(101, 17);
            this.checkBoxUniqueFeature.TabIndex = 2;
            this.checkBoxUniqueFeature.Text = "Unique Feature";
            this.checkBoxUniqueFeature.UseVisualStyleBackColor = true;
            this.checkBoxUniqueFeature.CheckedChanged += new System.EventHandler(this.checkBoxUniqueFeature_CheckedChanged);

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 163);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";

            // textBoxName
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxName.Location = new System.Drawing.Point(30, 182);
            this.textBoxName.MaxLength = 15;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(160, 21);
            this.textBoxName.TabIndex = 3;

            // labelDOB
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(30, 218);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(64, 13);
            this.labelDOB.TabIndex = 13;
            this.labelDOB.Text = "Date of Birth";

            // dateTimePickerDOB
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(30, 237);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(160, 20);
            this.dateTimePickerDOB.TabIndex = 4;

            // labelDescription
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(30, 274);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 14;
            this.labelDescription.Text = "Description";

            // textBoxDescription
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBoxDescription.Location = new System.Drawing.Point(30, 293);
            this.textBoxDescription.MaxLength = 40;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(360, 60);
            this.textBoxDescription.TabIndex = 5;

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(234, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClose
            this.btnClose.Location = new System.Drawing.Point(320, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // btnDisplayAnimals
            this.btnDisplayAnimals.Location = new System.Drawing.Point(30, 375);
            this.btnDisplayAnimals.Name = "btnDisplayAnimals";
            this.btnDisplayAnimals.Size = new System.Drawing.Size(185, 23);
            this.btnDisplayAnimals.TabIndex = 8;
            this.btnDisplayAnimals.Text = "Display Saved Animals";
            this.btnDisplayAnimals.UseVisualStyleBackColor = true;
            this.btnDisplayAnimals.Click += new System.EventHandler(this.btnDisplayAnimals_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 420);
            this.Controls.Add(this.labelAnimal);
            this.Controls.Add(this.comboBoxAnimal);
            this.Controls.Add(this.labelSubType);
            this.Controls.Add(this.comboBoxSubType);
            this.Controls.Add(this.checkBoxUniqueFeature);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.dateTimePickerDOB);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDisplayAnimals);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animal Entry EC";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelAnimal;
        private System.Windows.Forms.ComboBox comboBoxAnimal;
        private System.Windows.Forms.Label labelSubType;
        private System.Windows.Forms.ComboBox comboBoxSubType;
        private System.Windows.Forms.CheckBox checkBoxUniqueFeature;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDisplayAnimals;
    }
}
