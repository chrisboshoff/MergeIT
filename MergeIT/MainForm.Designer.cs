namespace MergeIT
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
            this.lstPdfInput = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPdfBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPdfOutputBrowse = new System.Windows.Forms.Button();
            this.saveFileDialogPdfOutput = new System.Windows.Forms.SaveFileDialog();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlCaption = new System.Windows.Forms.Panel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressMerge = new System.Windows.Forms.ProgressBar();
            this.openFileDialogPdfSources = new System.Windows.Forms.OpenFileDialog();
            this.btnMerge = new System.Windows.Forms.Button();
            this.picMerge = new System.Windows.Forms.PictureBox();
            this.pnlCaption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMerge)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPdfInput
            // 
            this.lstPdfInput.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPdfInput.FormattingEnabled = true;
            this.lstPdfInput.ItemHeight = 14;
            this.lstPdfInput.Location = new System.Drawing.Point(14, 122);
            this.lstPdfInput.Name = "lstPdfInput";
            this.lstPdfInput.Size = new System.Drawing.Size(601, 158);
            this.lstPdfInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select the PDF files you would like to merge";
            // 
            // btnPdfBrowse
            // 
            this.btnPdfBrowse.BackColor = System.Drawing.Color.SlateGray;
            this.btnPdfBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfBrowse.ForeColor = System.Drawing.Color.White;
            this.btnPdfBrowse.Location = new System.Drawing.Point(528, 95);
            this.btnPdfBrowse.Name = "btnPdfBrowse";
            this.btnPdfBrowse.Size = new System.Drawing.Size(87, 25);
            this.btnPdfBrowse.TabIndex = 2;
            this.btnPdfBrowse.Text = "Browse";
            this.btnPdfBrowse.UseVisualStyleBackColor = false;
            this.btnPdfBrowse.Click += new System.EventHandler(this.btnPdfBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the output file";
            // 
            // btnPdfOutputBrowse
            // 
            this.btnPdfOutputBrowse.BackColor = System.Drawing.Color.SlateGray;
            this.btnPdfOutputBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdfOutputBrowse.ForeColor = System.Drawing.Color.White;
            this.btnPdfOutputBrowse.Location = new System.Drawing.Point(528, 337);
            this.btnPdfOutputBrowse.Name = "btnPdfOutputBrowse";
            this.btnPdfOutputBrowse.Size = new System.Drawing.Size(87, 25);
            this.btnPdfOutputBrowse.TabIndex = 5;
            this.btnPdfOutputBrowse.Text = "Browse";
            this.btnPdfOutputBrowse.UseVisualStyleBackColor = false;
            this.btnPdfOutputBrowse.Click += new System.EventHandler(this.btnPdfOutputBrowse_Click);
            // 
            // saveFileDialogPdfOutput
            // 
            this.saveFileDialogPdfOutput.DefaultExt = "pdf";
            this.saveFileDialogPdfOutput.Filter = "Pdf files (*.pdf)|*.pdf|All files (*.*)|*.*\"";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(14, 364);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(601, 22);
            this.txtOutput.TabIndex = 6;
            // 
            // pnlCaption
            // 
            this.pnlCaption.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlCaption.Controls.Add(this.picMerge);
            this.pnlCaption.Controls.Add(this.lblCaption);
            this.pnlCaption.Location = new System.Drawing.Point(0, 0);
            this.pnlCaption.Name = "pnlCaption";
            this.pnlCaption.Size = new System.Drawing.Size(633, 66);
            this.pnlCaption.TabIndex = 8;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Tahoma", 16F);
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(17, 18);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(118, 27);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Merge PDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(275, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "ê";
            // 
            // progressMerge
            // 
            this.progressMerge.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressMerge.Location = new System.Drawing.Point(0, 453);
            this.progressMerge.Name = "progressMerge";
            this.progressMerge.Size = new System.Drawing.Size(633, 16);
            this.progressMerge.TabIndex = 10;
            this.progressMerge.Visible = false;
            // 
            // openFileDialogPdfSources
            // 
            this.openFileDialogPdfSources.DefaultExt = "pdf";
            this.openFileDialogPdfSources.Filter = "Pdf files (*.pdf)|*.pdf";
            this.openFileDialogPdfSources.Multiselect = true;
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.Green;
            this.btnMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMerge.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ForeColor = System.Drawing.Color.White;
            this.btnMerge.Location = new System.Drawing.Point(494, 406);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(121, 35);
            this.btnMerge.TabIndex = 11;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // picMerge
            // 
            this.picMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMerge.Image = ((System.Drawing.Image)(resources.GetObject("picMerge.Image")));
            this.picMerge.Location = new System.Drawing.Point(571, 8);
            this.picMerge.Name = "picMerge";
            this.picMerge.Size = new System.Drawing.Size(50, 50);
            this.picMerge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMerge.TabIndex = 1;
            this.picMerge.TabStop = false;
            this.picMerge.Click += new System.EventHandler(this.picMerge_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(633, 469);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.progressMerge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlCaption);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnPdfOutputBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPdfBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPdfInput);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MergeIT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlCaption.ResumeLayout(false);
            this.pnlCaption.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMerge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPdfInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPdfBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPdfOutputBrowse;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPdfOutput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Panel pnlCaption;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressMerge;
        private System.Windows.Forms.OpenFileDialog openFileDialogPdfSources;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.PictureBox picMerge;
    }
}

