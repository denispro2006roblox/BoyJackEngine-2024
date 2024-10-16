using System;
using System.Collections.Generic;
using System.IO;

namespace BoyJackEngine
{
    public class Engine
    {
        private bool _isRunning;
        private List<GameObject> _gameObjects;
        private Graphics _graphics; // Объект графики

        // Дополнительные данные о состоянии игры
        public int CurrentLevel { get; private set; }
        public int PlayerHealth { get; private set; }

        public Engine()
        {
            _isRunning = false;
            _gameObjects = new List<GameObject>();
            _graphics = new Graphics(); // Инициализация графики
            CurrentLevel = 1; 
            PlayerHealth = 100; 
        }

        public void Initialize()
        {
            // Загружаем текстуры
            _graphics.LoadTexture("PlayerTexture.png");
            _graphics.LoadTexture("EnemyTexture.png");

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
                Update(); 
                Render(); 
            }
        }

        private void Update()
        {
            foreach (var obj in _gameObjects)
            {
                obj.Update();
            }

            // Здесь можно сделать логику для изменения уровня или здоровья
        }

        private void Render()
        {
            Console.WriteLine("Rendering...");
            foreach (var obj in _gameObjects)
            {
                // Отрисовка объекта с использованием графики
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
