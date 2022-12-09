﻿using CommunityToolkit.Mvvm.ComponentModel;
using Mediator;

namespace Retrobox.ViewModels;

[ObservableObject]
public partial class MainViewModel
{
    [ObservableProperty]
    private IMediator? mediator;

    public MainViewModel(IMediator mediator)
    {
        this.mediator = mediator;
    }
}