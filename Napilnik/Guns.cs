using System;

namespace Napilnik
{
    class Weapon
    {
        private Player player;
        
        private int _damage;
        private int _bullets;


        public void Fire()
        {
            _bullets -= 1;
            player.TakeDamage(_damage);
        }
    }

    class Player
    {
        private int _health;
        private int _minHealth = 0;

        public void TakeDamage(int damage)
        {
            if ((_health -= damage) < 0)
                throw new IndexOutOfRangeException(nameof(_minHealth));
            else
                _health -= damage;
        }
    }

    class Bot
    {
        private Weapon Weapon;

        public void OnSeePlayer()
        {
            Weapon.Fire();
        }
    }
}
