using ConsoleAppProject.Helpers;
using System;


namespace ConsoleAppProject.App04
{
    ///<summary>
    ///
    /// </summary>
    /// <author>
    /// By Martin Konecny
    /// version 4.2
    /// </author>
    internal class NetworkApp
    {
        private NewsFeed news = new NewsFeed();

        /// <summary>
        /// This method displahys a menu of different choices
        /// the user can select from 
        /// </summary>
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
                    case 10: Program.Main(); break;
                }
            } while (!wantToQuit);
        }

        /// <summary>
        /// This method allows the user to unlike a post
        /// but the user needs to insert an ID of already
        /// existing post.
        /// </summary>
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

        /// <summary>
        /// This method prompts the user to insert a message,
        /// it also infroms the user that their message was posted
        /// once message is posted the user can select from
        /// other choices
        /// </summary>
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

        /// <summary>
        /// This method prompts the user to post a message with caption,
        /// as well as the image file name. it also infroms the user that 
        /// their image was posted. once image is posted the user
        /// can select from other choices
        /// </summary>
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

        /// <summary>
        /// 
        /// </summary>
        private string InputName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Please enter your name/username");
            string author = Console.ReadLine();

            return author;
        }

        /// <summary>
        /// 
        /// </summary>
        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($" Removing a post");


            Console.ForegroundColor = ConsoleColor.Green;
            int id = (int)ConsoleHelper.InputNumber(" Please enter the ID of the post you want to remove > ");
            news.RemovePost(id);
        }
       /// <summary>
       /// This method allows the user to display all 
       /// the posts which were created on this network 
       /// application.
       /// </summary>
        private void DisplayAll()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            ConsoleHelper.OutputTitle("Displaying all posts!");

            news.Display();
        }
        /// <summary>
        /// This method allows the user to display all 
        /// the posts which were created on this network 
        /// application by specific author, but the user
        /// must input the authors username first.
        /// </summary>
        private void DisplayByAuthor()
        {
            ConsoleHelper.OutputTitle("Display Posts by Author");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\n Enter the name of the author here: ");

            string author = Console.ReadLine();

            news.FindAuthorPost(author);
        }

        /// <summary>
        /// to be completed
        /// </summary>
        private void DisplayByDate()
        {
            ConsoleHelper.OutputTitle("Displaying posts by date");


        }

       /// <summary>
       /// This method allows the user of this application
       /// to create and input a comment to already existing
       /// post
       /// </summary>
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

        /// <summary>
        /// This method allows the user to like a post
        /// but the user needs to insert an ID of already
        /// existing post.
        /// </summary>
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
