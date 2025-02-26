using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    public class FeaturesBoocks
    {
        private string _name;
        private string _autor;
        private string _date;
        private int _pages;
        
        public string Title
        {
            get => _name;
            set => _name = value;
        }
        public string Autor
        {
            get => _autor;
        }
        public int Publisher { get; }

        public string Information => $"Название: {_name}\nАвтор: {_autor}\nГод: {_date}\nКоличество страниц: {_pages}\nИздательство: {Publisher}";

        public FeaturesBoocks(string name, string autor, string date, int pages, string title, int publisher)
        {
            _name = name;
            _autor = autor;
            _date = date;
            _pages = pages;
            Title = title;
            Publisher = publisher;
        }
    }
}
