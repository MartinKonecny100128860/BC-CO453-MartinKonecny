﻿using ConsoleAppProject.Helpers;
using System;


namespace ConsoleAppProject.App04
{
    internal class NetworkApp
    {
        private NewsFeed news = new NewsFeed();
        public void DisplayChoices()
        {
            ConsoleHelper.OutputHeading("Welcome to this Network App");

            string[] choices = new string[]
            {
                "Post Message", "Post Image", "Remove Post", 
                "Display All Posts", "Display Posts by Author",
                "Display Posts by Date", "Add Comment", "Like Posts", "Unlike Posts",
                "Quit"
            };

            bool wantToQuit = false;
            do
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                switch (choice)
                {
                    case 1: PostMessage(); break;
                    case 2: PostImage(); break;
                    case 3: RemovePost(); break;
                    case 4: DisplayAll(); break;
                    case 5: DisplayByAuthor(); break;
                    case 6: DisplayByDate(); break;
                    case 7: AddComment(); break;
                    case 8: LikePosts(); break;
                    case 9: UnlikePosts(); break;
                    case 10: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }

        private void UnlikePosts()
        {
            ConsoleHelper.OutputTitle("Unike a Post");


            Console.ForegroundColor = ConsoleColor.Green;
            int postId = (int)ConsoleHelper.InputNumber("Type in the ID of the post you wish to unlike > ");

            Post post = news.FindPost(postId);

            if (post == null)
            {
                Console.WriteLine($"Post with ID {postId} not found.");
            }
            else
            {
                post.Unlike();
                Console.WriteLine("The post has been liked!");
                post.Display();
            }
        }

        private void PostMessage()
        {
            ConsoleHelper.OutputTitle("Post a message");

            string author = InputName();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please type in your message here");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(author, message);
            news.AddMessagePost(post);

            ConsoleHelper.OutputTitle("Your message has been posted:");
            post.Display();
        }
        private void PostImage()
        {
            ConsoleHelper.OutputTitle("Post an Photo/Image");

            string author = InputName();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please the file name of the image you want to post");
            string filename = Console.ReadLine();

            Console.WriteLine("Please enter a caption for your image");
            string caption = Console.ReadLine();

            PhotoPost post = new PhotoPost(author, filename, caption);
            news.AddPhotoPost(post);

            ConsoleHelper.OutputTitle("This image has been posted:");
            post.Display();
        }

        private string InputName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your name/username");
            string author = Console.ReadLine();

            return author;
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($" Removing a post");


            Console.ForegroundColor = ConsoleColor.Green;
            int id = (int)ConsoleHelper.InputNumber(" Please enter the ID of the post you want to remove > ");
            news.RemovePost(id);
        }
        private void DisplayAll()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleHelper.OutputTitle("Displaying all posts!");

            news.Display();
        }
        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle("Display Posts by Author");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n Enter the name of the author here: ");

            string author = Console.ReadLine();

            news.FindAuthorPost(author);
        }

        private void DisplayByDate()
        {
            ConsoleHelper.OutputTitle("Displaying posts by date");


        }

        private void AddComment()
        {
            ConsoleHelper.OutputTitle("Add a comment to a poost");


            string author = InputName();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter a your comment here: ");
            string comment = Console.ReadLine();

            news.AddComment(comment);

            ConsoleHelper.OutputTitle("The comment has been posted!");
            news.Display();


        }

        private void LikePosts()
        {
            ConsoleHelper.OutputTitle("Like a Post");


            Console.ForegroundColor = ConsoleColor.Green;
            int postId = (int)ConsoleHelper.InputNumber("Type in the ID of the post you wish to like > ");

            Post post = news.FindPost(postId);

            if (post == null)
            {
                Console.WriteLine($"Post with ID {postId} not found.");
            }
            else
            {
                post.Like();
                Console.WriteLine("The post has been liked!");
                post.Display();
            }
        }
    }
}
