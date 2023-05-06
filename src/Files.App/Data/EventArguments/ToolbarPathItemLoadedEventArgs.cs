﻿// Copyright (c) 2023 Files Community
// Licensed under the MIT License. See the LICENSE.

using Files.App.Views;
using Microsoft.UI.Xaml.Controls;

namespace Files.App.Data.EventArguments
{
	public class ToolbarPathItemLoadedEventArgs
	{
		public MenuFlyout OpenedFlyout { get; set; }

		public PathBoxItem Item { get; set; }
	}
}
