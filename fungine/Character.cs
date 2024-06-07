using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace fungine;

public class Character
{
    private Vector2 screenPosition = Vector2.Zero;
    float scale = 4.0f;
    private string animations_idle_spritesheet_filename = "knight_idle_spritesheet";
    private Texture2D animations_idle_spritesheet_texture;
    private int animations_idle_spritesheet_cols = 6;
    private int animations_idle_spritesheet_rows = 1;
    private int animations_idle_spritesheet_spriteWidth =16;
    private int animations_idle_spritesheet_spriteHeight=16;
    private int animations_idle_currentFrame=0;

    public void LoadContent(ContentManager Content) {
        animations_idle_spritesheet_texture = Content.Load<Texture2D>(animations_idle_spritesheet_filename);
    }

    public void Draw(GameTime gameTime, SpriteBatch _spriteBatch)
    {
        _spriteBatch.Draw(
            animations_idle_spritesheet_texture, 
            new Rectangle((int)screenPosition.X, (int)screenPosition.Y, (int)(animations_idle_spritesheet_spriteWidth * scale), (int)(animations_idle_spritesheet_spriteHeight * scale)),
            new Rectangle(
                animations_idle_currentFrame % animations_idle_spritesheet_cols * animations_idle_spritesheet_spriteWidth, 
                animations_idle_currentFrame / animations_idle_spritesheet_cols * animations_idle_spritesheet_spriteHeight,
                animations_idle_spritesheet_spriteWidth,
                animations_idle_spritesheet_spriteHeight
            ),
            Color.White
            );
    }    

}