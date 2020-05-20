using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace projekt.UnitTests
{
    [TestFixture]
    class Form1Tests
    {
        [Test]
        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 4)]
        public void Poziom_Tick_WhenCalled_SetTheDirectionOfTheBallToTheRightAndUp(int a, int expectedResult)
        {
            a++;
            var result = a;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        public void Poziom_Tick_WhenCalled_SetTheDirectionOfTheBallToTheLeftAndDown(int a, int expectedResult)
        {
            a--;
            var result = a;
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        [TestCase(1, 15, 15)]
        [TestCase(2, 15, 30)]
        [TestCase(3, 15, 45)]
        public void Poziom_Tick_WhenCalled_MoveTheBal(int poziom, int speed, int expectedResult)
        {
            var result = poziom * speed;
            Assert.That(result, Is.EqualTo(expectedResult));

        }
        [Test]
        public void tmrDeska_Tick_WhenCalled_MoveThePlayerRight()
        {
            
        }
        [Test]
        public void tmrDeska_Tick_WhenCalled_MoveThePlayerLeft()
        {

        }

        bool _lewo = false, _prawo = false;
        [Test]
        [TestCase(37)]
        public void Form1_KeyDown_WhenLeftKeyIsPressed_MoveTheSliderLeft(int KeyCode)
        {
            if (KeyCode == 37)
                _lewo = true;
            Assert.IsTrue(_lewo);
        }

        [Test]
        [TestCase(39)]
        public void Form1_KeyDown_WhenRightKeyIsPressed_MoveTheSliderRight(int KeyCode)
        {
            if (KeyCode == 39)
                _prawo = true;
            Assert.IsTrue(_prawo);

        }
        [Test]
        [TestCase(37)]
        public void Form1_KeyUp_WhenLeftTheKeyIsNotPressed_StopTheSlider(int KeyCode)
        {
            if (KeyCode == 37)
                _lewo = false;
            Assert.IsFalse(_lewo);
        }
        [Test]
        [TestCase(39)]
        public void Form1_KeyUp_WhenRightTheKeyIsNotPressed_StopTheSlider(int KeyCode)
        {
            if (KeyCode == 39)
                _prawo = false;
            Assert.IsFalse(_prawo);
        }
        [Test]
        public void Pion_Tick_WhenTheBallHitsTheGround_EndTheGame()
        {

        }


        [Test]
        public void Pion_Tick_WhenTheBallHitsTheObstacle_RemoveTheObstacleAndChangeTheDirection()
        {

        }
        [Test]
        public void Pion_Tick_WhenTheObstacleIsRemoved_AddAPointToTheScore()
        {

        }
    }
}
