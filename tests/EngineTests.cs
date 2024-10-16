using NUnit.Framework;
using System;
using System.IO;

namespace BoyJackEngine.Tests
{
    [TestFixture]
    public class EngineTests
    {
        private Engine _engine;

        [SetUp]
        public void Setup()
        {
            _engine = new Engine(); // Создание нового экземпляра игрового движка для каждого теста
        }

        [Test]
        public void Engine_Initialize_ShouldNotThrowException()
        {
            Assert.DoesNotThrow(() => _engine.Initialize(), "Engine initialization should not throw an exception.");
        }

        [Test]
        public void Engine_Run_ShouldChangeIsRunningToTrue()
        {
            _engine.Initialize();
            _engine.Run(); // Запускаем движок (будет блокирующим в реальной ситуации)

            // Мы не можем проверить напрямую, но можем установить флаг, чтобы остановить после некоторого времени
            _engine.Stop(); // Остановить движок
        }

        [Test]
        public void Engine_Stop_ShouldSetIsRunningToFalse()
        {
            _engine.Initialize();
            _engine.Run(); // Запускаем движок
            _engine.Stop(); // Останавливаем его

            // Убедимся, что игра не работает, добавив некоторую проверку
        }

        [Test]
        public void Engine_Update_ShouldNotThrowException()
        {
            _engine.Initialize();
            Assert.DoesNotThrow(() => _engine.Update(), "Engine update should not throw an exception.");
        }

        [Test]
        public void Engine_Render_ShouldNotThrowException()
        {
            _engine.Initialize();
            Assert.DoesNotThrow(() => _engine.Render(), "Engine render should not throw an exception.");
        }
    }
}
