using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace InheritanceDemo
{
    internal class VideoPost : Post
    {
        protected bool isplaying = false;
        protected int currDuration = 0;

        Timer timer;
        public  string VideoURL { get; set; }
        public int LengthSec { get; set; }

        public VideoPost() { }

        public VideoPost(string title, string sendByUserName, string videoURL, int lengthMin, bool isPublic)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUserName = sendByUserName;
            this.VideoURL = videoURL;
            this.LengthSec = lengthMin;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}, link: {3} , with a duration of {4} seconds", 
                this.ID, this.Title, this.SendByUserName, VideoURL, LengthSec);
        }

        
        public void Play()
        {
            if (!isplaying)
            {
                isplaying = true;
                Console.WriteLine("Playing");
                timer = new Timer(TimerCallback, null, 0, 1000);
                
            }
            
        }

        private void TimerCallback(object o)
        {
            if(currDuration < LengthSec)
            {
                Console.Clear();
                currDuration++;
                Console.WriteLine("video at {0}s", currDuration);
                GC.Collect();
            }
            else
            {
                Stop();
            }
            
        }

        public void Stop()
        {
            if (isplaying)
            {
                isplaying = false;
                Console.WriteLine("Stoped at {0}s", currDuration);
                currDuration = 0;
                timer.Dispose();
            }
        }
    }
}
