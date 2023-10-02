﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.Windows;

namespace iNKORE.UI.WPF.Modern.Controls
{
    public interface IElementFactory
    {
        UIElement GetElement(ElementFactoryGetArgs args);
        void RecycleElement(ElementFactoryRecycleArgs args);
    }
}