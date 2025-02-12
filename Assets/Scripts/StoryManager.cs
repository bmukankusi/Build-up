using UnityEngine;
using UnityEngine.UI;

public class StoryManager : MonoBehaviour
{
    public static StoryManager Instance;
    public Text storyText;  // Assign your UI text here
    public string[] roomStories; // Store story for each room

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ShowStory(int roomIndex)
    {
        if (roomIndex < roomStories.Length)
        {
            storyText.text = roomStories[roomIndex];
        }
    }
}
