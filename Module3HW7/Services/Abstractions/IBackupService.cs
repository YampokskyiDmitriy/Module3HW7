using System.Threading.Tasks;

namespace Module3HW7.Services.Abstractions
{
    public interface IBackupService
    {
        public Task BackupAsync(string path);
    }
}
