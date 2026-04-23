// ============================================================
// Form1.Designer.cs
// Auto-generated style control definitions
// Member 2: UI Developer — Dewald Van Jaarsveldt (20230258)
// ============================================================

namespace TicketApplicationSystem
{
    partial class Form1
    {
        // Required designer variable
        private System.ComponentModel.IContainer components = null;

        // -------------------------------------------------------
        // Clean up resources on form close
        // -------------------------------------------------------
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // -------------------------------------------------------
        // InitializeComponent
        // All controls declared, configured and added here
        // -------------------------------------------------------
        private void InitializeComponent()
        {
            // ── Title label ──────────────────────────────────────
            lblTitle = new System.Windows.Forms.Label();
            lblTitle.Text = "Ticket Application System";
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 80, 150);
            lblTitle.AutoSize = false;
            lblTitle.Size = new System.Drawing.Size(480, 40);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── Top divider ──────────────────────────────────────
            pnlDivider = new System.Windows.Forms.Panel();
            pnlDivider.BackColor = System.Drawing.Color.FromArgb(30, 80, 150);
            pnlDivider.Size = new System.Drawing.Size(460, 2);
            pnlDivider.Location = new System.Drawing.Point(20, 58);

            // ── Passenger Name ───────────────────────────────────
            lblName = new System.Windows.Forms.Label();
            lblName.Text = "Passenger Name:";
            lblName.Location = new System.Drawing.Point(30, 80);
            lblName.AutoSize = true;

            txtName = new System.Windows.Forms.TextBox();
            txtName.Name = "txtName";
            txtName.Location = new System.Drawing.Point(200, 77);
            txtName.Size = new System.Drawing.Size(260, 26);
            txtName.PlaceholderText = "Enter full name";

            // ── Gender ───────────────────────────────────────────
            lblGender = new System.Windows.Forms.Label();
            lblGender.Text = "Gender:";
            lblGender.Location = new System.Drawing.Point(30, 122);
            lblGender.AutoSize = true;

            grpGender = new System.Windows.Forms.GroupBox();
            grpGender.Text = "";
            grpGender.Location = new System.Drawing.Point(195, 113);
            grpGender.Size = new System.Drawing.Size(270, 40);
            grpGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

            rdbMale = new System.Windows.Forms.RadioButton();
            rdbMale.Name = "rdbMale";
            rdbMale.Text = "Male";
            rdbMale.Location = new System.Drawing.Point(5, 12);
            rdbMale.AutoSize = true;
            rdbMale.Checked = true;

            rdbFemale = new System.Windows.Forms.RadioButton();
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Text = "Female";
            rdbFemale.Location = new System.Drawing.Point(100, 12);
            rdbFemale.AutoSize = true;

            grpGender.Controls.Add(rdbMale);
            grpGender.Controls.Add(rdbFemale);

            // ── Age ──────────────────────────────────────────────
            lblAge = new System.Windows.Forms.Label();
            lblAge.Text = "Age:";
            lblAge.Location = new System.Drawing.Point(30, 168);
            lblAge.AutoSize = true;

            txtAge = new System.Windows.Forms.TextBox();
            txtAge.Name = "txtAge";
            txtAge.Location = new System.Drawing.Point(200, 165);
            txtAge.Size = new System.Drawing.Size(260, 26);
            txtAge.PlaceholderText = "Enter age (e.g. 25)";

            // ── Travel Category ──────────────────────────────────
            lblCategory = new System.Windows.Forms.Label();
            lblCategory.Text = "Travel Category:";
            lblCategory.Location = new System.Drawing.Point(30, 213);
            lblCategory.AutoSize = true;

            cmbCategory = new System.Windows.Forms.ComboBox();
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Location = new System.Drawing.Point(200, 210);
            cmbCategory.Size = new System.Drawing.Size(260, 26);
            cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new string[]
            {
                "Category One   - R20/km",
                "Category Two   - R35/km",
                "Category Three - R50/km"
            });
            cmbCategory.SelectedIndex = 0;

            // ── Travel Distance ──────────────────────────────────
            lblDistance = new System.Windows.Forms.Label();
            lblDistance.Text = "Travel Distance (km):";
            lblDistance.Location = new System.Drawing.Point(30, 258);
            lblDistance.AutoSize = true;

