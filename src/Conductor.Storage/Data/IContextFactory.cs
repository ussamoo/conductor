using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductor.Storage.Data
{
    /// <summary>
    /// Context factory interface
    /// </summary>
    public interface IContextFactory
    {
        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        IDbContext DbContext { get; }
    }
}
