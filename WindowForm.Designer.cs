
namespace GameOfLife
{
    partial class WindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowForm));
            this.CellPanel = new System.Windows.Forms.Panel();
            this.RunTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CellPanel
            // 
            this.CellPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CellPanel.Location = new System.Drawing.Point(0, 0);
            this.CellPanel.Name = "CellPanel";
            this.CellPanel.Size = new System.Drawing.Size(144, 121);
            this.CellPanel.TabIndex = 0;
            // 
            // RunTimer
            // 
            this.RunTimer.Interval = 200;
            this.RunTimer.Tick += new System.EventHandler(this.OnRunTick);
            // 
            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(144, 121);
            this.ControlBox = false;
            this.Controls.Add(this.CellPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game of Life";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CellPanel;
        private System.Windows.Forms.Timer RunTimer;
    }
}