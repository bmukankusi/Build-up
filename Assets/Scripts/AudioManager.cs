using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Keep music playing across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicate music instances
        }
    }
}
