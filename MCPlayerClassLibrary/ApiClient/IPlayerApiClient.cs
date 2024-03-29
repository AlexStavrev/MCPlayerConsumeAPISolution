﻿using MCPlayerApiClient.DTOs;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace MCPlayerApiClient.ApiClient
{
    public interface IPlayerApiClient
    {
        Task<PlayerDto> GetPlayerByName(string name);
        Task<string> GetUUIDFromNameAsync(string name);
        Task<IEnumerable<string>> GetAllNamesAsync(string uuid);
        Task<IEnumerable<NameChangeDto>> GetAllNameChangesAsync(string uuid);
        Task<Image> GetBodyImageFromUUIDAsync(string uuid);
    }
}