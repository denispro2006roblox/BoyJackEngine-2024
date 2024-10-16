using System;
using System.Collections.Generic;

namespace BoyJackEngine
{
    public class Engine
    {
        private bool _isRunning;
        private List<GameObject> _gameObjects;
        private Graphics _graphics; // Объект графики
        private Input _input;       // Объект ввода

        public int CurrentLevel { get; private set; }
        public int PlayerHealth { get; private set; }

        public Engine()
        {
            _isRunning = false;
            _gameObjects = new List<GameObject>();
            _graphics = new Graphics(); // Инициализация графики
            _input = new Input();       // Инициализация ввода
            CurrentLevel = 1; 
            PlayerHealth = 100; 
        }

        public void Initialize()
        {
            // Загружаем текстуры с соответствующими размерами
            _graphics.LoadTexture("PlayerTexture.png", 64, 64);
            _graphics.LoadTexture("EnemyTexture.png", 64, 64);

            // Создаем игровые объекты
            CreateGameObjects();

            Console.WriteLine("Engine initialized successfully.");
        }

        private void CreateGameObjects()
        {
            _gameObjects.Add(new GameObject("Player", 50, 50));
            _gameObjects.Add(new GameObject("Enemy", 100, 100));
        }

        public void Run()
        {
            _isRunning = true;
            while (_isRunning)
            {
                // Обновление ввода
                _input.Update();

                Update(); 
                Render(); 

                // Проверка нажатия клавиши для выхода
                if (_input.IsKeyPressed(ConsoleKey.Escape))
                {
                    Stop(); // Выходим из игры при нажатии Escape
                }
            }
        }

        private void Update()
        {
            foreach (var obj in _gameObjects)
            {
                obj.Update();
            }

            // Пример проверки нажатия клавиш для игрока
            if (_input.IsKeyDown(ConsoleKey.W))
            {
                Console.WriteLine("Moving player up");
                // Логика перемещения игрока вверх
            }
            if (_input.IsKeyDown(ConsoleKey.S))
            {
                Console.WriteLine("Moving player down");
                // Логика перемещения игрока вниз
            }
            if (_input.IsKeyDown(ConsoleKey.A))
            {
                Console.WriteLine("Moving player left");
                // Логика перемещения игрока влево
            }
            if (_input.IsKeyDown(ConsoleKey.D))
            {
                Console.WriteLine("Moving player right");
                // Логика перемещения игрока вправо
            }

            // Здесь можно сделать логику для изменения уровня или здоровья
        }

        private void Render()
        {
            Console.WriteLine("Rendering...");
            foreach (var obj in _gameObjects)
            {
                _graphics.DrawTexture(obj.Name == "Player" ? "PlayerTexture.png" : "EnemyTexture.png", obj.PositionX, obj.PositionY);
            }
        }

        public void Stop()
        {
            _isRunning = false;
            _graphics.Cleanup(); // Очистка графических ресурсов
            Console.WriteLine("Engine stopped.");
        }
    }
}
