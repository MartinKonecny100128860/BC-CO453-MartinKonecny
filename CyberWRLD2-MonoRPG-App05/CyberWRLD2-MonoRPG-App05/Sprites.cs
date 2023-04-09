using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGameRPG
{
    public class Sprites
    {
        public Rectangle Boundary { get; set; }
        public Vector2 StartPosition { get; set; }
        public Vector2 Position { get; set;}

        public int MaxSpeed { get; set; }
        public int MinSpeed { get; set; }
        public int Speed { get; set; }
        public Texture2D Image { get; set; }
        public bool IsVisible { get; set; }
        public bool IsAlive { get; set; }
        public int width
        {
            get { return Image.Width;}
        }
        public int height
        {
            get { return Image.Height; }
        }

        public Rectangle BoundingBox
        {
            get
            {
                return new Rectangle(
                    (int)Position.X, (int)Position.Y, width, height);

            }

        }

        protected float deltaTime;

        public Sprites(int x, int y)
        {
            Position = new Vector2(x, y);
            StartPosition = Position;

            MaxSpeed = 1000;
            MinSpeed = 200;
            Speed = MinSpeed;

            IsVisible = true;
            IsAlive = true;

        }

        public Vector2 GetCentrePosition()
        {
            return new Vector2(Position.X - Image.Width / 2,
                Position.Y - Image.Height / 2);
        }

        public void ResetPosition()
        {
            Position = StartPosition;
        }

        public virtual void Update (GameTime gameTime)
        {
            deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
        } 


    }

}
