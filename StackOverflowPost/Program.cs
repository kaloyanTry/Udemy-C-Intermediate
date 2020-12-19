using System;

namespace StackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type yes and you can vote:");
            string typeChoice = Console.ReadLine();
            Console.Clear();

            if (typeChoice == "yes")
            {
                StackPost();
            }
            else
            {
                return;
            }
        }

        private static void StackPost()
        {
            Post post = new Post();
            post.Description = "This is a test post";
            post.CreationTime = DateTime.Now;
            post.Title = "Test";
            Console.WriteLine("You can vote: \"UP\" or \"down\" and you can \"display\" the votes or \"exit\"");

            while (true)
            {
                string vote = Console.ReadLine();

                if (vote == "UP")
                {
                    post.UpVote();
                    Console.WriteLine($"You've voted UP times");
                    
                }
                else if (vote == "down")
                {
                    post.DownVote();
                    Console.WriteLine($"You've voted down times");
                }
                else if (vote == "display")
                {
                    Console.WriteLine($"The title is: {post.Title}");
                    Console.WriteLine($"The post is: {post.Description}");
                    Console.WriteLine(post.CreationTime);
                    Console.WriteLine($"The current vote is: {post.Vote}");
                }
                else if (vote == "exit")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid type");
                }
            }
        }
    }
}
