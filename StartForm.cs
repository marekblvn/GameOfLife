using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class StartForm : Form
    {
        public int WIDTH, HEIGHT, TICK;
        public WindowForm Window;

        private void StartClicked(object sender, EventArgs e)
        {
            if (this.Window == null)
            {
                this.WIDTH = Decimal.ToInt32(this.WidthEntry.Value);
                this.HEIGHT = Decimal.ToInt32(this.HeightEntry.Value);
                this.TICK = Decimal.ToInt32(this.TickEntry.Value);
                this.Window = new WindowForm(this);
                this.Window.Show();
            }
            else return;
        }

        public StartForm()
        {
            InitializeComponent();
            this.Window = null;
        }

    }
}
