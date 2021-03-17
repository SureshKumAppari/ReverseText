using System;
using System.IO;
using System.IO.Abstractions;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Text;

namespace ReverseText
{
    // IMPORTANT: make sure you read the instructions in README.md

    class Program
    {
        static void Main(string[] args)
        {
            const string filePath = "TestTextFile.txt";

            // string text = ... call FileTextReverser to reverse the files text
            IFileSystem fileSystem = new FileSystem();
            FileTextReverser fileTextReverser = new FileTextReverser(fileSystem);
            string reversedText = fileTextReverser.ReverseFileContents(filePath);
            if (string.IsNullOrEmpty(reversedText))
                Console.WriteLine(string.Empty);

            fileSystem.File.WriteAllText(filePath, reversedText);

        }
    }

    public class FileTextReverser
    {
        readonly IFileSystem fileSystem;
        public FileTextReverser(IFileSystem fileSystem)
        {
            this.fileSystem = fileSystem;
        }

        public string ReverseFileContents(string filePath)
        {
            // TODO: read text file, reverse the text, save reversed text back to the same file
            if (!fileSystem.File.Exists(filePath))
            {
                return string.Empty;
            }

            string content = fileSystem.File.ReadAllText(filePath);
            return Split(content);
        }

        private string Split(string content)
        {
            //string[] words = content.Split(' ');
            char[] charactersArray = content.ToCharArray();
            string reversedSentense = string.Empty;
            for (int i = charactersArray.Length - 1; i >= 0; i--)
            {
                reversedSentense += charactersArray[i];
            }
            string[] reversedWords = reversedSentense.Split(' ');

            string actualStringInReversedWords = string.Empty;
            for (int j = reversedWords.Length - 1; j >= 0; j--)
            {
                actualStringInReversedWords += reversedWords[j] + " ";
            }
            return actualStringInReversedWords.Trim();
        }
    }
}
