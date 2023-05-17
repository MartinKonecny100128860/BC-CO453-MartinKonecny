using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

///<summary>
/// This class stores information about a post in a social network. 
/// The main part of the post consists of a photo and a caption. 
/// Other data, such as author and time, are also stored.
///</summary>
/// <author>
/// Michael Kölling and David J. Barnes
/// Edited by Martin Konecny
/// @version 0.1
/// </author>
/// 
namespace ConsoleAppProject.App04
{
    public class Post
    {
        public int IdPost { get; }

        private static int instances = 0;

        private int likes;

        private readonly List<String> comments;

        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }
        public string PostDate { get; }

        /// <summary>
        /// Constructor for what every/per Post should look like using the specific author
        /// </summary>
        public Post(string author)
        {
            instances++;
            IdPost = instances;

            this.Username = author;
            Timestamp = DateTime.Now;
            PostDate = Timestamp.ToShortDateString();

            likes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        //public int GetNumberOfPosts()
        //{
        //    int NumberOfPosts = 0;
        //    foreach (Post post in Post)
        //    {
        //        NumberOfPosts++;
        //    }
        //    return NumberOfPosts;
        //}

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }
        ///<summary>
        /// Display the details of this post.
        /// 
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public  virtual void Display()
        {
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine($"    ID Posts:     {IdPost}");
            Console.WriteLine($"    Author:       {Username}");
            Console.WriteLine($"    Time Elapsed: {FormatElapsedTime(Timestamp)}");
            Console.WriteLine($"    Post Date:    {PostDate}");

            if (likes > 0)
            {
                Console.WriteLine($"    Likes:    {likes}  people like this.");
            }
            else
            {
                Console.WriteLine($"    There are currently 0 likes.");
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
            }
            else
            {
                Console.WriteLine($"    {comments.Count}  comment(s). Click here to view.");
                Console.WriteLine();
                foreach (string comments in comments)
                {
                    Console.WriteLine($"    {comments}");
                }
            }
            Console.WriteLine($"\n");
        }
    }
}