using UnityEngine;
using UnityEngine.Events;

public class CollisionDetector : MonoBehaviour
{
    [SerializeField] 
    private string targetTag = "Player"; // Tag de l'objet cible (ex : Player pour la clé)
    
    [SerializeField] 
    private bool desactivateOnCollision = false; // Désactive l'objet en collision si activé
    
    [SerializeField] 
    private UnityEvent onCollisionEnter; // Événement appelé lors de la collision

    [SerializeField] 
    private UnityEvent onCollisionExit; // Événement appelé en sortie de collision

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(targetTag)) // Vérifie le tag du joueur
        {
            Debug.Log($"Collision détectée avec : {col.gameObject.name}");
            onCollisionEnter?.Invoke(); // Invoque l'événement
            if (desactivateOnCollision)
            {
                gameObject.SetActive(false); // Désactive l'objet courant (par exemple, la clé)
            }
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.CompareTag(targetTag)) // Vérifie le tag du joueur
        {
            Debug.Log($"Collision terminée avec : {col.gameObject.name}");
            onCollisionExit?.Invoke(); // Invoque l'événement
        }
    }
}
