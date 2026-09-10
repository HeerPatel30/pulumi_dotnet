using Pulumi;
using Pulumi.AzureNative.Resources;

// using Pulumi.AzureNative.Storage;
// using Pulumi.AzureNative.Storage.Inputs;
using System.Collections.Generic;
using Pulumi.AzureNative.Network;
using Pulumi.AzureNative.Network.Inputs;
using System;
using Pulumi.AzureNative.Storage;
// using Pulumi.AzureNative.KeyVault;
// using Pulumi.AzureNative.KeyVault.Inputs;
return await Pulumi.Deployment.RunAsync(static () =>
{
    var root = Pulumi.Deployment.Instance.RootDirectory;
    var organization = Pulumi.Deployment.Instance.OrganizationName;
    var tag = new Dictionary<string, string>
    {
        { "Organization", organization },
        {"name", "Heer"},
        { "environment", "dev"}
    };


    var config = new Config();

    // var name = config.Require("");\
    // var envr= config.Require("env");
    
    // create a resource group 
    // var resourcegrp = new ResourceGroup("Heer", new ResourceGroupArgs
    // {
    //     Location = "EastUS"
    // }
    // ,new CustomResourceOptions{
    //     Aliases = 
    //     {
    //         new Alias
    //         {
    //             Name = "Heer"
    //         } 
    //     } ,
    //     // Protect = true
    // }
    // );

    // using the components 
    // for (int i=0 ; i <= 5 ; i++)
    // {

 var storage = new StorageComponent(
       "testheer",
        new StorageComponentArgs
        {
            ResourceGroupName = "Heer",
            Location = "EastUS",
            SkuName = SkuName.Standard_LRS,
            Kind = Kind.StorageV2
        });
    // }
    // }

//    create  storage account 
        // var storageAccount = new StorageAccount("heer", new StorageAccountArgs
        // {   
        //     ResourceGroupName = "Heer",
        //     Location = "EastUS",
        //     Sku = new SkuArgs
        //     {
        //         Name = SkuName.Standard_LRS
        //     },
        //     Kind = Kind.StorageV2,
        //     Tags = tag
        // });
        
//  create a vault 
    // var vault = new Vault("vault", new VaultArgs
    // {
    //     VaultName = "heer1r",   
    //     ResourceGroupName = "Heer",
    //     Location = "EastUS",
    //     Properties = new VaultPropertiesArgs
    //     {
    //         TenantId = "f1053403-fe10-47d9-9c0e-bea5d7d3e577",
    //         EnableRbacAuthorization = true,
    //         Sku = new SkuArgs
    //         {
    //             Family = "A",
    //             Name = SkuName.Standard
    //         }
    //     }
    // });

    // var secret = new Secret("secret", new SecretArgs
    // {
    //     ResourceGroupName = "Heer",
    //     VaultName = vault.Name,
    //     SecretName = "heerpass",
    //     Properties = new SecretPropertiesArgs
    //     {
    //         Value = pass 
    //     },
        
    // });

//  create a vm

    // var vnet = new VirtualNetwork("heer-vnet", new Pulumi.AzureNative.Network.VirtualNetworkArgs
    // {
    //     Location = "EastUS",
    //     ResourceGroupName = "Heer",
    //     AddressSpace = new AddressSpaceArgs
    //     {
    //         AddressPrefixes = { "10.0.0.0/16" }
    //     }
    // });

    // var subnet = new Subnet ("heer-subnet", new Pulumi.AzureNative.Network.SubnetArgs
    // {
    //     ResourceGroupName = "Heer",
    //     VirtualNetworkName = vnet.Name,
    //     AddressPrefix =  "10.0.1.0/24"
    // });

    // var publicIp = new PublicIPAddress("heer-public-ip", new Pulumi.AzureNative.Network.PublicIPAddressArgs
    // {
    //     ResourceGroupName = "Heer",
    //     Location = "EastUS",
    //     PublicIPAllocationMethod = IPAllocationMethod.Dynamic,
    //     Sku = new Pulumi.AzureNative.Network.Inputs.PublicIPAddressSkuArgs
    //     {
    //         Name = PublicIPAddressSkuName.Basic
    //     }   
    // });

    // var nic = new NetworkInterface("heer-nic", new Pulumi.AzureNative.Network.NetworkInterfaceArgs
    // {
    //     ResourceGroupName = "Heer",
    //     Location = "EastUS",
    //     IpConfigurations =
    //     {
    //         new NetworkInterfaceIPConfigurationArgs
    //         {
    //             Name = "ipconfig1",
    //             Subnet = new Pulumi.AzureNative.Network.Inputs.SubnetArgs
    //             {
    //                 Id = subnet.Id
    //             },
    //             PrivateIPAllocationMethod = IPAllocationMethod.Dynamic,
    //             PublicIPAddress = new Pulumi.AzureNative.Network.Inputs.PublicIPAddressArgs
    //             {
    //                 Id = publicIp.Id
    //             }
    //         }
    //     }
    // });
    // var vm = new Pulumi.AzureNative.Compute.VirtualMachine("heer-vm", new Pulumi.AzureNative.Compute.VirtualMachineArgs
    // {
    //     ResourceGroupName = "Heer",
    //     Location = "EastUS", 
    //     HardwareProfile = new Pulumi.AzureNative.Compute.Inputs.HardwareProfileArgs
    //     {
    //         VmSize = Pulumi.AzureNative.Compute.VirtualMachineSizeTypes.Standard_B1s
    //     },
    //     OsProfile = new Pulumi.AzureNative.Compute.Inputs.OSProfileArgs
    //     {
    //         ComputerName = "heer-vm",
    //         AdminUsername = "adminuser",
    //         AdminPassword = pass,
    //     },
    //     NetworkProfile = new Pulumi.AzureNative.Compute.Inputs.NetworkProfileArgs
    //     {
    //         NetworkInterfaces =
    //         {
    //             new Pulumi.AzureNative.Compute.Inputs.NetworkInterfaceReferenceArgs
    //             {
    //                 Id = nic.Id,
    //                 Primary = true
    //             }
    //         }
    //     },
    //     StorageProfile = new Pulumi.AzureNative.Compute.Inputs.StorageProfileArgs
    //     {
    //         ImageReference = new Pulumi.AzureNative.Compute.Inputs.ImageReferenceArgs
    //         {
    //             Publisher= "MicrosoftWindowsServer",
    //             Offer= "WindowsServer",
    //             Sku= "2019-Datacenter",
    //             Version= "latest"
    //         },
    //     }


    // });
    // var envVarMapping = new Dictionary<string, string>
    // {
    //     { "organization", organization },
    //     { "root", root },
    //     { "env", envr }
    // };


    return new Dictionary<string, object?>
    {
        // ["secretName"] = secret.Name,
        ["organization"] = organization,
        ["root"] = root
        // ["envmapp"] = envVarMapping ,
        // ["vm"] = vm.Id
    };
});

