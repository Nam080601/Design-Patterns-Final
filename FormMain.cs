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
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentBtn != btnSender)
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
            foreach(Control prevBtn in panelMenu.Controls)
            {
                if(prevBtn.GetType() == typeof(Button))
                {
                    prevBtn.BackColor = Color.FromArgb(51,51,76);
                    prevBtn.ForeColor = Color.Gainsboro;
                    prevBtn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btnCoffee_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
