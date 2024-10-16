using System;

namespace BoyJackEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(); // Создание экземпляра игры
            game.Initialize(); // Инициализация игры
            game.Run(); // Запуск игрового цикла
        }
    }
}
