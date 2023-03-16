using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
            //GameEventManager.OnGameStart -= StartGame; unsubscribe
        }
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Drawing visuals...");
        }

        private void GameOver()
        {
            Console.WriteLine("Rendering Endgine stopped");
        }


    }
}
