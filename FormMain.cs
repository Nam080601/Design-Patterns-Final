using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns_Final
{
    public partial class FormMain : Form
    {
        private Button currentBtn;
        private Form activeForm;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Load Coffee Panel
            btnCoffee.PerformClick();
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentBtn != btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#205375");
                    currentBtn = (Button)btnSender;
                    currentBtn.BackColor = color;
                    currentBtn.ForeColor = Color.White;
                    currentBtn.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control prevBtn in panelMenu.Controls)
            {
                if (prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(51, 51, 76);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(activeForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCoffee(), sender);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThem(), sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormHoaDon(), sender);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormThanhToan(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
