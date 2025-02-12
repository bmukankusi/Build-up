using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Make sure "MainMenu" is the correct scene name
    }
}
