using System;

namespace BoyJackEngine
{
    public class GameObject
    {
        public string Name { get; private set; }
        public string TextureName { get; private set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }

        public GameObject(string name, string textureName, float x, float y)
        {
            Name = name;
            TextureName = textureName;
            PositionX = x;
            PositionY = y;
        }

        public void Initialize()
        {
            Console.WriteLine($"GameObject '{Name}' initialized at ({PositionX}, {PositionY}).");
        }

        public void Update()
        {
            // Логика обновления объекта
            Console.WriteLine($"GameObject '{Name}' updated.");
        }
    }
}
