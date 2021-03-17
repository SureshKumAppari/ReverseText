using NUnit.Framework;
using NUnit.Framework.Constraints;
using ReverseText;
using System.Runtime.CompilerServices;
using System.IO.Abstractions;
using Moq;

namespace ReverseText.Test
{
    public class ReverseTextTests
    {
        FileTextReverser fileTextReverser;
        Mock<IFileSystem> fileSystem;
        [SetUp]
        public void Setup()
        {
            fileSystem = new Mock<IFileSystem>();
            fileTextReverser = new FileTextReverser(fileSystem.Object);
            fileSystem.Setup(fs => fs.File.Exists(It.IsAny<string>())).Returns(true);
            fileSystem.Setup(fs => fs.File.ReadAllText(It.IsAny<string>())).Returns("My Name Is Suresh");
        }

        [Test]
        public void ReversingTextIsNotEmpty()
        {
            string stringToReverse = fileTextReverser.ReverseFileContents(@"c:\dummyPath\dummy.txt");
            Assert.IsNotEmpty(stringToReverse);
        }

        [Test]
        public void ReversingTextReturnsEmpty()
        {
            fileSystem.Setup(fs => fs.File.Exists(It.IsAny<string>())).Returns(false);
            string stringToReverse = fileTextReverser.ReverseFileContents(@"c:\dummyPath\dummy.txt");
            Assert.IsEmpty(stringToReverse);
        }
    }
}