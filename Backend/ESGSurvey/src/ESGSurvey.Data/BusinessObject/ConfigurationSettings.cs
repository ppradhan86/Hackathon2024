﻿using Microsoft.Extensions.Configuration;

namespace ESGSurvey.Data.BusinessObject
{
    public class ConfigurationSettings : IConfigurationSettings
    {
        #region Global Variable(s)
        private readonly IConfiguration _configuration;
        #endregion

        public ConfigurationSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        #region Public Prop(s)
        public string AzureAIServiceName => _configuration["AzureAISearch:AzureAIServiceName"];

        public string AzureAIServiceIndexName => _configuration["AzureAISearch:AzureAIServiceIndexName"];

        public string AzureAIServiceApiKey => _configuration["AzureAISearch:AzureAIServiceApiKey"];

        public string AzureAIServiceUrl => _configuration["AzureAISearch:AzureAIServiceUrl"];

        public string AzureAISearchIndexerName => _configuration["AzureAISearch:AzureAISearchIndexerName"];


        public string StorageConnectionString => _configuration["AzureStorage:StorageConnectionString"];

        public string StorageBlobContainerName => _configuration["AzureStorage:StorageBlobContainerName"];

        public string OpenAIApiBase => _configuration["OpenAI:OpenAIApiBase"];

        public string OpenAIKey => _configuration["OpenAI:OpenAIKey"];

        public string OpenAIDeploymentId => _configuration["OpenAI:OpenAIDeploymentId"];

        #endregion

    }
}
