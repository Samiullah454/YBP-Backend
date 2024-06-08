using System;
using System.Collections.Generic;

using Abp.Domain.Entities.Auditing;

namespace HCA.WebSite_Configuration.Blog
{
    public class Blog : FullAuditedEntity<int>
    {
        public string Headerimgurl { get; set; }
        public string Title { get; set; }

        public string BlogText { get; set; }
        public int Comments { get; set; }
        public int Views { get; set; }
        public int BlogAuthorId { get; set; }
        public BlogAuthor BlogAuthor { get; set; }
        public DateTime Date { get; set; }
        public int? ImageGalleryId { get; set; }
        public BlogImageGallery ImageGallery { get; set; }
        public string Blockquote { get; set; }
        public int? BlogBottomId { get; set; }
        public BlogBottom BlogBottom { get; set; }
        public ICollection<BlogComment> CommentsList { get; set; }
    }

    public class BlogAuthor : FullAuditedEntity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ImageSource { get; set; }
        public ICollection<Blog> Blogs { get; set; } // Collection navigation property for blogs authored by this author
        public ICollection<BlogComment> BlogComments { get; set; } // Collection navigation property for comments authored by this author
    }

    public class BlogImageGallery : FullAuditedEntity<int>
    {
        public string Image1Source { get; set; }
        public string Image2Source { get; set; }
        public ICollection<Blog> Blogs { get; set; } // Collection navigation property for blogs using this image gallery
    }

    public class BlogBottom : FullAuditedEntity<int>
    {
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string GooglePlusLink { get; set; }
        public string LinkedInLink { get; set; }
        public string PinterestLink { get; set; }
        public ICollection<Blog> Blogs { get; set; } // Collection navigation property for blogs using this blog bottom
    }

    public class BlogComment : FullAuditedEntity<int>
    {
        public int BlogId { get; set; } // Foreign key for Blog
        public Blog Blog { get; set; }
        public int BlogAuthorId { get; set; } // Foreign key for Author
        public BlogAuthor BlogAuthor { get; set; }
        public DateTime CommentDate { get; set; }
        public string Text { get; set; }
    }
}