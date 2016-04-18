using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FFmpegTasks.Properties;

namespace FFmpegTasks
{
  public static class ffmpeg
  {
    static readonly ffmpeg_dtor sdtor = new ffmpeg_dtor();
    static readonly string sFilepath;

    static readonly BlockingCollection<string> sFormats = new BlockingCollection<string>();
    static ffmpeg()
    {
      string temp = Path.GetTempFileName();
      File.Delete(temp);
      sFilepath = Path.ChangeExtension(temp, "exe");
      File.WriteAllBytes(sFilepath, Resources.ffmpeg);
      StartThread();
    }

    public static void Init() { }

    private static void StartThread()
    {
      var thread = new Thread(FillFormats);
      thread.IsBackground = true;
      thread.Start();
    }

    private static void FillFormats()
    {
      char[] WhiteSpace = new[] { ' ', '\t', '\r', '\n' };

      var p = new Process();
      p.StartInfo = Init("-formats");
      p.StartInfo.UseShellExecute = false;
      p.StartInfo.RedirectStandardOutput = true;
      p.StartInfo.CreateNoWindow = true;
      p.Start();

      string output = p.StandardOutput.ReadToEnd();
      p.WaitForExit();

      var formats = output
        .Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
        .Select(l => l.Trim())
        .SkipWhile(l => !l.Equals("--"))
        .Skip(1)
        .Select(l => l.Split(WhiteSpace, StringSplitOptions.RemoveEmptyEntries))
        .Where(a => a.Length > 1)
        .SelectMany(a => a[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        .Distinct();

      foreach (var format in formats)
      {
        sFormats.Add(format);
      }

      sFormats.CompleteAdding();
    }

    public static string GetFormatFilter()
    {
      while (!sFormats.IsAddingCompleted) ;
      return string.Join(";", sFormats.Select(l => "*." + l));
    }

    public static ProcessStartInfo Init(string arguments = null)
    {
      return new ProcessStartInfo(sFilepath, arguments);
    }

    public static Process Start(string arguments = null)
    {
      return Process.Start(Init(arguments));
    }

    private static void DeleteFFmpeg()
    {
      File.Delete(sFilepath);
    }

    private class ffmpeg_dtor { ~ffmpeg_dtor() { DeleteFFmpeg(); } }
  }
}
