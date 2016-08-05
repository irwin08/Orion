using System;

namespace Orion
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (OrionGame game = new OrionGame())
            {
                game.Run();
            }
        }
    }
#endif
}

