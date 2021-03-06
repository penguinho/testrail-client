﻿using Newtonsoft.Json.Linq;

namespace TestRail.Types
{
    /// <summary>stores information about an option for a case field's configuration</summary>
    public class ConfigOption
    {
        #region Public Properties
        /// <summary>is this option required</summary>
        public bool? IsRequired { get; private set; }

        /// <summary>Default value for the option</summary>
        public string DefaultValue { get; private set; }

        /// <summary>format of the option</summary>
        public string Format { get; private set; }

        /// <summary>row</summary>
        public string Rows { get; private set; }
        #endregion Public Properties

        #region Public Methods
        /// <summary>parse a json object into a Config Option</summary>
        /// <param name="json">converts the json object to a ConfigOption</param>
        public static ConfigOption Parse(JObject json)
        {
            ConfigOption co = new ConfigOption();
            co.IsRequired = (bool?)json["is_required"];
            co.DefaultValue = (string)json["default_value"];
            co.Format = (string)json["format"];
            co.Rows = (string)json["rows"];
            return co;
        }
        #endregion
    }
}
