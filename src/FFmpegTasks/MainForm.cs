using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public partial class MainForm : Form
  {
    private readonly Dictionary<BaseFFmpegTask, ArgsEditor> mEditors = new Dictionary<BaseFFmpegTask, ArgsEditor>();
    private IDisposable mCurrentBinding;

    public MainForm()
    {
      InitializeComponent();
      PopulateTasks();
      BindToTask(null);
      ffmpeg.Init();
    }

    private async void PopulateTasks()
    {
      lstTasks.BeginUpdate();
      lstTasks.Nodes.AddRange(await Task.Run(() =>
      {
        var nodes = new List<TreeNode>();

        var type = typeof(BaseFFmpegTask);
        var tasks = type.Assembly
          .GetTypes()
          .Where(t => !t.IsAbstract && t.IsSubclassOf(type));

        foreach (var task in tasks)
        {
          var value = Activator.CreateInstance(task) as BaseFFmpegTask;
          nodes.Add(new TaskTreeNode(value));
        }

        return nodes.ToArray();
      }));
      lstTasks.EndUpdate();
    }

    private void BindToTask(BaseFFmpegTask task)
    {
      pnlEditorContainer.SuspendLayout();
      pnlEditorContainer.Controls.Clear();

      if (mCurrentBinding != null)
      {
        mCurrentBinding.Dispose();
        mCurrentBinding = null;
      }

      btnRun.Enabled = false;

      if (task != null)
      {
        mCurrentBinding = btnRun.Bind(task.RunCommand);

        ArgsEditor editor;
        if (!mEditors.TryGetValue(task, out editor))
        {
          editor = new ArgsEditor(task.Args);
          mEditors[task] = editor;
        }

        editor.Dock = DockStyle.Fill;
        pnlEditorContainer.Controls.Add(editor);
      }

      pnlEditorContainer.ResumeLayout();
    }

    private void lstTasks_AfterSelect(object sender, TreeViewEventArgs e)
    {
      var node = e.Node as TaskTreeNode;
      BindToTask(node?.Task);
    }
  }
}
