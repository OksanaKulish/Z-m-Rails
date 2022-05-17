using System.ComponentModel.DataAnnotations;
using Zum_Rails.Responces;

namespace Zum_Rails.Requests
{
    public enum SortBy
    {
        id,
        reads,
        likes,
        popularity
    }

    public enum Direction
    {
        desc,
        asc
    }

    public class PostRequest
    {
        public Tags Tags { get; set; }
        public Direction Direction { get; set; }
        public SortBy SortBy { get; set; }
    }
}
