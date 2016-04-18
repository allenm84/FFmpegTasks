namespace FFmpegTasks
{
  partial class FileInfoEditor
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.txtPath = new System.Windows.Forms.TextBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // txtPath
      // 
      this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPath.Location = new System.Drawing.Point(0, 1);
      this.txtPath.Margin = new System.Windows.Forms.Padding(0);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(118, 20);
      this.txtPath.TabIndex = 0;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.txtPath, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.btnBrowse, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 23);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // btnBrowse
      // 
      this.btnBrowse.AutoSize = true;
      this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.btnBrowse.Location = new System.Drawing.Point(118, 0);
      this.btnBrowse.Margin = new System.Windows.Forms.Padding(0);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(32, 23);
      this.btnBrowse.TabIndex = 1;
      this.btnBrowse.Text = ". . .";
      this.btnBrowse.UseVisualStyleBackColor = true;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.RestoreDirectory = true;
      // 
      // FileInfoEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "FileInfoEditor";
      this.Size = new System.Drawing.Size(150, 23);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TextBox txtPath;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
  }
}
