using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    /// <summary>
    /// Back button function to go back to the main menu.
    /// </summary>
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu"); 
    }
}
