using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    [Header("Paramètres du Timer")]
    public float timerDuration = 10f; 
    private float currentTimer;

    [Header("Paramètres du Joueur")]
    public GameObject player;
    public Transform playerStartPosition;

    private bool isLevelCompleted = false;

    [Header("Groupes de niveaux")]
    public int easyStartIndex = 1;
    public int mediumStartIndex = 5;
    public int hardcoreStartIndex = 9;

    private void Start()
    {
        RestartTimer();
    }

    private void Update()
    {
        if (!isLevelCompleted)
        {
            currentTimer -= Time.deltaTime;

            if (currentTimer <= 0f)
            {
                if (GameMode.isBouffilMode)
                {
                    // Mode bouffil : retour au début du groupe
                    Debug.Log("Mode bouffil : temps écoulé. Retour au début du niveau.");
                    RestartLevelGroup();
                }
                else
                {
                    // Mode classique : respawn dans la même salle
                    Debug.Log("Mode classique : temps écoulé. Respawn dans la salle actuelle.");
                    RestartLevel();
                }
            }
        }
    }

    private void RestartTimer()
    {
        currentTimer = timerDuration;
    }

    private void RestartLevel()
    {
        player.transform.position = playerStartPosition.position;
        RestartTimer();
    }

    private void RestartLevelGroup()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int startIndex = GetGroupStartIndex(currentSceneIndex);
        SceneManager.LoadScene(startIndex);
    }

    private int GetGroupStartIndex(int currentSceneIndex)
    {
        if (currentSceneIndex >= easyStartIndex && currentSceneIndex < mediumStartIndex)
            return easyStartIndex;
        else if (currentSceneIndex >= mediumStartIndex && currentSceneIndex < hardcoreStartIndex)
            return mediumStartIndex;
        else
            return hardcoreStartIndex;
    }

    public void OnPlayerFindsExit()
    {
        isLevelCompleted = true;
        Debug.Log("Niveau terminé !");
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
