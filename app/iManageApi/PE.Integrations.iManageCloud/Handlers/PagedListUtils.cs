using System;
using System.Collections.Generic;
using System.Linq;
using PE.Common.DataTypes;

namespace PE.Integrations.iManageCloud.Handlers {

    /// <summary>
    /// Copied over from ServiceBus to not require a dependency on it, which requires .NET framework
    /// </summary>
    internal static class PagedListUtils {

        /// <summary>
        /// Build a paged list with an IEnumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="converter"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static PagedList<T> ToPagedList<T>(
            this IEnumerable<T> list,
            int pageIndex,
            int pageSize,
            int totalCount) {
            if (pageSize == 0) {
                return new PagedList<T>(pageIndex, pageSize);
            }
            var count = list.Count();
            if (count == 0) {
                return new PagedList<T>(0, pageSize);
            }

            pageIndex = pageIndex * pageSize < totalCount ? pageIndex : (int)Math.Ceiling(totalCount / (decimal)pageSize) - 1;
            return new PagedList<T>(
                list.Skip(pageIndex * pageSize).Take(pageSize),
                totalCount,
                pageIndex,
                pageSize);
        }
    }
}
