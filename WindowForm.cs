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
    public partial class WindowForm : Form
    {
        private static int Modulo (int a, int b)
        {
            return (a % b + b) % b;
        }

        private StartForm parentForm;
        public bool running, hoverMode;
        public int W, H;
        private Cell[,] CellArray;
        public WindowForm(StartForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.Size = new Size((this.parentForm.WIDTH + 1) * 16, (this.parentForm.HEIGHT + 3) * 16 - 9);
            this.Text = "Game of Life (Edit: Click)";
            this.running = false;
            this.W = this.parentForm.WIDTH;
            this.H = this.parentForm.HEIGHT;
            this.CellArray = new Cell[this.H, this.W];
            this.hoverMode = false;
            this.RunTimer.Interval = this.parentForm.TICK;
            InitializeCells(this.W, this.H);
        }

        private void InitializeCells (int width, int height)
        {
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Cell toAdd = new Cell(x, y, this);
                    this.CellPanel.Controls.Add(toAdd);
                    this.CellArray[toAdd.posY, toAdd.posX] = toAdd;
                }
            }
            return;
        }

        private void OnClosed(object sender, FormClosedEventArgs e)
        {
            this.parentForm.Window = null;
            return;
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.H:
                    if (this.hoverMode)
                    {
                        this.hoverMode = false;
                        this.Text = "Game of Life (Edit: Click)";
                    }
                    else
                    {
                        this.hoverMode = true;
                        this.Text = "Game of Life (Edit: Hover)";
                    }
                    break;
                case Keys.R:
                    if (!this.running)
                        ResetAllCells();
                    break;
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.Enter:
                    if (this.running)
                    {
                        this.RunTimer.Stop();
                        this.Text = this.hoverMode ? "Game of Life (Edit: Hover)" : "Game of Life (Edit: Click)";
                        this.running = false;
                    }
                    else
                    {
                        this.RunTimer.Start();
                        this.Text = "Game of Life (Running...)";
                        this.running = true;
                    }
                    break;
            }
            return;
        }

        private void OnRunTick(object sender, EventArgs e)
        {
            // For all cells - GetAliveNeighbours
            UpdateAliveCount();
            // For all cells - Update based on aliveNeighbours
            UpdateCells();
        }

        private int GetAliveNeighbours (Cell cell)
        {
            int aliveNeighbours = 0;
            int Area = this.W * this.H;

            Cell Left = this.CellArray[
                cell.posY,
                Modulo(cell.posX - 1, this.W)];
            Cell Right = this.CellArray[
                cell.posY,
                Modulo(cell.posX + 1, this.W)];

            Cell AbLeft = this.CellArray[
                Modulo(cell.posY - 1, this.H),
                Modulo(cell.posX - 1, this.W)];
            Cell AbMid = this.CellArray[
                Modulo(cell.posY - 1, this.H),
                cell.posX];
            Cell AbRight = this.CellArray[
                Modulo(cell.posY - 1, this.H),
                Modulo(cell.posX + 1, this.W)];

            Cell BeLeft = this.CellArray[
                Modulo(cell.posY + 1, this.H),
                Modulo(cell.posX - 1, this.W)];
            Cell BeMid = this.CellArray[
                Modulo(cell.posY + 1, this.H),
                cell.posX];
            Cell BeRight = this.CellArray[
                Modulo(cell.posY + 1, this.H),
                Modulo(cell.posX + 1, this.W)];

            // Get alive neighbours
            if (Left.alive)
                aliveNeighbours += 1;
            if (Right.alive)
                aliveNeighbours += 1;
            if (AbLeft.alive)
                aliveNeighbours += 1;
            if (AbMid.alive)
                aliveNeighbours += 1;
            if (AbRight.alive)
                aliveNeighbours += 1;
            if (BeLeft.alive)
                aliveNeighbours += 1;
            if (BeMid.alive)
                aliveNeighbours += 1;
            if (BeRight.alive)
                aliveNeighbours += 1;

            return aliveNeighbours;
        }

        private void UpdateCells ()
        {
            foreach (Control obj in this.CellPanel.Controls)
            {
                Cell c = obj as Cell;
                c.UpdateAlive();
            }
        }

        private void UpdateAliveCount()
        {
            foreach (Control obj in this.CellPanel.Controls)
            {
                Cell c = obj as Cell;
                c.aliveNeighbours = GetAliveNeighbours(c);
            }
        }

        private void ResetAllCells()
        {
            foreach (Cell cell in this.CellArray)
            {
                if (cell.alive)
                {
                    cell.alive = false;
                    cell.BackColor = Color.White;
                }
            }
        }
    }
}
