// ============================================================
// Ticket Application System
// Module: Software Design and Testing C# — SDT621 | NQF Level 6
// Institution: CTU Training Solutions (PTY) Ltd
// Member 2: UI Developer — Dewald Van Jaarsveldt (20230258)
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketApplicationSystem
{
    public partial class Form1 : Form
    {
        // -------------------------------------------------------
        // Constructor — sets form properties
        // -------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            this.Text = "Ticket Application System";
            this.Size = new Size(520, 620);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            btnCalculate.Click += btnCalculate_Click;
            btnClear.Click += btnClear_Click;
            btnExit.Click += btnExit_Click;
        }

        // -------------------------------------------------------
        // Exit button — closes the application
        // -------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Enter passenger name");
                return;
            }

            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Enter valid age");
                return;
            }

            if (!double.TryParse(txtDistance.Text, out double distance))
            {
                MessageBox.Show("Enter valid distance");
                return;
            }

            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Select category");
                return;
            }

            if (!rdbMale.Checked && !rdbFemale.Checked)
            {
                MessageBox.Show("Select gender");
                return;
            }

            bool isFemale = rdbFemale.Checked;

            double price = TicketCalculator.CalculatePrice(age, distance, cmbCategory.SelectedIndex, isFemale);

            string gender = rdbMale.Checked ? "Male" : "Female";
            string category = cmbCategory.SelectedItem.ToString();

            lblSummaryOutput.ForeColor = Color.Black;
            lblSummaryOutput.Text =
                $"Passenger Name: {name}\n" +
                $"Gender: {gender}\n" +
                $"Age: {age}\n" +
                $"Category: {category}\n" +
                $"Distance: {distance} km\n" +
                $"Final Price: R{price}";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtDistance.Clear();
            rdbMale.Checked = true;
            cmbCategory.SelectedIndex = 0;
            lblSummaryOutput.Text = "Fill in the form above and click Calculate.";
            lblSummaryOutput.ForeColor = Color.Gray;
        }
    }
}