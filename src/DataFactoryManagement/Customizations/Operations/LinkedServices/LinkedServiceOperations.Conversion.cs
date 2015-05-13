﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using Microsoft.Azure.Management.DataFactories.Conversion;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories
{
    /// <summary>
    /// Operations for managing data factory linkedServices.
    /// </summary>
    public partial class LinkedServiceOperations 
#if ADF_INTERNAL
        : ITypeRegistrationOperations<LinkedService, LinkedServiceTypeProperties>
#endif
    {
        internal LinkedServiceConverter Converter { get; set; }

#if ADF_INTERNAL
        public void RegisterType<T>() where T : LinkedServiceTypeProperties
        {
            this.Converter.RegisterType<T>();
        }

        public bool TypeIsRegistered<T>() where T : LinkedServiceTypeProperties
        {
            return this.Converter.TypeIsRegistered<T>();
        }
#endif

        public void ValidateObject(LinkedService linkedService)
        {
            this.Converter.ValidateWrappedObject(linkedService);
        }
    }
}