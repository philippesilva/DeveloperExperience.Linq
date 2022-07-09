namespace DeveloperExperience.Linq.Extensions
{
    public static class WhereIfExtensions
    {
        public static IEnumerable<TSource> WhereIf<TSource>(this IEnumerable<TSource> source, bool condition, Func<TSource, bool> predicate)
            => condition ? source.Where(predicate) : source;
    }
}
