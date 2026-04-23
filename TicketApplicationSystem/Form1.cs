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
        }

        // -------------------------------------------------------
        // Exit button — closes the application
        // -------------------------------------------------------
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // -------------------------------------------------------
        // btnCalculate_Click and btnClear_Click
        // will be implemented by Member 3 (Logic Developer)
        // -------------------------------------------------------
    }
}