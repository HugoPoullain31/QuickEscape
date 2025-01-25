using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string levelToLoad;

    public GameObject settingWindow;
    public GameObject rulesWindow;

  public void StartClassicMode()
    {
        GameMode.SetMode(false); // Mode classique
        SceneManager.LoadScene(1); // Charge la première scène
    }

    public void StartBouffilMode()
    {
        GameMode.SetMode(true); // Mode bouffil
        SceneManager.LoadScene(1); // Charge la première scène
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
