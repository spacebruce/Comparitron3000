﻿namespace comparitron.ui
{
    partial class FormMain
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutLeft = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxViewMode = new System.Windows.Forms.ComboBox();
            this.trackbarFade = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackbarFrame = new System.Windows.Forms.TrackBar();
            this.comparisonViewer = new comparitron.ui.ComparisonViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.tableLayoutLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1532, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1532, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 24);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.tableLayoutLeft);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerMain.Size = new System.Drawing.Size(1532, 697);
            this.splitContainerMain.SplitterDistance = 739;
            this.splitContainerMain.TabIndex = 2;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tableLayoutLeft
            // 
            this.tableLayoutLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutLeft.ColumnCount = 2;
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutLeft.Controls.Add(this.comparisonViewer, 0, 1);
            this.tableLayoutLeft.Controls.Add(this.comboBoxViewMode, 0, 0);
            this.tableLayoutLeft.Controls.Add(this.trackbarFade, 1, 0);
            this.tableLayoutLeft.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutLeft.Controls.Add(this.trackbarFrame, 0, 3);
            this.tableLayoutLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLeft.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutLeft.Name = "tableLayoutLeft";
            this.tableLayoutLeft.RowCount = 4;
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutLeft.Size = new System.Drawing.Size(737, 695);
            this.tableLayoutLeft.TabIndex = 0;
            // 
            // comboBoxViewMode
            // 
            this.comboBoxViewMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxViewMode.FormattingEnabled = true;
            this.comboBoxViewMode.Location = new System.Drawing.Point(3, 4);
            this.comboBoxViewMode.Name = "comboBoxViewMode";
            this.comboBoxViewMode.Size = new System.Drawing.Size(121, 21);
            this.comboBoxViewMode.TabIndex = 1;
            // 
            // trackbarFade
            // 
            this.trackbarFade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarFade.Location = new System.Drawing.Point(130, 3);
            this.trackbarFade.MaximumSize = new System.Drawing.Size(0, 25);
            this.trackbarFade.Name = "trackbarFade";
            this.trackbarFade.Size = new System.Drawing.Size(606, 24);
            this.trackbarFade.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutLeft.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 636);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(733, 26);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // trackbarFrame
            // 
            this.tableLayoutLeft.SetColumnSpan(this.trackbarFrame, 2);
            this.trackbarFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackbarFrame.Location = new System.Drawing.Point(3, 668);
            this.trackbarFrame.Name = "trackbarFrame";
            this.trackbarFrame.Size = new System.Drawing.Size(733, 24);
            this.trackbarFrame.TabIndex = 4;
            // 
            // comparisonViewer
            // 
            this.comparisonViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutLeft.SetColumnSpan(this.comparisonViewer, 2);
            this.comparisonViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comparisonViewer.Location = new System.Drawing.Point(3, 33);
            this.comparisonViewer.Name = "comparisonViewer";
            this.comparisonViewer.Size = new System.Drawing.Size(733, 597);
            this.comparisonViewer.TabIndex = 0;
            this.comparisonViewer.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 695);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 743);
            this.Controls.Add(this.splitContainerMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Comparitron 3000";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.tableLayoutLeft.ResumeLayout(false);
            this.tableLayoutLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comparisonViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLeft;
        private ComparisonViewer comparisonViewer;
        private System.Windows.Forms.ComboBox comboBoxViewMode;
        private System.Windows.Forms.TrackBar trackbarFade;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar trackbarFrame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

