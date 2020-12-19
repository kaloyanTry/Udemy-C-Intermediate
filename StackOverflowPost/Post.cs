using System;
using System.Collections.Generic;
using System.Text;

namespace StackPost
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; }
        public int Vote { get; private set; }

        public void UpVote()
        {
            Vote++;
        }

        public void DownVote()
        {
            Vote--;
        }
    }
}
