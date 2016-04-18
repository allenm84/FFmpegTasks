using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace FFmpegTasks
{
  public class ControlCommandBinder : BaseCommandBinder<Control>
  {
    public ControlCommandBinder(Control control, BaseCommand command)
      : base(control, command)
    {

    }

    protected override void SetEnabled(bool enabled)
    {
      item.Enabled = enabled;
    }

    protected override void SubscribeClick(EventHandler handler)
    {
      item.Click += handler;
    }

    protected override void SubscribeDispose(EventHandler handler)
    {
      item.Disposed += handler;
    }

    protected override void UnsubscribeClick(EventHandler handler)
    {
      item.Click -= handler;
    }

    protected override void UnsubscribeDispose(EventHandler handler)
    {
      item.Disposed -= handler;
    }
  }
}
