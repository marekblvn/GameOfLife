using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GameOfLife
{
    public class Cell : PictureBox
    {
        public bool alive;
        public int aliveNeighbours, posX, posY;
        private WindowForm parent;
        public Cell (int pos_x, int pos_y, WindowForm parent)
        {
            this.Location = new Point(pos_x * 16, pos_y * 16);
            this.Size = new Size(16, 16);
            //this.BorderStyle = BorderStyle.FixedSingle;
            this.BackColor = Color.White;
            this.parent = parent;
            this.alive = false;
            this.aliveNeighbours = 0;
            this.posX = pos_x;
            this.posY = pos_y;
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (!this.parent.hoverMode && !this.parent.running)
            {
                this.BackColor = Color.Black;
                this.alive = true;
            }
        }
        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            if (this.parent.hoverMode && !this.parent.running)
            {
                this.BackColor = Color.Black;
                this.alive = true;
            }
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            ControlPaint.DrawBorder(pe.Graphics, ClientRectangle, Color.LightGray, ButtonBorderStyle.Solid);
        }
        public void UpdateAlive()
        {
            if (this.alive)
            {
                if (this.aliveNeighbours < 2)
                {
                    this.alive = false;
                    this.BackColor = Color.White;
                }
                else if (this.aliveNeighbours > 3)
                {
                    this.alive = false;
                    this.BackColor = Color.White;
                }
            }
            else
            {
                if (this.aliveNeighbours == 3)
                {
                    this.alive = true;
                    this.BackColor = Color.Black;
                }
            }
        }
    }
}
