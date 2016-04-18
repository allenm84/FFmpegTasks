using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FFmpegTasks
{
  /// <summary> Provides a base implementation for all commands. </summary>
  public abstract class BaseCommand : ICommand
  {
    /// <summary> Fires the CanExecuteChanged event. </summary>
    public void Refresh()
    {
      CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }

    /// <summary> Event fired when the CanExecute method needs to be re-evaluated. </summary>
    public event EventHandler CanExecuteChanged;

    /// <summary> Gets a value indicating if the command can execute. </summary>
    public bool CanExecute(object parameter)
    {
      return InternalCanExecute(parameter);
    }

    /// <summary> Execute method. </summary>
    public void Execute(object parameter)
    {
      Invoke(parameter);
    }

    /// <summary>Invokes a command by calling Execute, but only if the command can be executed.</summary>
    /// <param name="parameter">A parameter to pass to the command.</param>
    /// <returns>True if the command was executed; otherwise false.</returns>
    public bool Invoke(object parameter)
    {
      if (!CanExecute(parameter))
      {
        return false;
      }

      // if we use "Execute" here, an infinite loop will occur.
      InternalExecute(parameter);
      return true;
    }

    /// <summary>Gets a value indicating if the command can execute. </summary>
    protected abstract bool InternalCanExecute(object parameter);

    /// <summary> Execute method. </summary>
    protected abstract void InternalExecute(object parameter);
  }
}
