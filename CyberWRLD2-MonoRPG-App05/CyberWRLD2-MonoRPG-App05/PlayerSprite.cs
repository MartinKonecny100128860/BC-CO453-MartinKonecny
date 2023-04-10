using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameRPG
{
    public class PlayerSprite : Sprites
    {
        public PlayerSprite(int x, int y) : base(x, y) { }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            KeyboardState keyState = Keyboard.GetState();

            float newX, newY;

            if(keyState.IsKeyDown(Keys.Right))
            {
                newX = Position.X + Speed * deltaTime;
                Position = new Vector2(newX, Position.Y);
            }

            if (keyState.IsKeyDown(Keys.Left))
            {
                newX = Position.X - Speed * deltaTime;
                Position = new Vector2(newX, Position.Y);
            }

            if (keyState.IsKeyDown(Keys.Up))
            {
                newY = Position.Y - Speed * deltaTime;
                Position = new Vector2(Position.X, newY);
            }

            if (keyState.IsKeyDown(Keys.Down))
            {
                newY = Position.Y + Speed * deltaTime;
                Position = new Vector2(Position.X, newY);
            }
        }
    }
}
