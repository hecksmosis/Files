

namespace Files.App.Filesystem
{
	public class GitRepositoriesManager
	{

		private List<INavigationControlItem> gitRepositories = new();
		public IReadOnlyList<INavigationControlItem> GitRepositories
		{
			get
			{
				lock (gitRepositories)
				{
					return gitRepositories.ToList().AsReadOnly();
				}
			}
		}

		public List<string> CheckedRepositoryFolders { get; set; } = new();

		public GitRepositoriesManager()
		{
			CheckedRepositoryFolders.Add("C:\\OpenSource");
			GetGitRepositories();
		}

		public async void GetGitRepositories()
		{
			foreach (var gitRepository in CheckedRepositoryFolders) 
			{
				var repositoryList = SearchGitFolders(gitRepository).Select((folder) => SystemIO.Directory.GetParent(folder)?.FullName);
				var repositoriesToAdd = new List<INavigationControlItem>();
				foreach (var repository in repositoryList)
					repositoriesToAdd.Add(await App.QuickAccessManager.Model.CreateLocationItemFromPathAsync(repository));
				gitRepositories = gitRepositories.Concat(repositoriesToAdd).ToList();
			}
		}

		public List<string> SearchGitFolders(string folderPath)
		{
			var gitFolders = new List<string>();
			SearchRecursively(folderPath, gitFolders);
			return gitFolders;
		}

		private void SearchRecursively(string currentFolderPath, List<string> gitFolders)
		{
			try
			{
				string[] subfolderPaths = SystemIO.Directory.GetDirectories(currentFolderPath);

				foreach (string subfolderPath in subfolderPaths)
				{
					if (SystemIO.Path.GetFileName(subfolderPath).Equals("node_modules", StringComparison.OrdinalIgnoreCase))
						continue;

					if (SystemIO.Path.GetFileName(subfolderPath).Equals(".git", StringComparison.OrdinalIgnoreCase))
						gitFolders.Add(subfolderPath);

					SearchRecursively(subfolderPath, gitFolders);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}

	}
}
