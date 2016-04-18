namespace FFmpegTasks
{
  partial class ArgsEditor
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.tpnlControls = new System.Windows.Forms.TableLayoutPanel();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.AutoScroll = true;
      this.panel1.Controls.Add(this.tpnlControls);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(150, 150);
      this.panel1.TabIndex = 0;
      // 
      // tpnlControls
      // 
      this.tpnlControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tpnlControls.AutoSize = true;
      this.tpnlControls.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.tpnlControls.ColumnCount = 2;
      this.tpnlControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tpnlControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tpnlControls.Location = new System.Drawing.Point(0, 0);
      this.tpnlControls.Name = "tpnlControls";
      this.tpnlControls.RowCount = 1;
      this.tpnlControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tpnlControls.Size = new System.Drawing.Size(150, 30);
      this.tpnlControls.TabIndex = 0;
      // 
      // ArgsEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.panel1);
      this.Name = "ArgsEditor";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tpnlControls;
  }
}
