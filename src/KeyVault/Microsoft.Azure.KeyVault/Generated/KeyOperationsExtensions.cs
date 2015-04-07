// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.KeyVault.Internal;

namespace Microsoft.Azure.KeyVault.Internal
{
    internal static partial class KeyOperationsExtensions
    {
        /// <summary>
        /// Requests that a backup of the specified key be downloaded to the
        /// client.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Backup(this IKeyOperations operations, string keyIdentifier)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).BackupAsync(keyIdentifier);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Requests that a backup of the specified key be downloaded to the
        /// client.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> BackupAsync(this IKeyOperations operations, string keyIdentifier)
        {
            return operations.BackupAsync(keyIdentifier, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a new, named, key in the specified vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyName'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Create(this IKeyOperations operations, string vault, string keyName, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).CreateAsync(vault, keyName, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a new, named, key in the specified vault.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyName'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> CreateAsync(this IKeyOperations operations, string vault, string keyName, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.CreateAsync(vault, keyName, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Decrypts a single block of data.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent DecryptData(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).DecryptDataAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Decrypts a single block of data.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> DecryptDataAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.DecryptDataAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyName'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent DeleteKey(this IKeyOperations operations, string vault, string keyName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).DeleteKeyAsync(vault, keyName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyName'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> DeleteKeyAsync(this IKeyOperations operations, string vault, string keyName)
        {
            return operations.DeleteKeyAsync(vault, keyName, CancellationToken.None);
        }
        
        /// <summary>
        /// Encrypts a single block of data.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent EncryptData(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).EncryptDataAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Encrypts a single block of data.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> EncryptDataAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.EncryptDataAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieves the public portion of a key plus its attributes
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Get(this IKeyOperations operations, string keyIdentifier)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).GetAsync(keyIdentifier);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieves the public portion of a key plus its attributes
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> GetAsync(this IKeyOperations operations, string keyIdentifier)
        {
            return operations.GetAsync(keyIdentifier, CancellationToken.None);
        }
        
        /// <summary>
        /// Imports a key into the specified vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Import(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).ImportAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Imports a key into the specified vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> ImportAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.ImportAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// List the keys in the vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='top'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent List(this IKeyOperations operations, string vault, int? top)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).ListAsync(vault, top);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the keys in the vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='top'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> ListAsync(this IKeyOperations operations, string vault, int? top)
        {
            return operations.ListAsync(vault, top, CancellationToken.None);
        }
        
        /// <summary>
        /// List the next page of keys in the vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent ListNext(this IKeyOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the next page of keys in the vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> ListNextAsync(this IKeyOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// List the versions of a key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyName'>
        /// Required.
        /// </param>
        /// <param name='top'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent ListVersions(this IKeyOperations operations, string vault, string keyName, int? top)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).ListVersionsAsync(vault, keyName, top);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the versions of a key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyName'>
        /// Required.
        /// </param>
        /// <param name='top'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> ListVersionsAsync(this IKeyOperations operations, string vault, string keyName, int? top)
        {
            return operations.ListVersionsAsync(vault, keyName, top, CancellationToken.None);
        }
        
        /// <summary>
        /// List the next page of versions of a key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent ListVersionsNext(this IKeyOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).ListVersionsNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// List the next page of versions of a key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> ListVersionsNextAsync(this IKeyOperations operations, string nextLink)
        {
            return operations.ListVersionsNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Restores the backup key in to a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Restore(this IKeyOperations operations, string vault, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).RestoreAsync(vault, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Restores the backup key in to a vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='vault'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> RestoreAsync(this IKeyOperations operations, string vault, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.RestoreAsync(vault, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Creates a signature from a digest using the specified key in the
        /// vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Sign(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).SignAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Creates a signature from a digest using the specified key in the
        /// vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> SignAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.SignAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Unwraps a symmetric key using the specified key in the vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent UnwrapKey(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).UnwrapKeyAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Unwraps a symmetric key using the specified key in the vault
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> UnwrapKeyAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.UnwrapKeyAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Updates the Key Attributes associated with the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Update(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).UpdateAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Updates the Key Attributes associated with the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> UpdateAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.UpdateAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Verifies a signature using the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent Verify(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).VerifyAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Verifies a signature using the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> VerifyAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.VerifyAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
        
        /// <summary>
        /// Wraps a symmetric key using the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static KeyOpResponseMessageWithRawJsonContent WrapKey(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IKeyOperations)s).WrapKeyAsync(keyIdentifier, keyOpRequest);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Wraps a symmetric key using the specified key
        /// </summary>
        /// <param name='operations'>
        /// Reference to the Microsoft.Azure.KeyVault.Internal.IKeyOperations.
        /// </param>
        /// <param name='keyIdentifier'>
        /// Required.
        /// </param>
        /// <param name='keyOpRequest'>
        /// Required.
        /// </param>
        /// <returns>
        /// Represents the response to a key operation request.
        /// </returns>
        public static Task<KeyOpResponseMessageWithRawJsonContent> WrapKeyAsync(this IKeyOperations operations, string keyIdentifier, KeyOpRequestMessageWithRawJsonContent keyOpRequest)
        {
            return operations.WrapKeyAsync(keyIdentifier, keyOpRequest, CancellationToken.None);
        }
    }
}
