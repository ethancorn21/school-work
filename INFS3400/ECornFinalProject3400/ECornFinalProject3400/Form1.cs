/*
 * Name: Ethan Corn
 * Description: Final Project 3400
 * Task: This Animal Data Entry application allows users to enter animal records
 *       (type, subtype, name, birthdate, description, unique feature) and saves
 *       them to animal.txt in the application's running directory.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ECornFinalProject3400
{
    public partial class Form1 : Form
    {
        private Animal animal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplayAnimals_Click(object sender, EventArgs e)
        {
            if (!File.Exists("animal.txt"))
            {
                MessageBox.Show("No saved animals found.", "Saved Animals",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string[] lines = File.ReadAllLines("animal.txt");
            if (lines.Length == 0)
            {
                MessageBox.Show("No saved animals found.", "Saved Animals",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(string.Join(Environment.NewLine, lines), "Saved Animals",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            const string QUESTION = "Close Application?";
            const string TITLE = "Form Closing";
            var result = MessageBox.Show(QUESTION, TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Fires when user picks an animal type from comboBoxAnimal
        // Instantiates the correct subclass, updates the checkbox label to reflect
        // that type's unique feature, and populates sub type combo box
        private void comboBoxAnimal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAnimal.SelectedItem.Equals("Mammal"))
            {
                this.animal = new Mammal();
                checkBoxUniqueFeature.Text = "Has Fur?";
            }
            else if (comboBoxAnimal.SelectedItem.Equals("Bird"))
            {
                this.animal = new Bird();
                checkBoxUniqueFeature.Text = "Has Feathers?";
            }
            else if (comboBoxAnimal.SelectedItem.Equals("Fish"))
            {
                this.animal = new Fish();
                checkBoxUniqueFeature.Text = "Has Scales?";
            }
            else
            {
                return;
            }

            populate_SubTypes(this.animal.GetSubTypes());
        }

        // Updates subtype drop down based on whatever animal is selected in the animal drop down
        private void populate_SubTypes(List<string> subtypes)
        {
            comboBoxSubType.Items.Clear();
            foreach (string subtype in subtypes)
            {
                comboBoxSubType.Items.Add(subtype);
            }
            comboBoxSubType.SelectedIndex = 0;
        }

        // page 18 top of page, 
        private void checkBoxUniqueFeature_CheckedChanged(object sender, EventArgs e)
        {
            if (this.animal != null)
            {
                this.animal.SetUniqueValue(checkBoxUniqueFeature.Checked);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.animal == null)
            {
                MessageBox.Show("Please select an animal type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Please enter a name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxSubType.SelectedItem == null)
            {
                MessageBox.Show("Please select a subtype.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.animal.Name = textBoxName.Text;
            this.animal.Description = textBoxDescription.Text;
            this.animal.Birthdate = dateTimePickerDOB.Value.Date.ToShortDateString();
            this.animal.SubType = comboBoxSubType.SelectedItem.ToString();

            try
            {
                using (StreamWriter outputFile = new StreamWriter("animal.txt", true))
                {
                    outputFile.WriteLine(this.animal.ToString());
                }

                MessageBox.Show($"{this.animal.Name}'s Record Saved", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBoxName.Clear();
                textBoxDescription.Clear();
                checkBoxUniqueFeature.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
