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
    
    // TODO: What a awful naming :) Please follow C# convention: EnvironmentType. Here you define new type that should have a proper name.
    // Usually even this tiny enums are taken into a separate files
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
          // TODO: What you are trying to do here is called 'error hiding'. On a caller side you will do null-check
          // and will make the game continue to work. This can lead to the condition when developers are unaware of the huge problem - 
          // one of the environments have no parameters set. You have to stop the execution and provide a clear indication of the problem
          // Raise an exception here
      }
    }
  }

}
