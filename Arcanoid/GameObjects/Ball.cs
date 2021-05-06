using Arcanoid.Components;
using Arcanoid.Core;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Arcanoid.GameObjects
{
    public class Ball : GameObject
    {
        
        public Ball(Texture2D texture)
        {
            AddComponent(new PositionComponent());
            AddComponent(new TextureComponent(texture));
            AddComponent(new VelocityComponent());
            AddComponent(new BallControlComponent());
        }
    }
}