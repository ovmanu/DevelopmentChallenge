using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Translations;
using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Services
{
    public static class DictionaryProvider
    {
        public static Dictionary<string, string[]> Get(LanguageEnum language)
        {
            switch (language)
            {
                case LanguageEnum.Spanish:
                    return SpanishDictionary.Words;
                case LanguageEnum.Italian:
                    return ItalianDictionary.Words;
                default:
                    return EnglishDictionary.Words;
            }
        }
    }
}
