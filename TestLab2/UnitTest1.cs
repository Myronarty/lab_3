using lab3;
using NUnit.Framework;

namespace TestLab3
{
    public class UnitTest1
    {
        [Test]
        public void Clone_ShouldReturnNewRectangleWithSameValues()
        {
            Rectangle original = new Rectangle
            {
                X = 10,
                Y = 20,
                Color = "blue",
                Width = 100,
                Height = 200
            };

            Rectangle copy = (Rectangle)original.Clone();

            Assert.That(original.X, Is.EqualTo(copy.X));
            Assert.That(original.Y, Is.EqualTo(copy.Y));
            Assert.That(original.Color, Is.EqualTo(copy.Color));
            Assert.That(original.Width, Is.EqualTo(copy.Width));
            Assert.That(original.Height, Is.EqualTo(copy.Height));
            Assert.That(original, Is.Not.EqualTo(copy));
        }

        [Test]
        public void Clone_ModifyingCloneShouldNotAffectOriginal()
        {
            Rectangle original = new Rectangle
            {
                X = 5,
                Y = 15,
                Color = "green",
                Width = 50,
                Height = 60
            };

            Rectangle copy = (Rectangle)original.Clone();
            copy.X = 999;
            copy.Color = "red";

            Assert.That(original.X, Is.Not.EqualTo(copy.X));
            Assert.That(original.Color, Is.Not.EqualTo(copy.Color));
        }

        [Test]
        public void ConstructorWithParameters_ShouldSetPropertiesCorrectly()
        {
            Rectangle rectangle = new Rectangle
            {
                X = 1,
                Y = 2,
                Color = "yellow",
                Width = 10,
                Height = 20
            };

            Assert.That(rectangle.X, Is.EqualTo(1));
            Assert.That(rectangle.Y, Is.EqualTo(2));
            Assert.That(rectangle.Color, Is.EqualTo("yellow"));
            Assert.That(rectangle.Width, Is.EqualTo(10));
            Assert.That(rectangle.Height, Is.EqualTo(20));
        }
    }
}
