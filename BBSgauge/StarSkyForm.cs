using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BBSgauge
{
    public partial class StarSkyForm : Form
    {
        private BBS obj;
        private Graphics g;

        public StarSkyForm(BBS obj)
        {
            InitializeComponent();
            this.obj = obj;
        }

        private void StarSkyForm_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();
            this.BackColor = Color.DarkBlue;
        }

        private void StarSkyForm_Paint(object sender, PaintEventArgs e)
        {
            int max = obj.N;
            g.FillEllipse(Brushes.Yellow, 150, 200, 2, 2);
            for (int i = 0; i < obj.U.Count() - 1; i++)
            {
                long x = obj.U[i];
                long y = obj.U[i + 1];
                g.FillEllipse(Brushes.Yellow, this.Size.Height * x / max, this.Size.Width * y / max, 2, 2);
            }
        }
    }
}
