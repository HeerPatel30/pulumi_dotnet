using System;
using System.Collections.Generic;
using Pulumi;
using Pulumi.AzureNative.Storage;
using Pulumi.AzureNative.Storage.Inputs;
public class StorageComponent : Pulumi.ComponentResource
{

    public Output<string> StorageAccountName { get; set; }
    public Output<string> StorageAccountId { get; set;}
    public StorageComponent(string name , StorageComponentArgs args, ComponentResourceOptions? options = null)
        : base("custom:resource:StorageComponent", name, options)
    {
        var storageAccount = new StorageAccount(name, new StorageAccountArgs
        {
            ResourceGroupName = args.ResourceGroupName,
            Location = args.Location,
            Sku = new SkuArgs
            {
                Name = args.SkuName
            },
            Kind = args.Kind
        }, new CustomResourceOptions { Parent = this });

        this.StorageAccountName = storageAccount.Name;
        this.StorageAccountId = storageAccount.Id;

        this.RegisterOutputs(new Dictionary<string, object?>
        {
            { "storageAccountName", this.StorageAccountName },
            { "storageAccountId", this.StorageAccountId }
        });
    }


}