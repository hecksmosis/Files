using Files.App.ViewModels.Dialogs;
using Files.Shared.Enums;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Threading.Tasks;

// The Content Dialog item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Files.App.Dialogs
{
	public sealed partial class DynamicDialog : ContentDialog, IDisposable
	{
		public DynamicDialogViewModel? ViewModel
		{
			get => (DynamicDialogViewModel)DataContext;
			private set => DataContext = value;
		}

		public DynamicDialogResult? DynamicResult
		{
			get => ViewModel is not null ? ViewModel.DynamicResult : null;
		}

		public new Task<ContentDialogResult> ShowAsync() => SetContentDialogRoot(this).ShowAsync().AsTask();

		// WINUI3
		private static ContentDialog SetContentDialogRoot(ContentDialog contentDialog)
		{
			if (Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 8))
			{
				contentDialog.XamlRoot = App.Window.Content.XamlRoot;
			}
			return contentDialog;
		}

		public DynamicDialog(DynamicDialogViewModel dynamicDialogViewModel)
		{
			this.InitializeComponent();

			dynamicDialogViewModel.HideDialog = this.Hide;
			this.ViewModel = dynamicDialogViewModel;
		}

		public void Dispose()
		{
			ViewModel?.Dispose();
			ViewModel = null;
		}

		private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
		{
			if (ViewModel is not null)
				ViewModel.PrimaryButtonCommand.Execute(args);
		}

		private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
		{
            if (ViewModel is not null) 
				ViewModel.SecondaryButtonCommand.Execute(args);
		}

		private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
		{
            if (ViewModel is not null) 
				ViewModel.CloseButtonCommand.Execute(args);
		}

		private void ContentDialog_KeyDown(object sender, Microsoft.UI.Xaml.Input.KeyRoutedEventArgs e)
		{
            if (ViewModel is not null) 
				ViewModel.KeyDownCommand.Execute(e);
		}
	}
}