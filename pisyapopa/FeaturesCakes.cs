using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    public class FeaturesCakes
    {
        private string _name;
        private double _weight;
        private double _price;
        private double _calorie;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public double Price
        {
            get => _price;
            set => _price = value;
        }
        public double Calorie
        {
            get => _calorie;
        }
        public string Compound { get; }

        public string Information => $"Название: {_name}\nВес: {_weight}\nЦена: {_price}\nКалорийность: {_calorie}\nСостав: {Compound}\n";

        public FeaturesCakes(string name, double weight, double price, double calorie, string compound)
        {
            _name = name;
            _weight = weight;
            _price = price;
            _calorie = calorie;
            Compound = compound;
        }
    }
}
