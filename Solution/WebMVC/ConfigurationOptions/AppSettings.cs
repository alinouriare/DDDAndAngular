﻿using Infrastructure.Configuration;
using Infrastructure.Interceptors;
using Infrastructure.Logging;
using WebMVC.ConfigurationOptions.MessageBroker;
using WebMVC.ConfigurationOptions.Storage;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace WebMVC.ConfigurationOptions
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }

        public CheckDependency CheckDependency { get; set; }

        public LoggingOptions Logging { get; set; }

        public OpenIdConnect OpenIdConnect { get; set; }

        public ResourceServer ResourceServer { get; set; }

        public NotificationServer NotificationServer { get; set; }

        public BackgroundServer BackgroundServer { get; set; }

        public string AllowedHosts { get; set; }

        public string CurrentUrl { get; set; }

        public ConfigurationSourcesOptions ConfigurationSources { get; set; }

        public StorageOptions Storage { get; set; }

        public MessageBrokerOptions MessageBroker { get; set; }

        public Dictionary<string, string> SecurityHeaders { get; set; }

        public InterceptorsOptions Interceptors { get; set; }

        public ValidateOptionsResult Validate()
        {
            var validationRs = OpenIdConnect.Validate();

            if (validationRs.Failed)
            {
                return validationRs;
            }

            validationRs = ResourceServer.Validate();

            if (validationRs.Failed)
            {
                return validationRs;
            }

            return ValidateOptionsResult.Success;

        }
    }

    public class AppSettingsValidation : IValidateOptions<AppSettings>
    {
        public ValidateOptionsResult Validate(string name, AppSettings options)
        {
            return options.Validate();
        }
    }
}