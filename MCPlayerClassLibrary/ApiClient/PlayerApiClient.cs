using MCPlayerApiClient.DTOs;
using MCPlayerApiClient.Tools;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace MCPlayerApiClient.ApiClient
{
    public class PlayerApiClient : IPlayerApiClient
    {
        private readonly RestClient _restClient;
        public PlayerApiClient(string apiUri) => _restClient = new RestClient(new Uri(apiUri));

        public async Task<PlayerDto> GetPlayerByName(string name)
        {
            var response = await _restClient.RequestAsync<PlayerDto>(Method.GET, $"users/profiles/minecraft/{name}");

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error retrieving data for '{name}'. Message was: {response.ErrorException?.Message}");
            }

            PlayerDto player = response.Data;
            if (player != null) {
                player.Names = await GetAllNameChangesAsync(player.Id.ToString());
            }

            return player;
        }

        public async Task<string> GetUUIDFromNameAsync(string name)
        {
            var response = await _restClient.RequestAsync<PlayerDto>(Method.GET, $"users/profiles/minecraft/{name}");

            if(!response.IsSuccessful)
            {
                throw new Exception($"Error retrieving UUID for '{name}'. Message was: {response.ErrorException?.Message}");
            }
            return response.Data.Id.ToString();
        }

        public async Task<IEnumerable<string>> GetAllNamesAsync(string uuid)
        {
            var response = await _restClient.RequestAsync<IEnumerable<NameChangeDto>>(Method.GET, $"user/profiles/{uuid}/names");

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error retrieving all names for '{uuid}'. Message was: {response.ErrorException?.Message}");
            }

            IEnumerable<string> GetListOfNames()
            {
                foreach (NameChangeDto nameChange in response.Data)
                {
                    yield return nameChange.Name;
                }
            }
            return GetListOfNames();
        }

        public async Task<IEnumerable<NameChangeDto>> GetAllNameChangesAsync(string uuid)
        {
            var response = await _restClient.RequestAsync<IEnumerable<NameChangeDto>>(Method.GET, $"user/profiles/{uuid}/names");

            if (!response.IsSuccessful)
            {
                throw new Exception($"Error retrieving all names for '{uuid}'. Message was: {response.ErrorException?.Message}");
            }

            return response.Data;
        }

        public async Task<Image> GetBodyImageFromUUIDAsync(string uuid)
        {
            return await GetImageAsync($"https://mc-heads.net/body/{uuid}/1000");
        }
        private static async Task<Image> GetImageAsync(string url)
        {
            var taskCompletionSource = new TaskCompletionSource<Image>();
            Image webImage = null;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            await Task.Factory.FromAsync(request.BeginGetResponse, request.EndGetResponse, null).ContinueWith(task =>
            {
                var webResponse = (HttpWebResponse)task.Result;
                Stream responseStream = webResponse.GetResponseStream();
                webImage = Image.FromStream(responseStream);
                taskCompletionSource.TrySetResult(webImage);
                webResponse.Close();
                responseStream.Close();
            });
            return taskCompletionSource.Task.Result;
        }
    }
}