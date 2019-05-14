namespace Train10.Models
{
    /// <summary>
    /// Post model.
    /// </summary>
    public class Post
    {
        /// <summary>
        /// PostId
        /// </summary>
        /// <value>PostId</value>
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
