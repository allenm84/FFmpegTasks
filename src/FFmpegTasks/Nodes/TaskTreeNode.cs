using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFmpegTasks
{
  public class TaskTreeNode : TreeNode
  {
    public TaskTreeNode(BaseFFmpegTask task)
      : base(task.DisplayName)
    {
      Task = task;
    }

    public BaseFFmpegTask Task { get; private set; }
  }
}
