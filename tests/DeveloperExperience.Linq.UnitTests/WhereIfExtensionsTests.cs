using DeveloperExperience.Linq.Extensions;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperExperience.Linq.UnitTests
{
    public class WhereIfExtensionsTests
    {
        private readonly IEnumerable<int> _items = new List<int> { 1, 2, 3, 2, 4 };

        [Test]
        public void WhereIf()
        {
            var items = _items.WhereIf(_items.Any(), x => x.Equals(2));

            Assert.AreEqual(items.Count(), 2);
        }
    }
}