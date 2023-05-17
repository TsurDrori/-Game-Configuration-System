
using UnityEngine;
using Game.Configuration;

public class ConfigTestButton : MonoBehaviour
{
  public void onTestButtonClick()
  {
    var currentGameConfiguration = GameConfiguration.Instance.GetCurrentConfig();
    Debug.Log(currentGameConfiguration.ToString());
  }
}
