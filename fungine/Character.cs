using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace fungine;

public class Character
{
    private Vector2 screenPosition = Vector2.Zero;
    float scale = 4.0f;
    private string animations_idle_spritesheet_filename;
    private Texture2D animations_idle_spritesheet_texture;
    private int animations_idle_spritesheet_cols = 6;
    private int animations_idle_spritesheet_rows = 1;
    private int animations_idle_spritesheet_spriteWidth =16;
    private int animations_idle_spritesheet_spriteHeight=16;
    private int animations_idle_startingFrame=0;
    private int animations_idle_currentFrame;
    private int animation_idle_maxFrames = 6;
    private float animations_idle_frameTime;

    private float animation_idle_clock = 0.0f;

    public Character(string spritesheet_filename)
    {
        // animation lasts 1 second. Is this a magic number ? Yes, it is.
        //animations_idle_spritesheet_texture = texture;
        animations_idle_frameTime = 1.0f/animation_idle_maxFrames;
        animations_idle_currentFrame = animations_idle_startingFrame;

    }
    public void Update(float deltaTime)
    {
        animation_idle_clock += deltaTime;
        if (animation_idle_clock > animations_idle_frameTime)
        {
            animations_idle_currentFrame++;
            animation_idle_clock = 0.0f;
        }
        if(animations_idle_currentFrame == animation_idle_maxFrames)
        {
            animations_idle_currentFrame = 0;
        }

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