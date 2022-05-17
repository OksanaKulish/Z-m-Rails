using System.Threading.Tasks;
using Zum_Rails.Requests;
using Zum_Rails.Responces;

namespace Zum_Rails.Interfaces
{
    public interface IPostService
    {
        Task<PostResponce> getPosts(PostRequest postRequest);
    }
}
