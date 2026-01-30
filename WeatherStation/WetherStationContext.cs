
namespace WetherStation
{
    internal class WetherStationContext : IDisposable
    {
        public object Database { get; internal set; }
    }
}