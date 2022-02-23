using NUnit.Framework;
using FileLoggerKata;
using NSubstitute;

namespace FileLoggerTests
{
    public class Tests
    {
        [TestFixture]
        public class FileLogerTests
        {
            private readonly IFileSystem _fileSystem = Substitute.For<IFileSystem>();
            private readonly IDateProvider _dateProvider = Substitute.For<IDateProvider>();
            private const string testMessage = "Testing_Log_Message";
            private FileLogger fileLogger;

            [SetUp]
            public void Setup()
            {
                fileLogger = new FileLogger(_fileSystem, _dateProvider);
            }

            [Test]
            public void GivenNewMessage_ShouldUpdateLogFile()
            {
                Assert.Pass();
            }
        }
    }
}
