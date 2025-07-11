using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    public class Player
    {
        public readonly int id;
        public readonly string name;
        public readonly int age;

        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            age = 21;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        public Player WhoIsElder(Player player)
        {
            if (player.age > this.age)
                return player;
            else
                return this;
        }
    }
}