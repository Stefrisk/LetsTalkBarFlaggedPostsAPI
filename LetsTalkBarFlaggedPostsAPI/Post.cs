using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.Extensions.Hosting;

namespace LetsTalkBarFlaggedPostsAPI
{
    public class Post
    {
        public int Id { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        public string UserId { get; set; }

       

        

        

        
    }
}
