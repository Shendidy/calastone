using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using TextFilter.Services;

using TFS = TextFilter.Services;

namespace TextFilter
{
    public class Application : IApplication
    {
        private readonly ILogger<Application> _log;
        private readonly IConfiguration _config;
        private readonly ITextFilter _textFilter;

        public Application(ILogger<Application> log, IConfiguration config, ITextFilter textFilter)
        {
            _log=log;
            _config=config;
            _textFilter=textFilter;
        }

        public void Run()
        {
            var path = _config.GetValue<string>("InputFilePath");

            var text = File.ReadAllText(path);

            _log.LogInformation(_textFilter.GetFilteredText(text));
        }
    }
}