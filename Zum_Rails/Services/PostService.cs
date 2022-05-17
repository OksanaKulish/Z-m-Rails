using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Zum_Rails.Exceptions;
using Zum_Rails.Interfaces;
using Zum_Rails.Requests;
using Zum_Rails.Responces;

namespace Zum_Rails.Services
{
    public class PostService : IPostService
    {
        public IConfiguration _config;
        public PostService(IConfiguration config)
        {
            this._config = config;
        }

        public async Task<PostResponce> getPosts(PostRequest postRequest)
        {
            var baseUrl = this._config.GetValue<string>("ThirdParty");
            var url = baseUrl + Normalize(postRequest);
            var json = "";
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(url);

                using (var content = response.Content)
                {
                    json = await content.ReadAsStringAsync();
                }
            }
            return JsonConvert.DeserializeObject<PostResponce>(json);
        }

        private string Normalize(PostRequest postRequest)
        {
            var result = "";
            if (String.IsNullOrEmpty(postRequest.Tags.ToString()))
            {
                string exceptionMessage = Resource.ResourceManager.GetString("tagRequired");
                throw new PostException(exceptionMessage);
            }
            else
            {
                result += postRequest.Tags.ToString();
            }

            //else if (String.IsNullOrEmpty(postRequest.SortBy))
            //{

            //}

            //else if (String.IsNullOrEmpty(postRequest.SortBy))
            //{

            //}
            return result;
        }
    }
}
