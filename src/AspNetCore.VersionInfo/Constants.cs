﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetCore.VersionInfo
{
    public static class Constants
    {
        internal const string DEFAULT_API_RESPONSE_CONTENT_TYPE = "application/json";

        //public const string DEFAULT_HTML_ENDPOINT_URL = "/version/html/{id?}";
        public const string DEFAULT_HTML_ENDPOINT_URL = "/version/html";
        public const string DEFAULT_API_ENDPOINT_URL = "/version/json";

        public const string KEY_ENTRY_ASSEMBLY_VERSION = "EntryAssemblyVersion";
        public const string KEY_RUNTIME_VERSION = "RuntimeVersion";
        public const string KEY_DOTNET_VERSION = "DotNetVersion";

    }
}
