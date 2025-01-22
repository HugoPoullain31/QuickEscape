using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    [Header("Paramètres du Timer")]
    public float timerDuration = 10f; // Durée du timer en secondes
    private float currentTimer;

    [Header("Paramètres du Joueur")]
    public GameObject player; // Référence au joueur
    public Transform playerStartPosition; // Position de départ du joueur


    private bool isLevelCompleted = false; // Indique si le joueur a terminé le niveau

    private void Start()
    {
        RestartTimer(); // Démarre le timer au début du niveau
    }

    private void Update()
    {
        if (!isLevelCompleted)
        {
            currentTimer -= Time.deltaTime; // Réduit le timer au fil du temps
            if (currentTimer <= 0f)
            {
                // Si le timer expire, réinitialise le niveau
                Debug.Log("Temps écoulé ! Redémarrage du niveau.");
                RestartLevel();
            }
        }
    }

    private void RestartTimer()
    {
        currentTimer = timerDuration; // Réinitialise le timer
    }

    private void RestartLevel()
    {
        // Réinitialise la position du joueur
        player.transform.position = playerStartPosition.position;

        // Réinitialise le timer
        RestartTimer();
    }

}
