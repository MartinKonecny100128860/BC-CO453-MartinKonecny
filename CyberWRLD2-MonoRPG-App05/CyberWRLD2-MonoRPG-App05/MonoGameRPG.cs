using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGameRPG
{
    public class RPG_Game : Game
    {
        public const int HD_Height = 720;
        public const int HD_Width = 1280;

        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Texture2D playerImage;
        private Texture2D walkingLeftImages;
        private Texture2D walkingRightImages;

        private Texture2D backgroundImage;

        private PlayerSprite player;

        public RPG_Game()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
            graphics.ApplyChanges();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            playerImage = Content.Load<Texture2D>("Player/player");
            walkingLeftImages = Content.Load<Texture2D>("Player/walkingLeft");
            walkingRightImages = Content.Load<Texture2D>("Player/walkingRight");

            backgroundImage = Content.Load<Texture2D>("background");

            SetupSprites();

            // TODO: use this.Content to load your game content here
        }

        private void SetupSprites()
        {
            player = new PlayerSprite(200, 300);
            player.Image = playerImage;
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            player.Update(gameTime);
            base.Update(gameTime);

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            Vector2 position = new Vector2(0, 0);

            spriteBatch.Draw(
                backgroundImage, position, Color.White);
            spriteBatch.Draw(player.Image, player.Position, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}