            txtDistance = new System.Windows.Forms.TextBox();
            txtDistance.Name = "txtDistance";
            txtDistance.Location = new System.Drawing.Point(200, 255);
            txtDistance.Size = new System.Drawing.Size(260, 26);
            txtDistance.PlaceholderText = "Enter distance in km";

            // ── Bottom divider ───────────────────────────────────
            pnlDivider2 = new System.Windows.Forms.Panel();
            pnlDivider2.BackColor = System.Drawing.Color.LightGray;
            pnlDivider2.Size = new System.Drawing.Size(460, 1);
            pnlDivider2.Location = new System.Drawing.Point(20, 300);

            // ── Summary section ──────────────────────────────────
            lblSummaryTitle = new System.Windows.Forms.Label();
            lblSummaryTitle.Text = "Ticket Summary";
            lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(30, 80, 150);
            lblSummaryTitle.Location = new System.Drawing.Point(30, 315);
            lblSummaryTitle.AutoSize = true;

            // Member 3 writes ticket result into lblSummaryOutput.Text
            pnlSummary = new System.Windows.Forms.Panel();
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Location = new System.Drawing.Point(30, 345);
            pnlSummary.Size = new System.Drawing.Size(440, 130);
            pnlSummary.BackColor = System.Drawing.Color.White;
            pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            lblSummaryOutput = new System.Windows.Forms.Label();
            lblSummaryOutput.Name = "lblSummaryOutput";
            lblSummaryOutput.Text = "Fill in the form above and click Calculate.";
            lblSummaryOutput.ForeColor = System.Drawing.Color.Gray;
            lblSummaryOutput.Location = new System.Drawing.Point(10, 10);
            lblSummaryOutput.Size = new System.Drawing.Size(420, 110);
            lblSummaryOutput.Font = new System.Drawing.Font("Segoe UI", 9.5F);

            pnlSummary.Controls.Add(lblSummaryOutput);

            // ── Buttons ──────────────────────────────────────────

            btnCalculate = new System.Windows.Forms.Button();
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Text = "Calculate Ticket Price";
            btnCalculate.Location = new System.Drawing.Point(30, 500);
            btnCalculate.Size = new System.Drawing.Size(180, 40);
            btnCalculate.BackColor = System.Drawing.Color.FromArgb(30, 80, 150);
            btnCalculate.ForeColor = System.Drawing.Color.White;
            btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;

            btnClear = new System.Windows.Forms.Button();
            btnClear.Name = "btnClear";
            btnClear.Text = "Clear Form";
            btnClear.Location = new System.Drawing.Point(230, 500);
            btnClear.Size = new System.Drawing.Size(120, 40);
            btnClear.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            btnClear.ForeColor = System.Drawing.Color.Black;
            btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnClear.Cursor = System.Windows.Forms.Cursors.Hand;

            btnExit = new System.Windows.Forms.Button();
            btnExit.Name = "btnExit";
            btnExit.Text = "Exit";
            btnExit.Location = new System.Drawing.Point(365, 500);
            btnExit.Size = new System.Drawing.Size(105, 40);
            btnExit.BackColor = System.Drawing.Color.FromArgb(180, 50, 50);
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // ── Add all controls to form ─────────────────────────
            this.Controls.AddRange(new System.Windows.Forms.Control[]
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
        // Control declarations — naming conventions per README
        // -------------------------------------------------------
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblSummaryTitle;
        internal System.Windows.Forms.Label lblSummaryOutput;  // internal so Member 3 can access it

        internal System.Windows.Forms.TextBox txtName;           // README: txtName
        internal System.Windows.Forms.TextBox txtAge;            // README: txtAge
        internal System.Windows.Forms.TextBox txtDistance;       // README: txtDistance

        private System.Windows.Forms.GroupBox grpGender;         // README: grpGender
        internal System.Windows.Forms.RadioButton rdbMale;          // README: rdbMale
        internal System.Windows.Forms.RadioButton rdbFemale;        // README: rdbFemale

        internal System.Windows.Forms.ComboBox cmbCategory;       // README: cmbCategory

        private System.Windows.Forms.Panel pnlDivider;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Panel pnlSummary;

        internal System.Windows.Forms.Button btnCalculate;      // README: btnCalculate
        internal System.Windows.Forms.Button btnClear;          // README: btnClear
        internal System.Windows.Forms.Button btnExit;           // README: btnExit
    }
}