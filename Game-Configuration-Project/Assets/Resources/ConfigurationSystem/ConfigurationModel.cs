using UnityEngine;
namespace Game.Configuration
{
  [CreateAssetMenu(fileName = "New Configuration Model,", menuName = "Create Configuration Model")]
  public class ConfigurationModel : ScriptableObject
  {
    // TODO: Always specify access modifiers (private/protected/public)
    [SerializeField] string _serverAdress;
    [SerializeField] string _logPrefix;
    [SerializeField] float _serverTimout;
    [SerializeField] int _gameVersion;

    public string ServerAdress => _serverAdress;
    public string LogPrefix => _logPrefix;
    public float ServerTimeout => _serverTimout;
    public int GameVersion => _gameVersion;
  }
}
