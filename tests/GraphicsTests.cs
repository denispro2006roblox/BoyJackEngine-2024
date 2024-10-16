using NUnit.Framework;
using System;

namespace BoyJackEngine.Tests
{
    [TestFixture]
    public class GraphicsTests
    {
        private Graphics _graphics;

        [SetUp]
        public void Setup()
        {
            _graphics = new Graphics(); // Создание нового экземпляра графики для каждого теста
        }

        [Test]
        public void Graphics_Initialize_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => _graphics.Initialize(), "Graphics initialization should not throw an exception.");
        }

        [Test]
        public void Graphics_Render_ShouldNotThrowException()
        {
            _graphics.Initialize();
            Assert.DoesNotThrow(() => _graphics.Render(), "Graphics render should not throw an exception.");
        }

        [Test]
        public void Graphics_Clear_ShouldNotThrowException()
        {
            _graphics.Initialize();
            Assert.DoesNotThrow(() => _graphics.Clear(), "Graphics clear should not throw an exception.");
        }

        [Test]
        public void Graphics_SetColor_ValidColor_ShouldSetColor()
        {
            _graphics.Initialize();
            // Задаем цвет
            var color = new Color(255, 0, 0); // Пример цвета (красный)
            _graphics.SetColor(color);
            // Предполагаем, что у вас есть метод GetCurrentColor() для проверки текущего цвета
            Assert.AreEqual(color, _graphics.GetCurrentColor(), "The current color should be set correctly.");
        }

        [Test]
        public void Graphics_DrawShape_ShouldNotThrowException()
        {
            _graphics.Initialize();
            // Пример вызова метода отрисовки формы
            Assert.DoesNotThrow(() => _graphics.DrawShape(new Rectangle(0, 0, 100, 100)), "Drawing shape should not throw an exception.");
        }
    }
}
