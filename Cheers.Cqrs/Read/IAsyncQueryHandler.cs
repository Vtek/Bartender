﻿using System.Threading.Tasks;
using System.Collections.Generic;

namespace Cheers.Cqrs.Read
{
    /// <summary>
    /// Define an asynchronous query handler
    /// </summary>
    /// <typeparam name="TQuery">Query type</typeparam>
    /// <typeparam name="TReadModel">ReadModel type</typeparam>
    public interface IAsyncQueryHandler<TQuery, TReadModel> 
        where TQuery : IQuery
        where TReadModel : IReadModel
    {
        /// <summary>
        /// Handle a query asynchronously
        /// </summary>
        /// <param name="query">Query to handle</param>
        /// <returns>Enumerable of ReadModel</returns>
        Task<IEnumerable<TReadModel>> Handle(TQuery query);
    }
}

