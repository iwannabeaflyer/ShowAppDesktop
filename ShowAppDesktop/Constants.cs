namespace ShowAppDesktop
{
    class Constants
    {
        public const byte MIN = 0;
        public const byte MAX = 100;
        public const byte JSON_FIELDS = 9;
        public const byte MINUTES = 60;

        public const string APPLICATION_NAME = "json creator";
        public const string OPENFILEFILTER = "Json files (*.json)|*.json";

        //Constants for testing purposes
        public const string OPENFILEDIR = @"C:\Users\PATRICK\source\repos\JsonApp\ShowApp\JsonApp\bin\Debug";
        public const string TEMPJSONFILE = @"C:\Users\PATRICK\source\repos\JsonApp\ShowApp\JsonApp\bin\Debug\test.json";
        //@"C:\";

        //MAL, animelon uses %20 or white spaces
        //The rest uses '+' to seperate the search terms
        public const string GOOGLE = "https://www.google.com/search?q=";
        public const string MAL_ALL = "https://myanimelist.net/search/all?q=";
        public const string MAL_CATAGORY = "https://myanimelist.net/";
        public const string MAL_ANIME = "anime.php?q=";
        public const string MAL_CHARACTER = "character.php?q=";
        public const string MAL_MANGA = "manga.php?q=";
        public const string ANIMELON = "https://animelon.com/search?searchTerm=";
        public const string CRUNCHYROLL = "https://www.crunchyroll.com/search?o=m&r=t&q=";
        public const string IMDB = "https://www.imdb.com/find?q=";
        public const string YOUTUBE = "https://www.youtube.com/results?search_query=";
        public const string WIKIPEDIA = "https://en.wikipedia.org/w/index.php?search=";


        //Use HTML Tags to get info from websites to fill data automaticly in
        //Parser allow you to parse HTML and return an HtmlDocument.
        //Selector allow you to select HTML node from HtmlDocument.
        //Traversing allow you to traverse through HTML node.
    }
}
