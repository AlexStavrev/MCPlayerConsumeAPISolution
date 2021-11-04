using MCPlayerApiClient.DTOs;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace MCPlayerApiClient.ApiClient
{
    public interface IPlayerApiClient
    {
        Task<Image> GetBodyImageFromUUIDAsync(string uuid);
        Task<Player> GetPlayerFromUUID(string uuid);
        Task<string> GetUUIDFromNameAsync(string name, int scale = 10);
        Task<IEnumerable<string>> GetAllNamesAsync(string uuid);
    }
}