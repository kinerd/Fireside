using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fireside.Cards
{
    class Card
    {
        int cost{ get; set;}
        Texture2D portrait;

        public Card(int cost, Texture2D portrait, CardEffect effect)
        {
            this.cost = cost;
            this.portrait = portrait;
        }

        public virtual void Draw()
        {
            //TODO Implement
        }

    }
}
