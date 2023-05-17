
using UnityEngine;
using Game.Configuration;

// TODO: Please never leave types without a namespace.

public class ConfigTestButton : MonoBehaviour
{
  public void onTestButtonClick() // TODO: Please follow the naming convention: OnTestButtonClick
  {
    var currentGameConfiguration = GameConfiguration.Instance.GetCurrentConfig();
    Debug.Log(currentGameConfiguration.ToString());
  }
}
