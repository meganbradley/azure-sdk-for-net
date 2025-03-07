// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using NUnit.Framework;

namespace Azure.ResourceManager.Redis.Samples
{
    public partial class Sample_RedisCacheAccessPolicyCollection
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task CreateOrUpdate_RedisCacheAccessPolicyCreateUpdate()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyCreateUpdate.json
            // this example is just showing the usage of "AccessPolicy_CreateUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyResource
            RedisCacheAccessPolicyCollection collection = redis.GetRedisCacheAccessPolicies();

            // invoke the operation
            string accessPolicyName = "accessPolicy1";
            RedisCacheAccessPolicyData data = new RedisCacheAccessPolicyData
            {
                Permissions = "+get +hget",
            };
            ArmOperation<RedisCacheAccessPolicyResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, accessPolicyName, data);
            RedisCacheAccessPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisCacheAccessPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_RedisCacheAccessPolicyGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyGet.json
            // this example is just showing the usage of "AccessPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyResource
            RedisCacheAccessPolicyCollection collection = redis.GetRedisCacheAccessPolicies();

            // invoke the operation
            string accessPolicyName = "accessPolicy1";
            RedisCacheAccessPolicyResource result = await collection.GetAsync(accessPolicyName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            RedisCacheAccessPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetAll_RedisCacheAccessPolicyList()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyList.json
            // this example is just showing the usage of "AccessPolicy_List" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyResource
            RedisCacheAccessPolicyCollection collection = redis.GetRedisCacheAccessPolicies();

            // invoke the operation and iterate over the result
            await foreach (RedisCacheAccessPolicyResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisCacheAccessPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Exists_RedisCacheAccessPolicyGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyGet.json
            // this example is just showing the usage of "AccessPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyResource
            RedisCacheAccessPolicyCollection collection = redis.GetRedisCacheAccessPolicies();

            // invoke the operation
            string accessPolicyName = "accessPolicy1";
            bool result = await collection.ExistsAsync(accessPolicyName);

            Console.WriteLine($"Succeeded: {result}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task GetIfExists_RedisCacheAccessPolicyGet()
        {
            // Generated from example definition: specification/redis/resource-manager/Microsoft.Cache/stable/2024-11-01/examples/RedisCacheAccessPolicyGet.json
            // this example is just showing the usage of "AccessPolicy_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this RedisResource created on azure
            // for more information of creating RedisResource, please refer to the document of RedisResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string cacheName = "cache1";
            ResourceIdentifier redisResourceId = RedisResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, cacheName);
            RedisResource redis = client.GetRedisResource(redisResourceId);

            // get the collection of this RedisCacheAccessPolicyResource
            RedisCacheAccessPolicyCollection collection = redis.GetRedisCacheAccessPolicies();

            // invoke the operation
            string accessPolicyName = "accessPolicy1";
            NullableResponse<RedisCacheAccessPolicyResource> response = await collection.GetIfExistsAsync(accessPolicyName);
            RedisCacheAccessPolicyResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine("Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                RedisCacheAccessPolicyData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }
    }
}
