﻿using Files.Shared.Enums;
using System.Collections.Generic;
using System.ComponentModel;

namespace Files.Backend.Services.Settings
{
	public interface IPreferencesSettingsService : IBaseSettingsService, INotifyPropertyChanged
	{
		/// <summary>
		/// Gets or sets a value indicating whether or not to show the delete confirmation dialog when deleting items.
		/// </summary>
		bool ShowConfirmDeleteDialog { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not media thumbnails should be visible.
		/// </summary>
		bool ShowThumbnails { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to select files and folders when hovering them.
		/// </summary>
		bool SelectFilesOnHover { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not file extensions should be visible.
		/// </summary>
		bool ShowFileExtensions { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to search unindexed items.
		/// </summary>
		bool SearchUnindexedItems { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to navigate to a specific location when launching the app.
		/// </summary>
		bool OpenSpecificPageOnStartup { get; set; }

		/// <summary>
		/// Gets or sets a value indicating the default startup location.
		/// </summary>
		string OpenSpecificPageOnStartupPath { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not continue the last session whenever the app is launched.
		/// </summary>
		bool ContinueLastSessionOnStartUp { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to open a page when the app is launched.
		/// </summary>
		bool OpenNewTabOnStartup { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not opening the app from the jumplist should open the directory in a new instance.
		/// </summary>
		bool AlwaysOpenNewInstance { get; set; }

		/// <summary>
		/// A list containing all paths to open at startup.
		/// </summary>
		List<string> TabsOnStartupList { get; set; }

		/// <summary>
		/// A list containing all paths to tabs closed on last session.
		/// </summary>
		List<string> LastSessionTabList { get; set; }

		/// <summary>
		/// Gets or sets a value indicating which date and time format to use.
		/// </summary>
		DateTimeFormats DateTimeFormat { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to enable dual pane feature.
		/// </summary>
		bool IsDualPaneEnabled { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to always open a second pane when opening a new tab.
		/// </summary>
		bool AlwaysOpenDualPaneInNewTab { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to display the folders widget.
		/// </summary>
		bool ShowFoldersWidget { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to display the recent files widget.
		/// </summary>
		bool ShowRecentFilesWidget { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to display the drives widget.
		/// </summary>
		bool ShowDrivesWidget { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to display the bundles widget.
		/// </summary>
		bool ShowBundlesWidget { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to expand the folders widget.
		/// </summary>
		bool FoldersWidgetExpanded { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to expand the recent files widget.
		/// </summary>
		bool RecentFilesWidgetExpanded { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to expand the drives widget.
		/// </summary>
		bool DrivesWidgetExpanded { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether or not to expand the bundles widget.
		/// </summary>
		bool BundlesWidgetExpanded { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the favorites section should be visible.
		/// </summary>
		bool ShowFavoritesSection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the library section should be visible.
		/// </summary>
		bool ShowLibrarySection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the drive section should be visible.
		/// </summary>
		bool ShowDrivesSection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the cloud drive section should be visible.
		/// </summary>
		bool ShowCloudDrivesSection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the network drive section should be visible.
		/// </summary>
		bool ShowNetworkDrivesSection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the wsl section should be visible.
		/// </summary>
		bool ShowWslSection { get; set; }

		/// <summary>
		/// Gets or sets a value indicating if the tags section should be visible.
		/// </summary>
		bool ShowFileTagsSection { get; set; }
	}
}
