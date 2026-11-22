using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            Video vid1 = new Video("Evangelism", "George", 130);
            vid1.AddComment(new Comment("Martins", "The Lord is Good"));
            vid1.AddComment(new Comment("Sarah", "Very inspiring"));
            vid1.AddComment(new Comment("John", "Thank you for sharing"));
            vid1.DisplayVideoInfo();
            Console.WriteLine();
            Video vid2 = new Video("Iphone or Samsung", "Glory", 53);
            vid2.AddComment(new Comment("Josiah", "Apple Products is best"));
            vid2.AddComment(new Comment("Kingsley", "I choose samsung"));
            vid2.AddComment(new Comment("Ebere", "I can't relate"));
            vid2.AddComment(new Comment("Favour", "i'm currently using an Iphone"));
            vid2.DisplayVideoInfo();
            Console.WriteLine();
            Video vid3 = new Video("Which county have you been to?", "Micheal", 183);
            vid3.AddComment(new Comment("Joshua", "TI have been to Canada"));
            vid3.AddComment(new Comment("Joe", "I love Traveling, I've been to over 30 Countries"));
            vid3.AddComment(new Comment("Leonard", "Are we allowed to travel? Lol"));
            vid3.DisplayVideoInfo();
        }
    }
}