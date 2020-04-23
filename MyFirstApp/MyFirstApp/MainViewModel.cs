using MyFirstApp.API;
using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstApp
{
    public class MainViewModel : BaseViewModel
    {
        private readonly CharactersService charactersService;

        private List<Character> characterList;

        public List<Character> CharacterList 
        { 
            get => characterList; 
            set 
            {

                characterList = value;
                RaisePropertyChanged();
            } 
        }

        public ICommand ClickCommand => new Command(ClickCommandExecute);

        private async void ClickCommandExecute()
        {
            var response = await charactersService.Get();
            CharacterList = response.Results.ToList();
        }

        public MainViewModel()
        {
            charactersService = new CharactersService();
        }


    }
}
