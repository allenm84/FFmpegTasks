using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public class NumericFactory : BaseControlFactory
  {
    static readonly HashSet<Type> sNumericTypes = new HashSet<Type>();
    static NumericFactory()
    {
      sNumericTypes.Add(typeof(sbyte));
      sNumericTypes.Add(typeof(byte));
      sNumericTypes.Add(typeof(short));
      sNumericTypes.Add(typeof(ushort));
      sNumericTypes.Add(typeof(int));
      sNumericTypes.Add(typeof(uint));
      sNumericTypes.Add(typeof(long));
      sNumericTypes.Add(typeof(ulong));
      sNumericTypes.Add(typeof(float));
      sNumericTypes.Add(typeof(double));
      sNumericTypes.Add(typeof(decimal));
    }

    public override bool CreateControl(BaseTaskArgs args, PropertyDescriptor property, out Control control)
    {
      control = null;

      var type = property.PropertyType;
      if (sNumericTypes.Contains(type))
      {
        var numValue = new NumericUpDown();
        numValue.DataBindings.Add("Value", args, property.Name);

        var range = property.Attributes
          .Cast<Attribute>()
          .OfType<RangeAttribute>()
          .SingleOrDefault();

        if (range != null)
        {
          numValue.Minimum = range.Minimum;
          numValue.Maximum = range.Maximum;
        }

        control = numValue;
      }

      return (control != null);
    }
  }
}
