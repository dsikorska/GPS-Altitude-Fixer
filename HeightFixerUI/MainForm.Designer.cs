namespace HeightFixerUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.inputFileValue = new System.Windows.Forms.TextBox();
            this.outputFileValue = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.browseInputButton = new System.Windows.Forms.Button();
            this.outputBrowseButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.ConvertProgresser = new System.ComponentModel.BackgroundWorker();
            this.inputPathLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputFileValue
            // 
            this.inputFileValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileValue.Enabled = false;
            this.inputFileValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputFileValue.Location = new System.Drawing.Point(14, 63);
            this.inputFileValue.Name = "inputFileValue";
            this.inputFileValue.Size = new System.Drawing.Size(680, 29);
            this.inputFileValue.TabIndex = 0;
            // 
            // outputFileValue
            // 
            this.outputFileValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFileValue.Enabled = false;
            this.outputFileValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputFileValue.Location = new System.Drawing.Point(14, 129);
            this.outputFileValue.Name = "outputFileValue";
            this.outputFileValue.Size = new System.Drawing.Size(680, 29);
            this.outputFileValue.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(14, 241);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(773, 30);
            this.progressBar.TabIndex = 2;
            // 
            // browseInputButton
            // 
            this.browseInputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseInputButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.browseInputButton.Location = new System.Drawing.Point(700, 63);
            this.browseInputButton.Name = "browseInputButton";
            this.browseInputButton.Size = new System.Drawing.Size(87, 29);
            this.browseInputButton.TabIndex = 3;
            this.browseInputButton.Text = "Browse...";
            this.browseInputButton.UseVisualStyleBackColor = true;
            this.browseInputButton.Click += new System.EventHandler(this.browseInputButton_Click);
            // 
            // outputBrowseButton
            // 
            this.outputBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputBrowseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputBrowseButton.Location = new System.Drawing.Point(700, 129);
            this.outputBrowseButton.Name = "outputBrowseButton";
            this.outputBrowseButton.Size = new System.Drawing.Size(87, 29);
            this.outputBrowseButton.TabIndex = 4;
            this.outputBrowseButton.Text = "Browse...";
            this.outputBrowseButton.UseVisualStyleBackColor = true;
            this.outputBrowseButton.Click += new System.EventHandler(this.outputBrowseButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.startButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startButton.Location = new System.Drawing.Point(341, 179);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(119, 38);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Convert";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // ConvertProgresser
            // 
            this.ConvertProgresser.WorkerReportsProgress = true;
            this.ConvertProgresser.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ConvertProgresser_DoWork);
            this.ConvertProgresser.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ConvertProgresser_ProgressChanged);
            this.ConvertProgresser.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ConvertProgresser_RunWorkerCompleted);
            // 
            // inputPathLabel
            // 
            this.inputPathLabel.AutoSize = true;
            this.inputPathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputPathLabel.Location = new System.Drawing.Point(10, 35);
            this.inputPathLabel.Name = "inputPathLabel";
            this.inputPathLabel.Size = new System.Drawing.Size(109, 21);
            this.inputPathLabel.TabIndex = 6;
            this.inputPathLabel.Text = "Input file path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Output file path:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutStripButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 285);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputPathLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputBrowseButton);
            this.Controls.Add(this.browseInputButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.outputFileValue);
            this.Controls.Add(this.inputFileValue);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainForm";
            this.Text = "GPS Altitude Fixer v1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileValue;
        private System.Windows.Forms.TextBox outputFileValue;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button browseInputButton;
        private System.Windows.Forms.Button outputBrowseButton;
        private System.Windows.Forms.Button startButton;
        private System.ComponentModel.BackgroundWorker ConvertProgresser;
        private System.Windows.Forms.Label inputPathLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

