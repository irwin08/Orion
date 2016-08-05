using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Orion
{
    public static class ScreenManager
    {
        static private List<Screen> _screens = new List<Screen>();
        static private bool _started = false;
        static private Screen _previous = null;

        static public Screen ActiveScreen = null;

        static public void AddScreen(Screen screen)
        {
            foreach (Screen scr in _screens)
            {
                if (scr.Name == screen.Name)
                {
                    return;
                }
            }
            _screens.Add(screen);
        }

        static public Screen GetScreen(int id)
        {
            return _screens[id];
        }

        static public void GotoScreen(string name)
        {
            foreach (Screen screen in _screens)
            {
                if (screen.Name == name)
                {
                    _previous = ActiveScreen;
                    if (ActiveScreen != null)
                    {
                        ActiveScreen.Shutdown();
                    }

                    ActiveScreen = screen;
                    if (_started)
                        ActiveScreen.Init();
                    return;
                }
            }
        }

        static public void Init()
        {
            _started = true;
            if (ActiveScreen != null)
            {
                ActiveScreen.Init();
            }
        }

        static public void GoBack()
        {
            if (_previous != null)
            {
                GotoScreen(_previous.Name);
                return;
            }
        }

        static public void Update(GameTime gameTime)
        {
            if (_started == false)
                return;
            if (ActiveScreen != null)
            {
                ActiveScreen.Update(gameTime);
            }
        }

        static public void Draw(GameTime gameTime)
        {
            if (_started == false)
                return;
            if (ActiveScreen != null)
            {
                ActiveScreen.Draw(gameTime);
            }
        }
    }
}
