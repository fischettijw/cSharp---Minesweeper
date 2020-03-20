using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp___Minesweeper
{
    public partial class FrmMinesweeper : Form
    {
            static int clientWidth = 600;
            static int clientHeight = 600;

        public FrmMinesweeper()
        {
            InitializeComponent();
        }

        private void FrmMinesweeper_Load(object sender, EventArgs e)
        {
            CustomizeForm();
        }


        private void CustomizeForm()
        {
            this.Text = "Minesweeper   by Joseph Fischetti";

            this.ClientSize = new Size(clientWidth, clientHeight);
            this.MaximizeBox = false;
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimizeBox = true;
            this.MinimumSize = new Size(this.Width, this.Height);

            //this.Icon = Properties.Resources.virus_image;

            int sW = Screen.PrimaryScreen.WorkingArea.Width;
            int sH = Screen.PrimaryScreen.WorkingArea.Height;
            int fW = this.Width;
            int fH = this.Height;
            this.Location = new Point((sW - fW) / 2, (sH - fH) / 2);
        }
    }
}
