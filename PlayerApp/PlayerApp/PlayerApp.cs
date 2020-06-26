using System;

namespace PlayerApp
{
    internal class PlayerApp
    {
        private static void Main()
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo("Player App Example");

            PlayerUI myTeam = new PlayerUI();
            myTeam.MainMethod();

            Console.ReadKey();
        }
    }
}