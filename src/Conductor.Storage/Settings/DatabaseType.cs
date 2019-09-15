using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductor.Storage.Settings
{
    public enum DatabaseType
    {
        /// <summary>
        /// MsSql Database type
        /// </summary>
        MsSql = 0,

        /// <summary>
        /// MySQL Database type
        /// </summary>
        MySql = 1,

        /// <summary>
        /// Postgres Database type
        /// </summary>
        Postgres = 2,

        /// <summary>
        /// Mongodb database type
        /// </summary>
        MongoDb = 3
    }
}
