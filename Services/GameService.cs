using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using web_api.Db;
using web_api.Models;

namespace web_api.Services
{
    public class GameService : IGameService
    {
        private readonly DataAppContext _context;

        public GameService(DataAppContext context)
        {
            _context = context;
        }

        public async Task<List<Game>> GetAllGame()
        {
            var result = await _context.Games.ToListAsync();
            return result;
        }


        public async Task<Game> GetIDGame(int id)
        {
            var game = await _context.Games.FindAsync(id);
            return game;
        }


        public async Task UpdateGame(Game game, int id)
        {
            var dbgame = await _context.Games.FindAsync(id);
            if(dbgame != null)
            {
                dbgame.Title = game.Title;
                dbgame.Developer = game.Developer;
        
                await _context.SaveChangesAsync();
            }
        }


        public async Task AddGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGame(int id)
        {
           var game = await _context.Games.FindAsync(id);
           if(game != null)
           {
             _context.Games.Remove(game);
             await _context.SaveChangesAsync();
           }
        }
    }
}