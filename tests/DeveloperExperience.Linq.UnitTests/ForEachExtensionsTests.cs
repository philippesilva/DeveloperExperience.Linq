using DeveloperExperience.Linq.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace DeveloperExperience.Linq.UnitTests
{
    public class ForEachExtensionsTests
    {
        private readonly IEnumerable<int> _items = new List<int> { 1, 2, 3 };

        [Test]
        public void ForEach()
        {
            var count = 0;

            _items.ForEach(x =>
            {
                count += x + 1;
            });

            Assert.AreEqual(count, 9);
        }
    }
}