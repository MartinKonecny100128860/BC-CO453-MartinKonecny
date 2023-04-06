using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a (possibly multi-line)
    /// text message. Other data, such as author and time, are also stored.
    /// </summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// Edited by Martin Konecny
    /// version 0.1
    /// </author>
    public class MessagePost : Post
    {

        // an arbitrarily long, multi-line message
        public String Message { get; }



        /// <summary>
        /// Constructor for objects of class MessagePost.
        /// </summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="text">
        /// The text of this post.
        /// </param>
        public MessagePost(String author, String text) : base(author)
        {
            Message = text;
        }

        /// <summary>
        /// displays the message
        /// </summary>
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"    Message: {Message}");
            Console.WriteLine($"\n");

            base.Display();
        }
    }
}
