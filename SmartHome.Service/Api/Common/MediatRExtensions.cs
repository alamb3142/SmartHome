using MediatR;
using Microsoft.AspNetCore.Mvc;


namespace Api.Common;

internal static class MediatRExtensions
{
    internal static RouteGroupBuilder MediateGet<TRequest, TResult>(this RouteGroupBuilder app, string template) where TRequest : IRequest<TResult>
    {
        app.MapGet(template, async (IMediator mediator, [AsParameters] TRequest request) => await mediator.Send(request));
        return app;
    }

    internal static RouteGroupBuilder MediatePost<TRequest, TResult>(this RouteGroupBuilder app, string template) where TRequest : IRequest<TResult>
    {
        app.MapPost(template, async (IMediator mediator, [FromBody] TRequest request) => await mediator.Send(request));
        return app;
    }
}
