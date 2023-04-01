using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

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
                "Display Posts by Date", "Add Comment", "Like Posts", 
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
                    case 9: wantToQuit = true; break;
                }
            } while (!wantToQuit);
        }
        private void PostMessage()
        {
            throw new NotImplementedException();
        }
        private void PostImage()
        {
            throw new NotImplementedException();
        }
        private void RemovePost()
        {
            throw new NotImplementedException();
        }
        private void DisplayAll()
        {
            news.Display();
        }
        private void DisplayByAuthor()
        {
            throw new NotImplementedException();
        }
        private void DisplayByDate()
        {
            throw new NotImplementedException();
        }
        private void AddComment()
        {
            throw new NotImplementedException();
        }
        private void LikePosts()
        {
            throw new NotImplementedException();
        }
    }
}
