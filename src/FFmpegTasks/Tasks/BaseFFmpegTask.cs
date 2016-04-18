using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegTasks
{
  public abstract class BaseFFmpegTask
  {
    private readonly DelegateCommand mRunCommand;
    private readonly string mDisplayName;
    private readonly BaseTaskArgs mArgs;

    public BaseFFmpegTask()
    {
      mRunCommand = new DelegateCommand(DoRun, CanRun);
      mDisplayName = GetType().Name;
      mArgs = CreateArgs();
      mArgs.PropertyChanged += mArgs_PropertyChanged;
    }

    public BaseTaskArgs Args
    {
      get { return mArgs; }
    }

    public BaseCommand RunCommand
    {
      get { return mRunCommand; }
    }

    public virtual string DisplayName
    {
      get { return mDisplayName; }
    }

    protected abstract BaseTaskArgs CreateArgs();

    protected abstract bool CanRun();

    protected abstract void DoRun();

    private void mArgs_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      mRunCommand.Refresh();
    }
  }
}
