using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace Lab6.Tests
{
    public class Tests
    {
        private ILinkedList<string> _linkedList;

        [SetUp]
        public void Setup()
        {
            _linkedList = new YourListName<string>(); // TODO add your linked list
        }

        [Test]
        public void AddLast_EmptyList_GetFirst()
        {
            // act
            _linkedList.AddLast("1");

            // assert
            _linkedList[0].Should().Be("1");
        }

        [Test]
        public void AddLast_WithExistingElement_GetFirst()
        {
            // arrange
            _linkedList.AddLast("1");

            // act
            _linkedList.AddLast("2");

            // asser
            _linkedList[1].Should().Be("2");
        }

        [Test]
        public void AddFirst_ToEmptyList()
        {
            // act
            _linkedList.AddFirst("1");

            // asser
            _linkedList[0].Should().Be("1");
        }


        [Test]
        public void AddAfter()
        {
            // arrange
            _linkedList.AddLast("1");
            _linkedList.AddLast("3");

            // act
            _linkedList.AddAfter("2", 0);

            // asser
            _linkedList[0].Should().Be("1");
            _linkedList[1].Should().Be("2");
            _linkedList[2].Should().Be("3");
        }


        [Test]
        public void Enumerable()
        {
            // arrange
            _linkedList.AddLast("1");
            _linkedList.AddLast("2");
            _linkedList.AddLast("3");

            // act
            var list = _linkedList.ToList();

            // asser
            list[0].Should().Be("1");
            list[1].Should().Be("2");
            list[2].Should().Be("3");
        }
    }
}