// ============================================================
// Ticket Application System
// Module: Software Design and Testing C# — SDT621 | NQF Level 6
// Institution: CTU Training Solutions (PTY) Ltd
// Member 2: UI Developer — Dewald Van Jaarsveldt (20230258)
// Responsibilities: Design the Windows Form interface,
//                   add all controls, improve layout and appearance.
// ============================================================

using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicketApplicationSystem
{
    public partial class Form1 : Form
    {
        // -------------------------------------------------------
        // Constructor
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
        }

        // -------------------------------------------------------
        // InitializeComponent
        // Declares, configures and adds all controls to the form
        // -------------------------------------------------------
        private void InitializeComponent()
        {
            // ── Title label ──────────────────────────────────────
            lblTitle = new Label();
            lblTitle.Text = "Ticket Application System";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 80, 150);
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(480, 40);
            lblTitle.Location = new Point(20, 15);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            // ── Divider panel ────────────────────────────────────
            pnlDivider = new Panel();
            pnlDivider.BackColor = Color.FromArgb(30, 80, 150);
            pnlDivider.Size = new Size(460, 2);
            pnlDivider.Location = new Point(20, 58);

            // ── Passenger Name ───────────────────────────────────
            lblName = new Label();
            lblName.Text = "Passenger Name:";
            lblName.Location = new Point(30, 80);
            lblName.AutoSize = true;

            txtName = new TextBox();
            txtName.Name = "txtName";
            txtName.Location = new Point(200, 77);
            txtName.Size = new Size(260, 26);
            txtName.PlaceholderText = "Enter full name";

            // ── Gender ───────────────────────────────────────────
            lblGender = new Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new Point(30, 122);
            lblGender.AutoSize = true;

            // GroupBox keeps radio buttons logically grouped
            grpGender = new GroupBox();
            grpGender.Text = "";
            grpGender.Location = new Point(195, 113);
            grpGender.Size = new Size(270, 40);
            grpGender.FlatStyle = FlatStyle.Flat;

            rdbMale = new RadioButton();
            rdbMale.Name = "rdbMale";
            rdbMale.Text = "Male";
            rdbMale.Location = new Point(5, 12);
            rdbMale.AutoSize = true;
            rdbMale.Checked = true;   // Default selection

            rdbFemale = new RadioButton();
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Text = "Female";
            rdbFemale.Location = new Point(100, 12);
            rdbFemale.AutoSize = true;

            grpGender.Controls.Add(rdbMale);
            grpGender.Controls.Add(rdbFemale);

            // ── Age ──────────────────────────────────────────────
            lblAge = new Label();
            lblAge.Text = "Age:";
            lblAge.Location = new Point(30, 168);
            lblAge.AutoSize = true;

            txtAge = new TextBox();
            txtAge.Name = "txtAge";
            txtAge.Location = new Point(200, 165);
            txtAge.Size = new Size(260, 26);
            txtAge.PlaceholderText = "Enter age (e.g. 25)";

            // ── Travel Category ──────────────────────────────────
            lblCategory = new Label();
            lblCategory.Text = "Travel Category:";
            lblCategory.Location = new Point(30, 213);
            lblCategory.AutoSize = true;

            cmbCategory = new ComboBox();
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Location = new Point(200, 210);
            cmbCategory.Size = new Size(260, 26);
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;  // Prevent free-text entry
            cmbCategory.Items.AddRange(new string[]
            {
                "Category One   — R20/km",
                "Category Two   — R35/km",
                "Category Three — R50/km"
            });
            cmbCategory.SelectedIndex = 0;   // Default to first option

            // ── Travel Distance ──────────────────────────────────
            lblDistance = new Label();
            lblDistance.Text = "Travel Distance (km):";
            lblDistance.Location = new Point(30, 258);
            lblDistance.AutoSize = true;

            txtDistance = new TextBox();
            txtDistance.Name = "txtDistance";
            txtDistance.Location = new Point(200, 255);
            txtDistance.Size = new Size(260, 26);
            txtDistance.PlaceholderText = "Enter distance in km";

            // ── Second divider ───────────────────────────────────
            pnlDivider2 = new Panel();
            pnlDivider2.BackColor = Color.LightGray;
            pnlDivider2.Size = new Size(460, 1);
            pnlDivider2.Location = new Point(20, 300);

            // ── Summary panel (output area) ──────────────────────
            // Member 3 will write the ticket result into lblSummaryOutput.Text
            lblSummaryTitle = new Label();
            lblSummaryTitle.Text = "Ticket Summary";
            lblSummaryTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(30, 80, 150);
            lblSummaryTitle.Location = new Point(30, 315);
            lblSummaryTitle.AutoSize = true;

            pnlSummary = new Panel();
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Location = new Point(30, 345);
            pnlSummary.Size = new Size(440, 130);
            pnlSummary.BackColor = Color.White;
            pnlSummary.BorderStyle = BorderStyle.FixedSingle;

            lblSummaryOutput = new Label();
            lblSummaryOutput.Name = "lblSummaryOutput";
            lblSummaryOutput.Text = "Fill in the form above and click Calculate.";
            lblSummaryOutput.ForeColor = Color.Gray;
            lblSummaryOutput.Location = new Point(10, 10);
            lblSummaryOutput.Size = new Size(420, 110);
            lblSummaryOutput.Font = new Font("Segoe UI", 9.5F);

            pnlSummary.Controls.Add(lblSummaryOutput);

            // ── Buttons ──────────────────────────────────────────

            // Calculate button — event handler wired by Member 3
            btnCalculate = new Button();
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Calculate Ticket Price";
            btnCalculate.Location = new Point(30, 500);
            btnCalculate.Size = new Size(180, 40);
            btnCalculate.BackColor = Color.FromArgb(30, 80, 150);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCalculate.Cursor = Cursors.Hand;

            // Clear button — event handler wired by Member 3
            btnClear = new Button();
            btnClear.Name = "btnClear";
            btnClear.Text = "Clear Form";
            btnClear.Location = new Point(230, 500);
            btnClear.Size = new Size(120, 40);
            btnClear.BackColor = Color.FromArgb(220, 220, 220);
            btnClear.ForeColor = Color.Black;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 10F);
            btnClear.Cursor = Cursors.Hand;

            // Exit button — closes the application
            btnExit = new Button();
            btnExit.Name = "btnExit";
            btnExit.Text = "Exit";
            btnExit.Location = new Point(365, 500);
            btnExit.Size = new Size(105, 40);
            btnExit.BackColor = Color.FromArgb(180, 50, 50);
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Click += (s, e) => Application.Exit();

            // ── Add all controls to the form ─────────────────────
            this.Controls.AddRange(new Control[]
            {
                lblTitle,
                pnlDivider,
                lblName,        txtName,
                lblGender,      grpGender,
                lblAge,         txtAge,
                lblCategory,    cmbCategory,
                lblDistance,    txtDistance,
                pnlDivider2,
                lblSummaryTitle,
                pnlSummary,
                btnCalculate,
                btnClear,
                btnExit
            });
        }

        // -------------------------------------------------------
        // Control declarations
        // Named using correct conventions (prefix + PascalCase)
        // as per group README naming conventions
        // -------------------------------------------------------
        private Label lblTitle;
        private Label lblName;          // README: txtName companion
        private Label lblGender;
        private Label lblAge;
        private Label lblCategory;
        private Label lblDistance;
        private Label lblSummaryTitle;
        private Label lblSummaryOutput;

        private TextBox txtName;          // README: txtName
        private TextBox txtAge;           // README: txtAge
        private TextBox txtDistance;      // README: txtDistance

        private GroupBox grpGender;        // README: grpGender
        private RadioButton rdbMale;          // README: rdbMale
        private RadioButton rdbFemale;        // README: rdbFemale

        private ComboBox cmbCategory;      // README: cmbCategory

        private Panel pnlDivider;
        private Panel pnlDivider2;
        private Panel pnlSummary;

        private Button btnCalculate;     // README: btnCalculate
        private Button btnClear;         // README: btnClear
        private Button btnExit;          // README: btnExit
    }
}