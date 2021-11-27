
namespace GameOfLife
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.Container = new System.Windows.Forms.Panel();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.TickLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.TickEntry = new System.Windows.Forms.NumericUpDown();
            this.HeightEntry = new System.Windows.Forms.NumericUpDown();
            this.WidthEntry = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TickEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // Container
            // 
            this.Container.Controls.Add(this.SplitContainer);
            this.Container.Location = new System.Drawing.Point(50, 12);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(202, 87);
            this.Container.TabIndex = 0;
            // 
            // SplitContainer
            // 
            this.SplitContainer.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.SplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainer.Location = new System.Drawing.Point(0, 0);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.TickLabel);
            this.SplitContainer.Panel1.Controls.Add(this.WidthLabel);
            this.SplitContainer.Panel1.Controls.Add(this.HeightLabel);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.TickEntry);
            this.SplitContainer.Panel2.Controls.Add(this.HeightEntry);
            this.SplitContainer.Panel2.Controls.Add(this.WidthEntry);
            this.SplitContainer.Size = new System.Drawing.Size(202, 87);
            this.SplitContainer.SplitterDistance = 99;
            this.SplitContainer.TabIndex = 0;
            this.SplitContainer.TabStop = false;
            // 
            // TickLabel
            // 
            this.TickLabel.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TickLabel.Location = new System.Drawing.Point(3, 58);
            this.TickLabel.Name = "TickLabel";
            this.TickLabel.Size = new System.Drawing.Size(93, 26);
            this.TickLabel.TabIndex = 2;
            this.TickLabel.Text = "Tick (ms)";
            this.TickLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WidthLabel
            // 
            this.WidthLabel.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidthLabel.Location = new System.Drawing.Point(3, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(93, 29);
            this.WidthLabel.TabIndex = 1;
            this.WidthLabel.Text = "Šířka";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HeightLabel
            // 
            this.HeightLabel.Font = new System.Drawing.Font("Roboto Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightLabel.Location = new System.Drawing.Point(3, 29);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(93, 29);
            this.HeightLabel.TabIndex = 0;
            this.HeightLabel.Text = "Výška";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TickEntry
            // 
            this.TickEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TickEntry.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TickEntry.Location = new System.Drawing.Point(3, 61);
            this.TickEntry.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TickEntry.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TickEntry.Name = "TickEntry";
            this.TickEntry.Size = new System.Drawing.Size(93, 23);
            this.TickEntry.TabIndex = 2;
            this.TickEntry.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // HeightEntry
            // 
            this.HeightEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeightEntry.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.HeightEntry.Location = new System.Drawing.Point(3, 32);
            this.HeightEntry.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.HeightEntry.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.HeightEntry.Name = "HeightEntry";
            this.HeightEntry.Size = new System.Drawing.Size(93, 23);
            this.HeightEntry.TabIndex = 1;
            this.HeightEntry.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // WidthEntry
            // 
            this.WidthEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WidthEntry.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.WidthEntry.Location = new System.Drawing.Point(3, 3);
            this.WidthEntry.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.WidthEntry.Name = "WidthEntry";
            this.WidthEntry.Size = new System.Drawing.Size(93, 23);
            this.WidthEntry.TabIndex = 0;
            this.WidthEntry.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(113, 105);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartClicked);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 133);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.Container);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.Text = "Game of Life";
            this.Container.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TickEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Container;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.NumericUpDown HeightEntry;
        private System.Windows.Forms.NumericUpDown WidthEntry;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label TickLabel;
        private System.Windows.Forms.NumericUpDown TickEntry;
    }
}

