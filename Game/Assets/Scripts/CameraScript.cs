using System.Collections;
using UnityEngine;

public class CameraScript : MonoBehaviour {

    private Vector3 cameraTarget;
    public Transform target;
    private Camera cam;

    public Vector3 offset;
    public float mouseRange = 5f;

	void Start ()
    {
        cam = GetComponent<Camera>();
        transform.eulerAngles = new Vector3(70, 0, 0);
    }

    void Update()
    {
        var mousePos = Input.mousePosition;
        mousePos.z = mouseRange;
        Vector3 CursorPosition = cam.ScreenToWorldPoint(mousePos);

        Vector3 Center = new Vector3((target.position.x + CursorPosition.x) / 2 + offset.x, target.position.y + offset.y, (target.position.z + CursorPosition.z) / 2 + offset.z);

        transform.position = Vector3.Lerp(transform.position, Center, Time.deltaTime * 8);
    }
}
