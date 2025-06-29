﻿using AppJogoDaForca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoDaForca.Repositories
{
    public class WordRepositories
    {
        private List<Word> _words;

        public WordRepositories() 
        { 
            _words = new List<Word>();

            _words.Add(new Word("Nome", "Maria".ToUpper()));
            _words.Add(new Word("Vegetal", "Cenoura".ToUpper()));
            _words.Add(new Word("Fruta", "Abacate".ToUpper()));
            _words.Add(new Word("Tempero", "Baiano".ToUpper()));
            _words.Add(new Word("Tempero", "Mineiro".ToUpper()));
        }

        public Word GetWordRandom()
        {
            Random rand = new();

            var number = rand.Next(0, _words.Count);

            return _words[number];
        }
    }
}
