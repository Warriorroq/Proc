using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        Proc.Program prog;
        [SetUp]
        public void Setup()
        {
            prog = new Proc.Program();
        }

        [Test]
        public void CheckWorkIsPower5()
        {
            Assert.True(prog.IsPower5(125));
        }
        [Test]
        public void CheckWorkSing2PlusSing0Are2()
        {
            Assert.AreEqual(prog.Sign(2) + prog.Sign(0), 1);
        }
        [Test]
        public void CheckWorkSircleS2()
        {
            double result = 3.14 * 2 * 2;
            Assert.AreEqual(prog.CircleS(2),result, prog.CircleS(2)/20);
        }
    }
}