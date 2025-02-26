using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    internal class MetodBook
    {
        private string _name;
        private string _autor;
        private string _date;
        private int _pages;
        private string _publisher;

        public void SetName(string name) => _name = name;
        public string GetName() => _name;
        public string GetPublisher() => _publisher;
        public string GetAutor() => _autor;

        public string GetInfo => $"Название: {_name}\nАвтор: {_autor}\nГод: {_date}\nКоличество страниц: {_pages}\nИздательство: {_publisher}";

        public MetodBook(string name, string autor, string date, int pages, string publisher)
        {
            _name = name;
            _autor = autor;
            _date = date;
            _pages = pages;
            _publisher = publisher;
        }
    }
}
