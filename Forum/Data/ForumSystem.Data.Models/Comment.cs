﻿namespace ForumSystem.Data.Models
{
    using ForumSystem.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public int PostId { get; set; }

        public Post Post { get; set; }

        public int? ParentId { get; set; }

        public virtual Comment Parent { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }

        public ApplicationUser User { get; set; }
    }
}