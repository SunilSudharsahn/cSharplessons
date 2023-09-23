using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New1.Day3
{
    internal class MediaContent
    {
        public virtual void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
        public  virtual void StopPlayingContent()
        {
            Console.WriteLine("Stop");
        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("Continue");
        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");
        }
    }
    internal class AudioContent : MediaContent
    {
        public override sealed void StartPlayingContent()
        {
            Console.WriteLine("Start");
        }
    }
}
