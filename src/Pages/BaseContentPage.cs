﻿using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace HelloMauiMarkup;

abstract class BaseContentPage : ContentPage
{
    protected BaseContentPage(in bool shouldUseSafeArea = false)
    {
        On<iOS>().SetUseSafeArea(shouldUseSafeArea);
        On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);
    }
}

abstract class BaseContentPage<T> : BaseContentPage where T : BaseViewModel
{
    protected BaseContentPage(in T viewModel, in bool shouldUseSafeArea = false) : base(shouldUseSafeArea)
    {
        BindingContext = ViewModel = viewModel;
    }

    protected T ViewModel { get; }
}