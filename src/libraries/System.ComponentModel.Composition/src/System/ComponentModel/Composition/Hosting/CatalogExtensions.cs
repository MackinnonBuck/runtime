// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel.Composition.Primitives;
using Microsoft.Internal;

namespace System.ComponentModel.Composition.Hosting
{
    public static class CatalogExtensions
    {
        /// <summary>
        /// Creates a <see cref="CompositionService"/>.
        /// </summary>
        /// <param name="composablePartCatalog">The catalog.</param>
        /// <returns>The newly created <see cref="CompositionService"/>.</returns>
        public static CompositionService CreateCompositionService(this ComposablePartCatalog composablePartCatalog)
        {
            Requires.NotNull(composablePartCatalog, nameof(composablePartCatalog));

            return new CompositionService(composablePartCatalog);
        }
    }
}
