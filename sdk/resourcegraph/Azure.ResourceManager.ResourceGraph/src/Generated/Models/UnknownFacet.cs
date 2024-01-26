// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary> The UnknownFacet. </summary>
    internal partial class UnknownFacet : Facet
    {
        /// <summary> Initializes a new instance of <see cref="UnknownFacet"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownFacet(string expression, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(expression, resultType, serializedAdditionalRawData)
        {
            ResultType = resultType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownFacet"/> for deserialization. </summary>
        internal UnknownFacet()
        {
        }
    }
}
