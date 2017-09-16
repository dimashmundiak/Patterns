using System.Collections.Generic;

namespace Memento
{
    public class GameHistory
    {
        public Stack<HeroMemento> History { get; }
        public GameHistory()
        {
            History = new Stack<HeroMemento>();
        }
    }
}