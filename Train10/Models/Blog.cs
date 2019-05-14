using System.Collections.Generic;

namespace Train10.Models
{
    /// <summary>
    /// Blog model.
    /// </summary>
    public class Blog
    {
        /// <summary>
        /// The id of the blog.
        /// </summary>
        /// <value>Blog Id.</value>
        public int BlogId { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}