using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pisyapopa
{
    internal class MethodCakes
    {
        private string _name;
        private double _weight;
        private double _price;
        private double _calorie;
        private string _compound;

        public void SetName(string name) => _name = name;
        public string GetName() => _name;
        public void SetPrice(double price) => _price = price;
        public double GetPrice() => _price;
        public double GetWeight() => _weight;
        public string Compound() => _compound;

        public string GetInfo => $"Название: {_name}\nВес: {_weight}\nЦена: {_price}\nКалорийность: {_calorie}\nСостав: {_compound}\n";

        public MethodCakes(string name, double weight, double price, double calorie, string compound)
        {
            _name = name;
            _weight = weight;
            _price = price;
            _calorie = calorie;
            _compound = compound;
        }
    }
}
