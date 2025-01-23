using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad;

    public GameObject settingWindow;
    public GameObject rulesWindow;

  public void StartGame()
  {
        SceneManager.LoadScene(levelToLoad);

  }
   public void SettingButton()
  {
    settingWindow.SetActive(true);
    
  }

  public void CloseSettingWindow()
  {
    settingWindow.SetActive(false);
  }
   public void QuitGame()
  {
      Application.Quit();
    
  }


  public void RulesButton()
  {
    rulesWindow.SetActive(true);
    
  }

  public void CloseRulesWindow()
  {
    rulesWindow.SetActive(false);
  }
}
