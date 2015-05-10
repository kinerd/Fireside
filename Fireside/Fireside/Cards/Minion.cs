using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fireside.Cards
{
    class Minion : Card
    {
        public int attack{ get; set;}
        public int health{ get; set;}

        public Minion(int cost, Texture2D portrait, CardEffect effect, int attack, int health) : base(cost, portrait, effect)
        {
            this.attack = attack;
            this.health = health;
        }

        public override void Draw()
        {
            //TODO Implement
        }

    }
}
