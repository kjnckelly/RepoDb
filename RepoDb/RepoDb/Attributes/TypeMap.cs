﻿using System;
using System.Data;

namespace RepoDb.Attributes
{
    /// <summary>
    /// An attribute used to define a mapping of <i>DataEntity</i> property type into its equivalent database type.
    /// </summary>
    public class TypeMapAttribute : Attribute
    {
        /// <summary>
        /// Creates a new instance of <i>RepoDb.Attributes.TypeMapAttribute</i> object.
        /// </summary>
        /// <param name="dbType">A target database type.</param>
        public TypeMapAttribute(DbType dbType)
        {
            DbType = dbType;
        }

        /// <summary>
        /// Gets a database type that is currently mapped.
        /// </summary>
        public DbType DbType { get; }
    }
}