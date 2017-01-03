using NUnit.Framework;

namespace OneOf.Tests
{
    public class BaseClassTests
    {
        [Test]
        public void CanMatchOnBase()
        {
            Response x = new Response.MethodNotAllowed();
            Assert.AreEqual(true, x.Match(methodNotAllowed => true,
                                          invokeSuccessResponse => false));
        }
    }
}
