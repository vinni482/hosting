using AppSettings;
using Models.RestSharp;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RestSharpService
    {
        private readonly RestClient _restClient;
        
        public RestSharpService()
        {
            _restClient = new RestClient(RestSharpSettings.BaseURL);
            // client.Authenticator = new HttpBasicAuthenticator(username, password);
        }

        public async Task<WHMCreateAccountResponseModel> WHMCreateAccount(WHMCreateAccountModel model)
        {
            string response = await this.Send(RestSharpSettings.WHMCreateAccountResource, Method.GET, model);
            return JsonConvert.DeserializeObject<WHMCreateAccountResponseModel>(response);
        }

        private async Task<string> Send(string resource, Method method = Method.GET, object model = null)
        {
            var request = new RestRequest(resource, method);

            if(model != null)
                request.AddObject(model);

            IRestResponse response = await _restClient.ExecuteTaskAsync(request);
            return response.Content;
        }
    }
}
