using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public static class FactoryHelper
  {
    static readonly List<BaseControlFactory> mFactories = new List<BaseControlFactory>();
    static FactoryHelper()
    {
      var type = typeof(BaseControlFactory);
      mFactories.AddRange(type.Assembly.GetTypes()
        .Where(t => !t.IsAbstract && t.IsSubclassOf(type))
        .Select(Activator.CreateInstance)
        .Cast<BaseControlFactory>());
    }

    public static Control Create(BaseTaskArgs args, PropertyDescriptor property)
    {
      Control control = null;

      foreach (var factory in mFactories)
      {
        if (factory.CreateControl(args, property, out control))
        {
          break;
        }
      }

      return control;
    }
  }
}
