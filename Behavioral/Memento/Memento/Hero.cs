using System;

namespace Memento
{
    public class Hero
    {
        private int _patrons = 10;
        private int _lives = 5;

        public void Shoot()
        {
            if (_patrons > 0)
            {
                _patrons--;
                Console.WriteLine($"Производим выстрел. Осталось {_patrons} патронов");
            }
            else
                Console.WriteLine("Патронов больше нет");
        }

        public HeroMemento SaveState()
        {
            Console.WriteLine($"Сохранение игры. Параметры: {_patrons} патронов, {_lives} жизней");
            return new HeroMemento(_patrons, _lives);
        }

        public void RestoreState(HeroMemento memento)
        {
            _patrons = memento.Patrons;
            _lives = memento.Lives;
            Console.WriteLine($"Восстановление игры. Параметры: {_patrons} патронов, {_lives} жизней");
        }
    }
}
