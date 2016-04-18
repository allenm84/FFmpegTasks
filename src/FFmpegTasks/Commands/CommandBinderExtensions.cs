using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace FFmpegTasks
{
  public static class CommandBinderExtensions
  {
    public static ControlCommandBinder Bind(this Control control, BaseCommand command)
    {
      return new ControlCommandBinder(control, command);
    }

    public static ToolStripItemCommandBinder Bind(this ToolStripItem item, BaseCommand command)
    {
      return new ToolStripItemCommandBinder(item, command);
    }
  }
}
