using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CameraTransition : MonoBehaviour
{
    public Transform[] roomPositions;
    public float transitionDuration = 1.5f;
    private int currentRoomIndex = 0;
    private Camera mainCamera;

    public Button nextButton; // Assign this in Inspector
    public Button previousButton; // Assign this in Inspector

    void Start()
    {
        mainCamera = Camera.main;
        MoveToRoom(0);
    }

    public void NextRoom()
    {
        if (currentRoomIndex < roomPositions.Length - 1)
        {
            currentRoomIndex++;
            MoveToRoom(currentRoomIndex);
        }

        UpdateButtonVisibility();
    }

    public void PreviousRoom()
    {
        if (currentRoomIndex > 0)
        {
            currentRoomIndex--;
            MoveToRoom(currentRoomIndex);
        }

        UpdateButtonVisibility();
    }

    private void MoveToRoom(int roomIndex)
    {
        mainCamera.transform.DOMove(roomPositions[roomIndex].position, transitionDuration)
            .SetEase(Ease.InOutSine);
        mainCamera.transform.DORotateQuaternion(roomPositions[roomIndex].rotation, transitionDuration);

        StoryManager.Instance.ShowStory(roomIndex);
    }

    private void UpdateButtonVisibility()
    {
        nextButton.gameObject.SetActive(currentRoomIndex < roomPositions.Length - 1);
        previousButton.gameObject.SetActive(currentRoomIndex > 0);
    }
}
