using System.Collections.Generic;

namespace Flyweight
{
    public class HouseFactory
    {
        readonly Dictionary<string, House> _houses = new Dictionary<string, House>();

        public HouseFactory()
        {
            _houses.Add("Panel", new PanelHouse());
            _houses.Add("Brick", new BrickHouse());
        }

        public House GetHouse(string key)
        {
            if (_houses.ContainsKey(key))
                return _houses[key];
            return null;
        }
    }
}
