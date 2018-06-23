using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new VoinFactory());
            voin.Hit();
            voin.Run();

            Console.ReadLine();
        }
    }

    #region Weapons
    
    //Abstract class weapon
    abstract class Weapon
    {
        public abstract void Hit();
    }
    // Class crossbow
    class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Shoot from crossbow");
        }
    }
    // Class sword
    class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Hit with sword");
        }
    }

    #endregion

    #region Movement
    
    // Abstract class movement
    abstract class Movement
    {
        public abstract void Move();
    }
    // Movement - fly
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Flying");
        }
    }
    // Movement - run
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Running");
        }
    }

    #endregion

    #region Abstract
    
    // Abstract factory class
    abstract class HeroFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
    // Factory create flying hero with crossbow
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Arbalet();
        }
    }
    // Factory create running hero with sword
    class VoinFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }

    #endregion

    #region Hero
    
    // Hero
    class Hero
    {
        private Weapon weapon;
        private Movement movement;
        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void Run()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
    
    #endregion
}
