using System;
using System.Collections.Generic;

namespace BoyJackEngine
{
    public class Scene
    {
        private List<GameObject> _gameObjects; // Список игровых объектов в сцене
        public string SceneName { get; private set; }

        public Scene(string name)
        {
            SceneName = name;
            _gameObjects = new List<GameObject>();
            Console.WriteLine($"Scene '{SceneName}' created.");
        }

        // Метод для добавления игрового объекта в сцену
        public void AddGameObject(GameObject gameObject)
        {
            _gameObjects.Add(gameObject);
            Console.WriteLine($"GameObject '{gameObject.Name}' added to scene '{SceneName}'.");
        }

        // Метод для удаления игрового объекта из сцены
        public void RemoveGameObject(GameObject gameObject)
        {
            if (_gameObjects.Remove(gameObject))
            {
                Console.WriteLine($"GameObject '{gameObject.Name}' removed from scene '{SceneName}'.");
            }
            else
            {
                Console.WriteLine($"GameObject '{gameObject.Name}' not found in scene '{SceneName}'.");
            }
        }

        // Метод для инициализации сцены
        public void Initialize()
        {
            Console.WriteLine($"Initializing scene '{SceneName}'...");
            foreach (var gameObject in _gameObjects)
            {
                gameObject.Initialize();
            }
        }

        // Метод для обновления всех объектов в сцене
        public void Update()
        {
            foreach (var gameObject in _gameObjects)
            {
                gameObject.Update();
            }
        }

        // Метод для рендеринга всех объектов в сцене
        public void Render(Graphics graphics)
        {
            Console.WriteLine($"Rendering scene '{SceneName}'...");
            foreach (var gameObject in _gameObjects)
            {
                graphics.DrawTexture(gameObject.TextureName, gameObject.PositionX, gameObject.PositionY);
            }
        }
    }
}
