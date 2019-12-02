using System;
using System.Windows.Input;
using Uno.UI.Samples.Controls;
using Uno.UI.Samples.UITests.Helpers;
using Windows.Storage;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_System
{
	[SampleControlInfo("Windows.System", "Launcher",
		description: "Tests the Launcher. Some special URIs are supported on some platforms (Android, iOS - ms-settings:)",
		viewModelType: typeof(LauncherTestsViewModel))]
	public sealed partial class LauncherTests : UserControl
	{
		public LauncherTests()
		{
			this.InitializeComponent();
		}
	}

	public class LauncherTestsViewModel : ViewModelBase
	{
		private string _uri;
		private string _error;
		private string _filePath = "ms-appx:///Assets/test_image_1252_836.png";
		private LaunchQuerySupportStatus _supportResult;

		public LauncherTestsViewModel(CoreDispatcher dispatcher) : base(dispatcher)
		{
		}

		public string Uri
		{
			get => _uri;
			set
			{
				_uri = value;
				RaisePropertyChanged();
			}
		}

		public string FilePath
		{
			get => _filePath;
			set
			{
				_filePath = value;
				RaisePropertyChanged();
			}
		}

		public string Error
		{
			get => _error;
			set
			{
				_error = value;
				RaisePropertyChanged();
			}
		}

		public LaunchQuerySupportStatus SupportResult
		{
			get => _supportResult;
			set
			{
				_supportResult = value;
				RaisePropertyChanged();
			}
		}

		public ICommand QuerySupportCommand => GetOrCreateCommand(QuerySupport);

		public ICommand LaunchCommand => GetOrCreateCommand(Launch);

		public ICommand LaunchFileCommand => GetOrCreateCommand(LaunchFile);

		private async void Launch()
		{
			Error = "";
			try
			{
				if (System.Uri.TryCreate(Uri, UriKind.Absolute, out var parsedUri))
				{
					await Launcher.LaunchUriAsync(parsedUri);
				}
				else
				{
					Error = "Can't parse input as an absolute URI.";
				}
			}
			catch (Exception ex)
			{
				Error = ex.ToString();
			}
		}

		private async void LaunchFile()
		{
			Error = "";
			try
			{
				StorageFile file;
				if (FilePath.StartsWith("ms-appx:", StringComparison.InvariantCultureIgnoreCase) &&
					System.Uri.TryCreate(FilePath, UriKind.Absolute, out var parsedUri))
				{
					file = await StorageFile.GetFileFromApplicationUriAsync(parsedUri);
				}
				else
				{
					file = await StorageFile.GetFileFromPathAsync(FilePath);
				}
				await Launcher.LaunchFileAsync(file);
			}
			catch (Exception ex)
			{
				Error = ex.ToString();
			}
		}

		private async void QuerySupport()
		{
			Error = "";
			try
			{
				if (System.Uri.TryCreate(Uri, UriKind.Absolute, out var parsedUri))
				{
					SupportResult = await Launcher.QueryUriSupportAsync(parsedUri, LaunchQuerySupportType.Uri);
				}
				else
				{
					Error = "Can't parse input as an absolute URI.";
				}
			}
			catch (Exception ex)
			{
				Error = ex.ToString();
			}
		}
	}
}
