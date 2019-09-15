using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conductor.Storage.Settings
{
    /// <summary>
    /// All hard-coded strings can be read as properties in the application
    /// </summary>
    public static class DefaultConstants
    {
        /// <summary>
        /// Name of the settings file name
        /// </summary>
        public const string AppSettingsFileName = "appsettings.json";

        /// <summary>
        /// Name of the connection string
        /// </summary>
        public const string DefaultConnection = nameof(DefaultConstants.DefaultConnection);

        /// <summary>
        /// Connection string section
        /// </summary>
        public const string ConnectionStrings = nameof(DefaultConstants.ConnectionStrings);

    }
}
