
using Pulumi;
public class BlobComponentArgs
{
    
    public Input<string> ResourceGroupName { get; set; } = null!;
    public Input<string> StorageAccountName { get; set; } = null!;
    public Input<string> ContainerName { get; set; } = null!;
    public Input<string> BlobName { get; set; } = null!;
    public AssetOrArchive Source { get; set; } = null!;
}