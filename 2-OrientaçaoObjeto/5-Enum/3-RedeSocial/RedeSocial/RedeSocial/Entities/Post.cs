using System;
using System.Collections.Generic;
using System.Text;

namespace RedeSocial.Entities
{
    internal class Post
    {
        public DateTime Momemnt { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime momemnt, string tittle, string content, int likes)
        {
            Momemnt = momemnt;
            Tittle = tittle;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add( comment );
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Tittle);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Momemnt.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment c in Comments)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
