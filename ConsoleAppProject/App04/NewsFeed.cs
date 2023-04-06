using System.Collections.Generic;
using System;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Michael Kölling and David J. Barnes
    ///  Edited by Martin Konecny
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        public const string AUTHOR = "Martin";
        private readonly List<Post> posts;

        ///<summary>
        /// Construct an empty news feed. alongside Pre-made Posts for testing purposes
        ///</summary>
        public NewsFeed()
        {
            posts = new List<Post>();
            MessagePost post = new MessagePost(AUTHOR, "I am getting into programming!");
            AddMessagePost(post);

            PhotoPost photoPost = new PhotoPost(AUTHOR, "Promgrammer.jpg", "c# tests");
            AddPhotoPost(photoPost);
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// @param text  The text post to be added.
        ///</summary>
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }

        ///<summary>
        /// Add a photo post to the news feed.
        /// 
        /// @param photo  The photo post to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost photo)
        {
            posts.Add(photo);
        }

        /// <summary>
        /// takes ID parameter and removes the post
        /// assositated with the ID.it then displays 
        /// a message that post either doesnt exist or
        /// that the post was deleted. 
        /// </summary>
        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($"\n Post with ID = {id} does not exist!\n");
            }
            else
            {
                Console.WriteLine($"\n The following post {id} has been removed!\n");

                if (post is MessagePost mp)
                {
                    mp.Display();
                }
                else if (post is PhotoPost pp)
                {
                    pp.Display();
                }

                posts.Remove(post);
            }
        }
        /// <summary>
        /// takes the ID parameter and returns the post
        /// affiliated with it. returns null if post
        /// with that id doesnt exist. 
        /// </summary>

        public Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.IdPost == id)
                {
                    return post;
                }
            }

            return null;
        }

        /// <summary>
        /// prompts the user to input an ID of a post
        /// they want to comment under. if the post exists
        /// it will display the posts 
        /// </summary>
        public void AddComment(string comment)
        {
            Console.WriteLine(" Input The ID");
            int id = int.Parse(Console.ReadLine());
            foreach (Post post in posts)
            {
                if (post.IdPost == id)
                {
                    post.AddComment(comment);
                    post.Display();
                    Console.WriteLine($"\n");
                }
            }

        }
        /// <summary>
        /// This method takes the author parameter 
        /// and displays all posts crated by that author
        /// </summary>
        
        public void FindAuthorPost(string author)
        {
            foreach (Post post in posts)
            {
                if (post.Username == author)
                {
                    post.Display();
                }
            }
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {

            foreach (Post posts in posts)
            {
                posts.Display();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
            }
        }

    }

}