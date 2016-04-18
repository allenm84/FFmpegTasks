namespace FFmpegTasks
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
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.panel1 = new System.Windows.Forms.Panel();
      this.lstTasks = new System.Windows.Forms.TreeView();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.pnlEditorContainer = new System.Windows.Forms.Panel();
      this.btnRun = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(10, 10);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      this.splitContainer1.Panel1.Controls.Add(this.label1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.panel2);
      this.splitContainer1.Panel2.Controls.Add(this.label2);
      this.splitContainer1.Size = new System.Drawing.Size(543, 328);
      this.splitContainer1.SplitterDistance = 181;
      this.splitContainer1.TabIndex = 0;
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.lstTasks);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 13);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(181, 315);
      this.panel1.TabIndex = 0;
      // 
      // lstTasks
      // 
      this.lstTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.lstTasks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lstTasks.FullRowSelect = true;
      this.lstTasks.HideSelection = false;
      this.lstTasks.ItemHeight = 20;
      this.lstTasks.Location = new System.Drawing.Point(0, 0);
      this.lstTasks.Name = "lstTasks";
      this.lstTasks.ShowLines = false;
      this.lstTasks.ShowPlusMinus = false;
      this.lstTasks.ShowRootLines = false;
      this.lstTasks.Size = new System.Drawing.Size(179, 313);
      this.lstTasks.TabIndex = 0;
      this.lstTasks.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lstTasks_AfterSelect);
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.tableLayoutPanel1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 13);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(358, 315);
      this.panel2.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.Controls.Add(this.pnlEditorContainer, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnRun, 1, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 313);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // pnlEditorContainer
      // 
      this.pnlEditorContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.tableLayoutPanel1.SetColumnSpan(this.pnlEditorContainer, 3);
      this.pnlEditorContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlEditorContainer.Location = new System.Drawing.Point(3, 3);
      this.pnlEditorContainer.Name = "pnlEditorContainer";
      this.pnlEditorContainer.Size = new System.Drawing.Size(350, 277);
      this.pnlEditorContainer.TabIndex = 0;
      // 
      // btnRun
      // 
      this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btnRun.Location = new System.Drawing.Point(141, 286);
      this.btnRun.Name = "btnRun";
      this.btnRun.Size = new System.Drawing.Size(74, 24);
      this.btnRun.TabIndex = 1;
      this.btnRun.Text = "Run";
      this.btnRun.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Margin = new System.Windows.Forms.Padding(3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Tasks:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Editor:";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(563, 348);
      this.Controls.Add(this.splitContainer1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "MainForm";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ffmpeg Tasks";
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      this.splitContainer1.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TreeView lstTasks;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel pnlEditorContainer;
    private System.Windows.Forms.Button btnRun;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
  }
}

