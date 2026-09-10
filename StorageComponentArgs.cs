using Pulumi;
using Pulumi.AzureNative.Storage;

public class StorageComponentArgs
{
    public Input<string> ResourceGroupName { get; set; } = null!;

    public Input<string> Location { get; set; } = null!;

    public Input<SkuName> SkuName { get; set; } = null!;

    public Input<Kind> Kind { get; set; } = null!;
}