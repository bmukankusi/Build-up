using UnityEngine;
using DG.Tweening; // Ensure you have DOTween imported
using UnityEngine.UI;

public class CameraTransition : MonoBehaviour
{
    public Transform[] roomPositions; // Assign camera positions in Inspector
    public float transitionDuration = 1.5f; // Time for smooth movement
    private int currentRoomIndex = 0;
    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        MoveToRoom(0); // Start in the first room
    }

    public void NextRoom()
    {
        if (currentRoomIndex < roomPositions.Length - 1)
        {
            currentRoomIndex++;
            MoveToRoom(currentRoomIndex);
        }
    }

    public void PreviousRoom()
    {
        if (currentRoomIndex > 0)
        {
            currentRoomIndex--;
            MoveToRoom(currentRoomIndex);
        }
    }

    private void MoveToRoom(int roomIndex)
    {
        // Move the camera to the next room smoothly
        mainCamera.transform.DOMove(roomPositions[roomIndex].position, transitionDuration)
            .SetEase(Ease.InOutSine);

        // Rotate the camera if needed
        mainCamera.transform.DORotateQuaternion(roomPositions[roomIndex].rotation, transitionDuration);

        // Update the story when moving to the new room
        StoryManager.Instance.ShowStory(roomIndex);
    }
}
