using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace fungine;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    // Character variables:
    int character_currentFrame = 3;
    Vector2 character_screenPosition = Vector2.Zero;
    int character_frameWidth=16;
    int character_frameHeight=16;
    float character_scale=2.0f;
    string character_animations_idle_spritesheetName="knight_idle_spritesheet";
    int character_animations_idle_spritesheet_cols=6;
    int character_animations_idle__spritesheet_rows=1;
    Texture2D character_animations_idle_texture;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        // TODO: use this.Content to load your game content here
        character_animations_idle_texture = Content.Load<Texture2D>(character_animations_idle_spritesheetName);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here
        _spriteBatch.Begin();
        _spriteBatch.Draw(
            character_animations_idle_texture, 
            new Rectangle((int)character_screenPosition.X, (int)character_screenPosition.Y, (int)(character_frameWidth * character_scale), (int)(character_frameHeight * character_scale)),
            new Rectangle(
                (character_currentFrame % character_animations_idle_spritesheet_cols) * character_frameWidth, 
                (character_currentFrame / character_animations_idle_spritesheet_cols) * character_frameWidth,
                character_frameWidth,
                character_frameHeight
            ),
            Color.White
            );
        _spriteBatch.End();
        base.Draw(gameTime);
    }
}
