using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public abstract class BaseControlFactory
  {
    public abstract bool CreateControl(BaseTaskArgs args, PropertyDescriptor property, out Control control);
  }
}
