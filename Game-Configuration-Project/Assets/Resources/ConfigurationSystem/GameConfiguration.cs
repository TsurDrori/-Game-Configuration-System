using UnityEngine;

namespace Game.Configuration
{
  public sealed class GameConfiguration
  {
    private const string MASTER_CONFIG_RESOURCE = "ConfigurationSystem/Configuration Selector";

    private static GameConfiguration _instance;

    private readonly ConfigurationSelector _configurationSelector;

    private GameConfiguration(string configurationSelectorResourceName)
    {
      _configurationSelector = Resources.Load<ConfigurationSelector>(configurationSelectorResourceName);
    }

    // TODO: This is how to do it in 1 line of code
    // public static GameConfiguration Instance2 { get; } = new GameConfiguration(MASTER_CONFIG_RESOURCE);
    
    public static GameConfiguration Instance
    {
      get
      {
        if (_instance == null)
        {
          _instance = new GameConfiguration(MASTER_CONFIG_RESOURCE);
        }

        return _instance;
      }
    }
    public ConfigurationModel GetCurrentConfig() => _configurationSelector.GetCurrentConfig();
  }
}
