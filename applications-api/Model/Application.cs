using System;

namespace Applications.Model
{
    public class Application
    {
        public Guid ApplicationId { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUpdated { get; set; }
        public string Form { get; set; }
    }
}