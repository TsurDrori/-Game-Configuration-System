using UnityEngine;

namespace Game.Configuration
{
  [CreateAssetMenu(fileName = "New Configuration Selector,", menuName = "Create Configuration Selector")]
  public class ConfigurationSelector : ScriptableObject
  {
    [SerializeField] _environmentType _currentEnvironment;
    [SerializeField] ConfigurationModel _devParams;
    [SerializeField] ConfigurationModel _qaParams;
    [SerializeField] ConfigurationModel _prodParams;
    enum _environmentType
    {
      Production,
      Development,
      QA
    }

    public ConfigurationModel GetCurrentConfig()
    {
      switch (_currentEnvironment)
      {
        case _environmentType.Development:
          return _devParams;
        case _environmentType.QA:
          return _qaParams;
        case _environmentType.Production:
          return _prodParams;
        default:
          Debug.Log("Unkonwn configuraion type: " + _currentEnvironment);
          return null;

      }
    }
  }

}
