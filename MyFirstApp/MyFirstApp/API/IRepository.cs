using MyFirstApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.API
{
    public interface IRepository
    {
        [Get("/character/")]
        Task<RickAndMortyResponse> GetAllCharacters();
    }
}
