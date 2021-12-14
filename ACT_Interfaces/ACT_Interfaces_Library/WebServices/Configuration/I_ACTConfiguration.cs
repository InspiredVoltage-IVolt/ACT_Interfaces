namespace ACT.Core.Interfaces.WebServices.Configuration
{

    public class ACTConfigTemplate
    {

        public string Description { get; set; }


        public string Member_ID { get; set; }


        public string Tags { get; set; }


        public bool IsPublic { get; set; }


        public bool IsDefault { get; set; }


        public string ID { get; set; }


        public string Name { get; set; }


        public string[] RowIds { get; set; }
    }


    public class ACTConfigTemplateData
    {

        public string ID { get; set; }


        public string Template_ID { get; set; }


        public string Name { get; set; }


        public string DefaultValue { get; set; }


        public bool Encrypted { get; set; }


        public string Description { get; set; }


        public string Tags { get; set; }
    }

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IACTConfig" in both code and config file together.

    public interface I_ACTConfiguration
    {

        List<ACTConfigTemplate> GetAllConfigurationTemplates(string Token, string APIKey);


        List<ACTConfigTemplateData> GetTemplateDetails(string Token, string APIKey, string ConfigurationTemplateID);


        string SaveConfigurationTemplates(string Token, string APIKey, ACTConfigTemplate tmplate);


        string SaveTemplateDetails(string Token, string APIKey, ACTConfigTemplateData tmplatedata);


        string SaveAllTemplateDetails(string Token, string APIKey, List<ACTConfigTemplateData> tmplatedata);


        ACTConfigTemplate GetSystemDefaultTemplate(string Token, string APIKey);

    }
}
