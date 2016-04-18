using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegTasks
{
  [AttributeUsage(AttributeTargets.Property)]
  public class RangeAttribute : Attribute
  {
    public RangeAttribute(int min, int max)
    {
      Minimum = min;
      Maximum = max;
    }

    public int Minimum { get; private set; }
    public int Maximum { get; private set; }
  }
}
