using MyFirstApp.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp.API
{
    public class CharactersService
    {
        public const string API_BASE_URL = "https://rickandmortyapi.com/api";

        private IRepository repo;

        public CharactersService()
        {
            repo = RestService.For<IRepository>(API_BASE_URL);
        }

        public Task<RickAndMortyResponse> Get()
        {
            return repo.GetAllCharacters();
        }
    }
}
