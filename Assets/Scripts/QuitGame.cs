using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public void QuitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); // Make sure the MainMenu scene is added in Build Settings!
    }
}
