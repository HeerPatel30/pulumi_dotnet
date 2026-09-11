
using Pulumi;
using Pulumi.AzureNative.Storage;

public class ContainerComponent : ComponentResource
{ 
    public BlobContainer Container { get; }
    public ContainerComponent(string name, ContainerComponentArgs args, ComponentResourceOptions? options = null)
        : base("custom:resource:ContainerComponent", name, options)
    {
        Container = new BlobContainer(name, new BlobContainerArgs
        {
            ResourceGroupName = args.ResourceGroupName,
            AccountName = args.StorageAccountName,
            ContainerName = args.ContainerName,
            PublicAccess = PublicAccess.None
        }, new CustomResourceOptions
        {
            Parent = this
        });
    }
}