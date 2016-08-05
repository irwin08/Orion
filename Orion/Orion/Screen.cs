using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Orion
{
    public class Screen
    {
        protected GraphicsDevice _device = null;

        public string Name
        {
            get;
            set;
        }

        public Screen(GraphicsDevice device, string name)
        {
            Name = name;
            _device = device;
        }

        public virtual bool Init()
        {
            return true;
        }

        public virtual void Shutdown()
        {

        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(GameTime gameTime)
        {

        }
    }
}
