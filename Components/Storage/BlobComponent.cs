
using Pulumi;
using Pulumi.AzureNative.Storage;
public class BlobComponent : ComponentResource
{
    public Blob Blob { get; }
    public BlobComponent(string name, BlobComponentArgs args, ComponentResourceOptions? options = null)
        : base("custom:resource:BlobComponent", name, options)
    {
        Blob = new Blob(name, new BlobArgs
        {
            ResourceGroupName = args.ResourceGroupName,
            AccountName = args.StorageAccountName,
            ContainerName = args.ContainerName,
            BlobName = args.BlobName,
            Source = args.Source
        }, new CustomResourceOptions
        {
            Parent = this
        });
    }
}