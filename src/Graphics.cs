using System;
using System.Collections.Generic;

namespace BoyJackEngine
{
    public class Texture
    {
        public string TextureName { get; private set; }

        public Texture(string name)
        {
            TextureName = name;
        }
        
        // Дополнительные свойства, такие как ширина, высота и т.д., могут быть добавлены по мере необходимости.
    }

    public class Graphics
    {
        private List<Texture> _loadedTextures;

        public Graphics()
        {
            _loadedTextures = new List<Texture>();
            Console.WriteLine("Graphics system initialized.");
        }

        // Метод для загрузки текстуры
        public void LoadTexture(string textureName)
        {
            var texture = new Texture(textureName);
            _loadedTextures.Add(texture);
            Console.WriteLine($"Texture loaded: {textureName}");
        }

        // Метод для отрисовки текстуры (или объекта)
        public void DrawTexture(string textureName, float x, float y)
        {
            // Проверка на существование текстуры
            var texture = _loadedTextures.Find(t => t.TextureName == textureName);
            if (texture != null)
            {
                Console.WriteLine($"Drawing {texture.TextureName} at position ({x}, {y})");
            }
            else
            {
                Console.WriteLine($"Error: Texture {textureName} not found.");
            }
        }

        // Метод для очистки графических ресурсов
        public void Cleanup()
        {
            _loadedTextures.Clear();
            Console.WriteLine("Graphics resources cleaned up.");
        }
    }
}
