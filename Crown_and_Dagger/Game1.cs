using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

//using Animations2D;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;


namespace Crown_and_Dagger;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    // directions and forces
    const int NEGATIVE = -1;
    const int STOPPED = 0;
    const int POSITIVE = 1;

    // scroll screen
    const int SCROLL_LEFT = 1;
    const int SCROLL_RIGHT = -1;

    // kb/m
    MouseState mouse;
    MouseState prevMouse;
    KeyboardState keyboard;
    KeyboardState prevKb;

    // game states
    const int MENU = 0;
    const int INSTRUCTIONS = 1;
    const int GAME = 2;
    const int ENDGAME = 3;
    const int PAUSE = 4;

    // screenwidth/screenheight
    int screenWidth = 1920;
    int screenHeight = 1080;

    //variables for players
    Texture2D knightIdleImg;
    Texture2D knightRunImg;
    Texture2D knightJumpImg;
    Texture2D knightHurtImg;
    Texture2D knightDefendImg;
    Texture2D knightAttackImg;
    Texture2D knightDeathImg;

    AnimatedTexture knightIdleAnim;
    AnimatedTexture knightRunAnim;
    AnimatedTexture knightJumpAnim;
    AnimatedTexture knightHurtAnim;
    AnimatedTexture knightDefendAnim;
    AnimatedTexture knightAttackAnim;
    AnimatedTexture knightDeathAnim;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
        spriteTexture = new AnimatedTexture(Vectore2.Zero, rotation, scale, depth);
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
        knightIdleImg = Content.Load<Texture2D>("Sprites/Players/Knight/IDLE");
        knightRunImg = Content.Load<Texture2D>("Sprites/Players/Knight/RUN");
        knightJumpImg = Content.Load<Texture2D>("Sprites/Players/Knight/JUMP");
        knightHurtImg = Content.Load<Texture2D>("Sprites/Players/Knight/HURT");
        knightDefendImg = Content.Load<Texture2D>("Sprites/Players/Knight/DEFEND");
        knightAttackImg = Content.Load<Texture2D>("Sprites/Players/Knight/ATTACK");
        knightDeathImg = Content.Load<Texture2D>("Sprites/Players/Knight/DEATH");
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
        base.Draw(gameTime);
    }
}
