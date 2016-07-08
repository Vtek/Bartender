﻿using System.Threading;
using System.Threading.Tasks;

namespace Cheers.Cqrs.Write
{
    /// <summary>
    /// Define a cancellable asynchronous command handler
    /// </summary>
    public interface ICancellableAsyncCommandHandler<TCommand>
        where TCommand : ICommand
    {
        /// <summary>
        /// Handle a command
        /// </summary>
        /// <param name="command">Command to handle</param>
        /// <param name="cancellationToken">Cancellation token</param>
        Task Handle(TCommand command, CancellationToken cancellationToken);
    }

    /// <summary>
    /// Define a cancellable asynchronous command handler
    /// </summary>
    public interface ICancellableAsyncCommandHandler<TCommand, TResult>
        where TCommand : ICommand
        where TResult : IResult
    {
        /// <summary>
        /// Handle a command
        /// </summary>
        /// <param name="command">Command to handle</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Command result</returns>
        Task<TResult> Handle(TCommand command, CancellationToken cancellationToken);
    }
}
