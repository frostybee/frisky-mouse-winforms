using FriskyMouse.Helpers;
using Octokit;
using System.Diagnostics;

namespace FriskyMouse.Core;

public class GitHubUpdateChecker
{
    public bool IsUpdateAvailable { get; private set; } = false;
    public string? NewVersionInfo { get; private set; } = "Up to date!";

    public async Task CheckGitHubNewerVersion()
    {
        string owner = "friskymouse";
        string repository = "frisky-mouse";
        GitHubClient client = new GitHubClient(new ProductHeaderValue(repository));
        Release latestRelease = await client.Repository.Release.GetLatest(owner, repository);
        Debug.WriteLine("Checking for updates.....");
        if (latestRelease != null)
        {
            try
            {
                Debug.WriteLine("Inside Checking for updates.....");
                Version latestGitHubVersion = new Version(ParseRemoteVersion(latestRelease.TagName));
                Version localVersion = FMAppHelper.GetCurrentAppVersion();
                //Compare the current version with the latest published on GitHub.
                Debug.WriteLine("localVersion: "+ localVersion);
                Debug.WriteLine("latestGitHubVersion: " + latestGitHubVersion);
                if (localVersion.CompareTo(latestGitHubVersion) < 0)
                {
                    Debug.WriteLine("The version on GitHub is more up to date than this local release.");
                    IsUpdateAvailable = true;
                    NewVersionInfo = latestGitHubVersion.ToString();
                }
            }
            catch (Exception)
            {
            }
        }
    }

    private string ParseRemoteVersion(string tagName)
    {
        string remoteVersion = "";
        if (tagName.StartsWith('v') || tagName.StartsWith('V'))
        {
            remoteVersion = tagName.Replace('v', ' ').Trim();
        }
        return remoteVersion;
    }
}
