using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_api.Models;

namespace web_api.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGame();
        Task<Game> GetIDGame(int id);

        Task AddGame(Game game);
        Task UpdateGame(Game game, int id);

        Task DeleteGame(int id);
    }
}