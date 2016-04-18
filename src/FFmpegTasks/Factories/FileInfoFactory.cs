using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public class FileInfoFactory : BaseControlFactory
  {
    public override bool CreateControl(BaseTaskArgs args, PropertyDescriptor property, out Control control)
    {
      control = null;

      if (property.PropertyType == typeof(FileInfo))
      {
        control = new FileInfoEditor(args, property);
      }

      return (control != null);
    }
  }
}
