using DevOps.VersionControl.Structures.GitCommitUser;
using static DevOps.VersionControl.Functions.AddAndCommitGitChanges.GitChangeAdderAndCommitter;
using static Metaproject.Cdn.Containers.VersionControl.Helpers.VersionControlContentHelper;

namespace DevOps.VersionControl.Functions.AddAndCommitGnuGpl3License
{
    public static class GnuGpl3LicenseCommitter
    {
        private const string CommitMessage = "Add GNU GPL 3.0 LICENSE";

        public static void AddAndCommitLicense(string repositoryDirectory, UserInfo? user = null)
        {
            SaveGnuGpl3License(repositoryDirectory);
            AddAndCommitChanges(repositoryDirectory, CommitMessage, user);
        }
    }
}
