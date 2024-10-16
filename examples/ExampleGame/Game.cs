using System;

namespace BoyJackEngine
{
    public class Game
    {
        private Engine _engine;
        private bool _isRunning;

        public Game()
        {
            _engine = new Engine(); // Инициализация движка
            _isRunning = false;
        }

        public void Initialize()
        {
            _engine.Initialize(); // Инициализация движка
            Console.WriteLine("Game initialized successfully.");
        }

        public void Run()
        {
            _isRunning = true;
            Console.WriteLine("Game is running...");
            while (_isRunning)
            {
                Update();
                Render();
                // Здесь вы можете добавить логику для обработки ввода или других соображений
            }
        }

        private void Update()
        {
            _engine.Update(); // Обновление состояния игры
        }

        private void Render()
        {
            _engine.Render(); // Отрисовка сцены
        }

        public void Stop()
        {
            _isRunning = false; // Остановка цикла игры
            _engine.Stop(); // Остановка движка
            Console.WriteLine("Game stopped.");
        }
    }
}
