using UnityEngine;

public class Zoom : MonoBehaviour
{
    [SerializeField]
    private float zoomSpeed = 2f;
    [SerializeField]
    private float zoomInMax = 1;
    [SerializeField]
    private float zoomOutMax = 15;

    private Camera mainCamera;
    private float startingZPosition;

    private void Awake()
    {
        mainCamera = Camera.main;
        startingZPosition = mainCamera.transform.position.z;
    }
    public void ZoomScreen(float increment)
    {
        if (increment == 0) return;
        float target = Mathf.Clamp(mainCamera.orthographicSize + increment, zoomInMax, zoomOutMax);
        mainCamera.orthographicSize = Mathf.Lerp(mainCamera.orthographicSize, target, Time.deltaTime * zoomSpeed);
    }
}
