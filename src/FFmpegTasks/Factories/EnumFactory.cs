using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public class EnumFactory : BaseControlFactory
  {
    public override bool CreateControl(BaseTaskArgs args, PropertyDescriptor property, out Control control)
    {
      control = null;

      var type = property.PropertyType;
      if (type.IsEnum)
      {
        var converter = TypeDescriptor.GetConverter(type);
        var comboBox = new ComboBox();

        comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox.DataSource = Enum.GetValues(type)
          .Cast<object>()
          .Select(v => new { Display = converter.ConvertToString(v), Value = v })
          .ToList();
        comboBox.DisplayMember = "Display";
        comboBox.ValueMember = "Value";
        comboBox.DataBindings.Add("SelectedValue", args, property.Name, true, DataSourceUpdateMode.OnPropertyChanged);

        control = comboBox;
      }

      return (control != null);
    }
  }
}
