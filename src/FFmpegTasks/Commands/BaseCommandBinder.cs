using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FFmpegTasks
{
  public abstract class BaseCommandBinder<T> : IDisposable
  {
    protected T item;
    protected BaseCommand command;

    private int executionCount = 0;
    private bool disposed = false;

    public BaseCommandBinder(T item, BaseCommand command)
    {
      this.item = item;
      this.command = command;

      ReadCommandAsync();

      command.CanExecuteChanged += command_CanExecuteChanged;
      SubscribeClick(item_Click);
      SubscribeDispose(item_Disposed);
    }

    ~BaseCommandBinder()
    {
      Dispose(false);
      Debug.Fail("CommandBinder was not disposed!");
    }

    public int ExecutionCount
    {
      get { return executionCount; }
    }

    protected abstract void SetEnabled(bool enabled);
    protected abstract void SubscribeClick(EventHandler handler);
    protected abstract void SubscribeDispose(EventHandler handler);
    protected abstract void UnsubscribeClick(EventHandler handler);
    protected abstract void UnsubscribeDispose(EventHandler handler);

    private void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (command != null)
        {
          command.CanExecuteChanged -= command_CanExecuteChanged;
          command = null;
        }

        if (item != null)
        {
          UnsubscribeClick(item_Click);
          UnsubscribeDispose(item_Disposed);
          item = default(T);
        }

        GC.SuppressFinalize(this);
        disposed = true;
      }
    }

    private async void ReadCommandAsync()
    {
      if (disposed)
      {
        return;
      }

      await Task.Yield();
      ReadCommand();
    }

    private void ReadCommand()
    {
      if (disposed)
      {
        return;
      }

      SetEnabled(command.CanExecute(this));
    }

    private void command_CanExecuteChanged(object sender, EventArgs e)
    {
      ReadCommand();
    }

    private void item_Click(object sender, EventArgs e)
    {
      if (disposed)
      {
        return;
      }

      if (command.Invoke(this))
      {
        ++executionCount;
      }
    }

    private void item_Disposed(object sender, EventArgs e)
    {
      Dispose(true);
    }

    void IDisposable.Dispose()
    {
      Dispose(true);
    }
  }
}
