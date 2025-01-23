using UnityEngine;

public class Key : MonoBehaviour
{
    private bool isInRange; // Indique si le joueur est en collision avec la clé
    private Door door;      // Référence à la porte

    private void Awake()
    {
        // Trouve la porte dans la scène avec le tag "door" et récupère son script Door
        GameObject doorObject = GameObject.FindWithTag("door");
        if (doorObject != null)
        {
            door = doorObject.GetComponent<Door>();
        }
        else
        {
            Debug.LogError("Aucun objet avec le tag 'door' n'a été trouvé !");
        }
    }

    private void Update()
    {
        // Vérifie si le joueur est dans la zone et appuie sur la touche E
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            if (door != null)
            {
                door.Open(); // Ouvre la porte
                Destroy(gameObject); // Détruit la clé après utilisation
            }
            else
            {
                Debug.LogError("La porte n'a pas été assignée !");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Vérifie si le joueur entre dans la zone
        {
            isInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // Vérifie si le joueur sort de la zone
        {
            isInRange = false;
        }
    }
}
