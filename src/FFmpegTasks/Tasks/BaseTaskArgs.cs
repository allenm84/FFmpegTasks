using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FFmpegTasks
{
  public abstract class BaseTaskArgs : BaseNotifyPropertyChanged
  {
    private readonly Dictionary<string, object> mFields = new Dictionary<string, object>();

    protected T GetField<T>([CallerMemberName] string key = "")
    {
      object value;
      if (!mFields.TryGetValue(key, out value))
      {
        value = default(T);
        mFields[key] = value;
      }
      return (T)value;
    }

    protected void SetField<T>(T value, [CallerMemberName] string key = "", bool force = true)
    {
      if (force || ValueChanged(key, value))
      {
        PushValue(key, value);
      }
    }

    private bool ValueChanged<T>(string key, T value)
    {
      return !(GetField<T>(key).Equals(value));
    }

    private void PushValue(string key, object value)
    {
      mFields[key] = value;
      FirePropertyChanged(key);
    }
  }
}
