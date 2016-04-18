using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegTasks
{
  public class ConvertToMP3 : BaseFFmpegTask
  {
    private ConvertToMP3Args args;

    public override string DisplayName
    {
      get { return "Convert to MP3"; }
    }

    protected override BaseTaskArgs CreateArgs()
    {
      args = new ConvertToMP3Args
      {
        AudioChannels = Mp3AudioChannels.ac2,
        Bitrate = Mp3Bitrate.b320,
        Frequency = Mp3Frequency.f44100,
        Volume = 1,
      };

      return args;
    }

    protected override bool CanRun()
    {
      return
        (args != null) &&
        (args.InputFile != null) && (args.InputFile.Exists);
    }

    protected override void DoRun()
    {
      var input = args.InputFile.FullName;
      var output = Path.ChangeExtension(input, "mp3");

      var proc = ffmpeg.Start(string.Format("-i {0}{1}{0} -y -ab {2}k -ac {3} -ar {4} -vol {5} -vn {0}{6}{0}",
        "\"",
        input,
        (int)args.Bitrate,
        (int)args.AudioChannels,
        (int)args.Frequency,
        256 * args.Volume,
        output));
      proc.WaitForExit();
    }

    private enum Mp3Bitrate
    {
      b32 = 32,
      b96 = 96,
      b128 = 128,
      b160 = 160,
      b192 = 192,
      b256 = 256,
      b320 = 320,
    }

    private enum Mp3AudioChannels
    {
      ac1 = 1,
      ac2,
      ac3,
      ac4,
      ac5,
      ac6,
    }

    private enum Mp3Frequency
    {
      f16000 = 16000,
      f24000 = 24000,
      f32000 = 32000,
      f44100 = 44100,
    }

    private class ConvertToMP3Args : BaseTaskArgs
    {
      [DisplayName("Input:")]
      public FileInfo InputFile
      {
        get { return GetField<FileInfo>(); }
        set { SetField(value); }
      }

      [DisplayName("Bitrate:")]
      public Mp3Bitrate Bitrate
      {
        get { return GetField<Mp3Bitrate>(); }
        set { SetField(value); }
      }

      [DisplayName("# Channels:")]
      public Mp3AudioChannels AudioChannels
      {
        get { return GetField<Mp3AudioChannels>(); }
        set { SetField(value); }
      }

      [DisplayName("Frequency:")]
      public Mp3Frequency Frequency
      {
        get { return GetField<Mp3Frequency>(); }
        set { SetField(value); }
      }

      [DisplayName("Volume:"), Range(1, 100)]
      public int Volume
      {
        get { return GetField<int>(); }
        set { SetField(value); }
      }
    }
  }
}
