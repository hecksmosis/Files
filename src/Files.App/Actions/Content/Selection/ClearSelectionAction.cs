﻿// Copyright (c) 2023 Files Community
// Licensed under the MIT License. See the LICENSE.

using Files.App.Commands;
using Files.App.Contexts;

namespace Files.App.Actions
{
	internal class ClearSelectionAction : IAction
	{
		private readonly IContentPageContext context = Ioc.Default.GetRequiredService<IContentPageContext>();

		public string Label { get; } = "ClearSelection".GetLocalizedResource();

		public string Description => "ClearSelectionDescription".GetLocalizedResource();

		public RichGlyph Glyph { get; } = new("\uE8E6");

		public bool IsExecutable
		{
			get
			{
				if (context.PageType is ContentPageTypes.Home)
					return false;

				if (!context.HasSelection)
					return false;

				var page = context.ShellPage;
				if (page is null)
					return false;

				bool isEditing = page.ToolbarViewModel.IsEditModeEnabled;
				bool isRenaming = page.SlimContentPage.IsRenamingItem;

				return !isEditing && !isRenaming;
			}
		}

		public Task ExecuteAsync()
		{
			context.ShellPage?.SlimContentPage?.ItemManipulationModel?.ClearSelection();
			return Task.CompletedTask;
		}
	}
}
