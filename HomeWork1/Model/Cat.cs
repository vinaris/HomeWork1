using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        private string _name;
        private int _health;

        public Cat(string age, CatColor color)
        {
            Age = age;
            _health = 5;
            Color = color;
            CurrentColor = color.HeathyColor;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }

        public string Age { get; }

        public CatColor Color { get; set; }

        public void Feed()
        {
            _health++;
        }

        public void Punish()
        {
            _health--;
        }

        public string CurrentColor { get; set; }

        public void SetCurrentColor()
        {
            CurrentColor = _health < 5 ? Color.SickColor : Color.HeathyColor;
        }

    }
}
