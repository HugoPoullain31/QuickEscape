using UnityEngine;

public class GameMode : MonoBehaviour
{
    public static bool isBouffilMode = false; // Mode actuel (classique par défaut)

    public static void SetMode(bool bouffil)
    {
        isBouffilMode = bouffil;
    }
}

