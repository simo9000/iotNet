
using Nancy;
using Nancy.Conventions;

namespace ACN
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        // The bootstrapper enables you to reconfigure the composition of the framework,
        // by overriding the various methods and properties.
        // For more information https://github.com/NancyFx/Nancy/wiki/Bootstrapper

        public Bootstrapper()
        {
            StaticConfiguration.DisableErrorTraces = false;
            this.Conventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts"));
        }
    }
}