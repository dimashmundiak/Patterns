﻿namespace Abstract_Factory
{
    public class Hero
    {
        private Weapon _weapon;
        private Movement _movement;

        public Hero(HeroFactory factory)
        {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Run()
        {
            _movement.Move();
        }

        public void Hit()
        {
            _weapon.Hit();
        }
    }
}
