using System;

namespace BoyJackEngine
{
    public class Engine
    {
        private bool _isRunning;
        private Scene _currentScene; // Текущая сцена
        private Graphics _graphics; // Объект графики

        public Engine()
        {
            _isRunning = false;
            _graphics = new Graphics(); // Инициализация графики

            // Пример создания сцены
            _currentScene = new Scene("MainMenu");
        }

        public void Initialize()
        {
            // Загружаем текстуры
            _graphics.LoadTexture("PlayerTexture.png", 64, 64);
            _graphics.LoadTexture("EnemyTexture.png", 64, 64);

            // Создаем игровые объекты и добавляем их в сцену
            var player = new GameObject("Player", "PlayerTexture.png", 50, 50);
            var enemy = new GameObject("Enemy", "EnemyTexture.png", 100, 100);

            _currentScene.AddGameObject(player);
            _currentScene.AddGameObject(enemy);

            // Инициализируем сцену
            _currentScene.Initialize();

            Console.WriteLine("Engine initialized successfully.");
        }

        public void Run()
        {
            _isRunning = true;
            while (_isRunning)
            {
                Update();
                Render();
            }
        }

        private void Update()
        {
            _currentScene.Update();
        }

        private void Render()
        {
            _currentScene.Render(_graphics);
        }

        public void Stop()
        {
            _isRunning = false;
            _graphics.Cleanup(); // Очистка графических ресурсов
            Console.WriteLine("Engine stopped.");
        }
    }
}
