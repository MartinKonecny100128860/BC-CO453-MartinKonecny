using System;

namespace MonoGameRPG
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new RPG_Game())
                game.Run();
        }
    }
}