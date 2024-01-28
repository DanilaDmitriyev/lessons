using Microsoft.VisualBasic;

namespace HelloConfig
{
    public class Settings
    {
        public IConfiguration config { get; set; }
        public Settings(string rootPath)
        {
            var configurationBinder = new ConfigurationBuilder();
            configurationBinder.SetBasePath(rootPath);
            configurationBinder.AddJsonFile("appsettings.json");
            config = configurationBinder.Build();
           
        } 
            
        
    }
}
