using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fireside.Cards
{
    class Spell : Card
    {

        public Spell(int cost, Texture2D portrait, CardEffect effect) : base(cost, portrait, effect)
        {

        }

        public override void Draw()
        {
            //TODO Implement
        }
    }
}
