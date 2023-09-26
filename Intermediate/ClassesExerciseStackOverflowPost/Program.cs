using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExerciseStackOverflowPost
{
    public class Post
    {
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime CreatedDate { get; set; }
        private int VoteCount { get; set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreatedDate = DateTime.Now;
            this.VoteCount = 0;
        }

        public void UpVote()
        {
            VoteCount++;
        }

        public void DownVote()
        {
            VoteCount--;
        }

        public int GetVoteCount()
        {
            return VoteCount;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Post stackOverflowPost = new Post("C# Programming", "How to design a StackOverflow post class in C#");

            stackOverflowPost.UpVote();
            stackOverflowPost.UpVote();
            stackOverflowPost.DownVote();
            stackOverflowPost.DownVote();
            stackOverflowPost.UpVote();
            stackOverflowPost.UpVote();
            stackOverflowPost.DownVote();
            stackOverflowPost.UpVote();
            stackOverflowPost.UpVote();
            stackOverflowPost.UpVote();

            Console.WriteLine($"Current Vote Count: {stackOverflowPost.GetVoteCount()}");
        }
    }
}
