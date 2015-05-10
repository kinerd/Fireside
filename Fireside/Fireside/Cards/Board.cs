using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fireside.Cards
{
    class Board : Card
    {
        Texture2D gameboard { set; get; }

        public Board(int cost, Texture2D portrait, CardEffect effect, Texture2D gameboard) : base(cost, portrait, effect)
        {
            this.gameboard = gameboard;
        }

        public override void Draw()
        {
            //TODO Implement
        }
    }
}
