using System.Linq.Expressions;

namespace FlavorVerse.Persistence.Extensions
{
    public static class QueryableExtensions
    {
        //    public static IQueryable<T> IncludeProperties<T>(this IQueryable<T> query, string? includeProperties)
        //        where T : class
        //    {
        //        if (!string.IsNullOrEmpty(includeProperties))
        //        {
        //            foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //            {
        //                query = query.Include(property);
        //            }
        //        }

        //        return query;
        //    }
        //}

        public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string orderByProperty)
        {
            var command = "OrderBy";
            var type = typeof(T);
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

            return source.Provider.CreateQuery<T>(resultExpression);
        }

        public static IQueryable<T> OrderByDescendingDynamic<T>(this IQueryable<T> source, string orderByProperty)
        {
            var command = "OrderByDescending";
            var type = typeof(T);
            var property = type.GetProperty(orderByProperty);
            var parameter = Expression.Parameter(type, "p");
            var propertyAccess = Expression.MakeMemberAccess(parameter, property);
            var orderByExpression = Expression.Lambda(propertyAccess, parameter);
            var resultExpression = Expression.Call(typeof(Queryable), command, new Type[] { type, property.PropertyType }, source.Expression, Expression.Quote(orderByExpression));

            return source.Provider.CreateQuery<T>(resultExpression);
        }
    }
}