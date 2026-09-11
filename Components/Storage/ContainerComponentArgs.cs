using Pulumi;
using Pulumi.AzureNative.Storage;

public class ContainerComponentArgs
{
    public Input<string> ResourceGroupName { get; set; } = null!;

    public Input<string> StorageAccountName { get; set; } = null!;

    public Input<string> ContainerName { get; set; } = null!;

    public Input<PublicAccess> PublicAccess { get; set; } = null!;
}