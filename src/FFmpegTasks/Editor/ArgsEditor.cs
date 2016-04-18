using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FFmpegTasks
{
  public partial class ArgsEditor : UserControl
  {
    public ArgsEditor(BaseTaskArgs args)
    {
      InitializeComponent();

      bool firstRow = true;
      int row = 0;

      tpnlControls.SuspendLayout();

      var properties = TypeDescriptor.GetProperties(args);
      foreach (PropertyDescriptor prop in properties)
      {
        if (!firstRow)
        {
          tpnlControls.RowCount++;
          tpnlControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
        }

        var editor = FactoryHelper.Create(args, prop);
        if (editor != null)
        {
          editor.Dock = DockStyle.Fill;
          editor.Margin = new Padding(3);

          tpnlControls.Controls.Add(CreateLabel(prop), 0, row);
          tpnlControls.Controls.Add(editor, 1, row);

          firstRow = false;
          ++row;
        }
      }

      tpnlControls.ResumeLayout();
    }

    private Control CreateLabel(PropertyDescriptor prop)
    {
      var label = new Label { AutoSize = true };
      label.Anchor = AnchorStyles.Right;
      label.Text = prop.DisplayName;
      return label;
    }
  }
}
