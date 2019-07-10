using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace DeveloperTests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_should_not_throw()
        {
            Program.Main(null);
        }
    }

    public class WordCounterTests
    {
        [Fact]
        public void ByWord_should_count_words()
        {
            var (byWord, _) = WordCounter.Do("I have a transportation device which is a red bike which I love to ride.");
            byWord.Should().BeEquivalentTo(new Dictionary<string, int>
            {
                {"I", 2},
                {"have", 1},
                {"a", 2},
                {"transportation", 1},
                {"device", 1},
                {"which", 2},
                {"is", 1},
                {"red", 1},
                {"bike", 1},
                {"love", 1},
                {"to", 1},
                {"ride", 1},
            });
        }

        [Fact]
        public void ByLenght_should_count_word_by_length()
        {
            var (_, byLenght) = WordCounter.Do("I have a transportation device which is a red bike which I love to ride.");
            byLenght.Should().BeEquivalentTo(new Dictionary<int, int>
            {
                {1, 4},
                {2, 2},
                {3, 1},
                {4, 4},
                {5, 2},
                {6, 1},
                {14, 1},
            });
        }
    }

    public class StringReverserTests
    {
        [Fact]
        public void Should_reverse_string()
        {
            var actual = StringReverser.Do("I have a transportation device which is a red bike which I love to ride.");
            actual.Should().Be(".edir ot evol I hcihw ekib der a si hcihw ecived noitatropsnart a evah I");
        }

        [Fact]
        public void Should_handle_empty_string()
        {
            var actual = StringReverser.Do("");
            actual.Should().Be("");
        }
    }
}