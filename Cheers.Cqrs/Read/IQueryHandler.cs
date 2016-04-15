﻿using System.Collections.Generic;

namespace Cheers.Cqrs.Read
{
    /// <summary>
    /// Define a query handler
    /// </summary>
    /// <typeparam name="TQuery">Query type</typeparam>
    /// <typeparam name="TReadModel">ReadModel type</typeparam>
    public interface IQueryHandler<in TQuery, out TReadModel> 
        where TQuery : IQuery
        where TReadModel : IReadModel
    {
        /// <summary>
        /// Handle a query
        /// </summary>
        /// <param name="query">Query to handle</param>
        /// <returns>Enumerable of ReadModel</returns>
        IEnumerable<TReadModel> Handle(TQuery query);
    }
}

