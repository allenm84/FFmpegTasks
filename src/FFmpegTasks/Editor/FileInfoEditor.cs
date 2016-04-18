using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FFmpegTasks
{
  public partial class FileInfoEditor : UserControl
  {
    private uint mId = 0;
    private bool mIgnorePropertyChanged = false;
    private bool mIgnoreTextChanged = false;

    private readonly BaseTaskArgs mArgs;
    private readonly PropertyDescriptor mProperty;

    public FileInfoEditor(BaseTaskArgs args, PropertyDescriptor property)
    {
      mArgs = args;
      mProperty = property;

      InitializeComponent();
      mArgs.PropertyChanged += mArgs_PropertyChanged;

      openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
      openFileDialog1.Filter = string.Format("Supported formats | {0}", ffmpeg.GetFormatFilter());

      ReadPropertyValue();

      btnBrowse.Click += btnBrowse_Click;
      txtPath.TextChanged += txtPath_TextChanged;
    }

    private void ReadPropertyValue()
    {
      mIgnoreTextChanged = true;

      var info = mProperty.GetValue(mArgs) as FileInfo;
      if (info != null)
      {
        txtPath.Text = info.FullName;
      }

      mIgnoreTextChanged = false;
    }

    private async void SetPropertyValueDebounce(string text)
    {
      uint id = ++mId;
      await Task.Yield();
      if (id == mId)
      {
        SetPropertyValue(text);
      }
    }

    private void SetPropertyValue(string text)
    {
      mIgnorePropertyChanged = true;

      mProperty.SetValue(mArgs, new FileInfo(text));

      mIgnorePropertyChanged = false;
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      base.SetBoundsCore(x, y, width, 23, specified);
    }

    private void mArgs_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      if (e.PropertyName != mProperty.Name || mIgnorePropertyChanged)
      {
        return;
      }

      ReadPropertyValue();
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
      {
        txtPath.Text = openFileDialog1.FileName;
      }
    }

    private void txtPath_TextChanged(object sender, EventArgs e)
    {
      if (mIgnoreTextChanged)
      {
        return;
      }

      SetPropertyValueDebounce(txtPath.Text);
    }
  }
}
