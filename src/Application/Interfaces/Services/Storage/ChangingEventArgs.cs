﻿using System.Diagnostics.CodeAnalysis;

namespace Blazor.CMS.Editor.Application.Interfaces.Services.Storage
{
    [ExcludeFromCodeCoverage]
    public class ChangingEventArgs : ChangedEventArgs
    {
        public bool Cancel { get; set; }
    }
}