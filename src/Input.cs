using System;
using System.Collections.Generic;

namespace BoyJackEngine
{
    public class Input
    {
        private HashSet<ConsoleKey> _currentKeys;
        private HashSet<ConsoleKey> _previousKeys;

        public Input()
        {
            _currentKeys = new HashSet<ConsoleKey>();
            _previousKeys = new HashSet<ConsoleKey>();
        }

        // Метод для обновления состояния ввода
        public void Update()
        {
            // Переключаем текущие клавиши в предыдущие
            _previousKeys = new HashSet<ConsoleKey>(_currentKeys);
            _currentKeys.Clear();

            // Считываем нажатые клавиши
            while (Console.KeyAvailable)
            {
                var key = Console.ReadKey(intercept: true).Key;
                _currentKeys.Add(key);
            }
        }

        // Метод для проверки, нажата ли клавиша
        public bool IsKeyPressed(ConsoleKey key)
        {
            return _currentKeys.Contains(key);
        }

        // Метод для проверки, была ли клавиша нажата в этом кадре
        public bool IsKeyDown(ConsoleKey key)
        {
            return _currentKeys.Contains(key) && !_previousKeys.Contains(key);
        }

        // Метод для проверки, была ли клавиша отпущена в этом кадре
        public bool IsKeyUp(ConsoleKey key)
        {
            return !_currentKeys.Contains(key) && _previousKeys.Contains(key);
        }
    }
}
