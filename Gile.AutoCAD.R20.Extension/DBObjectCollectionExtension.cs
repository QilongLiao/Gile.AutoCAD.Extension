﻿using GrxCAD.DatabaseServices;

using System.Linq;

namespace Gile.AutoCAD.R20.Extension
{
    /// <summary>
    /// Provides extension methods for the DBObjectCollection type.
    /// </summary>
    public static class DBObjectCollectionExtension
    {
        /// <summary>
        /// Disposes of all objects in the collections.
        /// </summary>
        /// <param name="source">Instance to which the method applies.</param>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name ="source"/> is null.</exception>
        public static void DisposeAll(this DBObjectCollection source)
        {
            Assert.IsNotNull(source, nameof(source));

            var list = source.Cast<DBObject>().ToList();
            source.Clear();
            list.DisposeAll();
        }
    }
}
