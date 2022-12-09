using Avalonia.Controls.Primitives;
using Mediator;
using Retrobox.Views;
using System.Threading.Tasks;
using System.Threading;
using Toolkit.Foundation.Avalonia;
using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Markup.Xaml.Templates;
using System.Net.NetworkInformation;
using System;
using FluentAvalonia.UI.Controls;

namespace Retrobox;


public abstract record NavigationTarget<T> : IRequest<bool> where T : TemplatedControl
{
    public T Route { get; }

    protected NavigationTarget(T route)
    {
        Route = route;
    }

    public object? Content { get; }

    public object? Template { get; }

    public IDictionary<string, object>? Parameters { get; init; }
}

public record ContentControlTarget : NavigationTarget<Frame>
{
    public ContentControlTarget(Frame route) : base(route)
    {

    }
}

public class ContentControlHandler : IRequestHandler<ContentControlTarget, bool>
{
    public ValueTask<bool> Handle(ContentControlTarget request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}