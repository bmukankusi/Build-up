using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject mainMenuPanel;
    public GameObject instructionsPanel;
    public GameObject settingsPanel;
    public GameObject profilePanel;
    public GameObject creditsPanel;
    public GameObject quitPanel;

    void Start()
    {
        ShowMainMenu();
    }

    /// <summary>
    /// Show the main menu panel and hide all other panels.
    /// </summary>

    public void ShowMainMenu()
    {
        mainMenuPanel.SetActive(true);
        instructionsPanel.SetActive(false);
        settingsPanel.SetActive(false);
        profilePanel.SetActive(false);
        creditsPanel.SetActive(false);
        quitPanel.SetActive(false);
    }

    /// <summary>
    /// Toggle panels to show/hide them.
    /// </summary>

    public void ShowInstructions() { TogglePanel(instructionsPanel); }
    public void ShowSettings() { TogglePanel(settingsPanel); }
    public void ShowProfile() { TogglePanel(profilePanel); }
    public void ShowCredits() { TogglePanel(creditsPanel); }
    public void ShowQuitPanel() { TogglePanel(quitPanel); }

    private void TogglePanel(GameObject panel)
    {
        mainMenuPanel.SetActive(false);
        instructionsPanel.SetActive(false);
        settingsPanel.SetActive(false);
        profilePanel.SetActive(false);
        creditsPanel.SetActive(false);
        quitPanel.SetActive(false);

        panel.SetActive(true);
    }

    public void QuitConfirmationYes() { ShowMainMenu(); }
    public void QuitConfirmationNo() { Application.Quit(); }

    /// <summary>
    /// Open the game scene.
    /// </summary>
    public void StartGame()
    {
        SceneManager.LoadScene("Game"); // Ensure "Demo" is correctly named in Build Settings
    }
}
