﻿using Auvo_Project.ViewModels;
using Xamarin.Forms;
using SQLite.Net.Attributes;

namespace Auvo_Project.Model
{
    [Table("Pessoa")]
    public class Pessoa : BaseViewModel
    {
        public Command IncludeCommand { get; set; }
        public Command EditCommand { get; set; }
        public Command DeleteCommand { get; set; }

        private int _id;
        [PrimaryKey, AutoIncrement, NotNull]
        public int Id
        {
            get { return _id; }
            set {
                if (SetProperty(ref _id, value))
                    IncludeCommand.ChangeCanExecute();
            }
        }

        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (SetProperty(ref _nome, value))
                    IncludeCommand.ChangeCanExecute();

            }
        }

        private string _cpf;

        public string CPF
        {
            get { return _cpf; }
            set
            {
                if (SetProperty(ref _cpf, value))
                    IncludeCommand.ChangeCanExecute();
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                if (SetProperty(ref _email, value))
                    IncludeCommand.ChangeCanExecute();
            }
        }

        private string _login;

        public string Login
        {
            get { return _login; }
            set
            {
                if (SetProperty(ref _login, value))
                    IncludeCommand.ChangeCanExecute();
            }
        }

        private string _senha;

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (SetProperty(ref _senha, value))
                    IncludeCommand.ChangeCanExecute();
            }
        }
    }
}
