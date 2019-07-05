using UnityEngine;

public class CameraController : MonoBehaviour {
    //Panning(Moving the camera in the horizontal axis)
    public float panSpeed = 30f;
    public float panBorderThickness = 10f;
    public bool cameraActive = true;
    public float minPanZ = -300f;
    public float maxPanZ = 300f;
    //Scrolling(Zoom in/out)
    public float scrollSpeed = 5f;
    public float minScrollY = 10f;
    public float maxScrollY = 80f;
    //private string movementChar;
	// Update is called once per frame
	void Update () {
        if (cameraActive)
        {
            if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - panBorderThickness)//Camera is top-down
            {
                //TODO: Clamp camera movement
                transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
            }
            else if (Input.GetKey("s") || Input.mousePosition.y <= panBorderThickness)
            {
                transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
            }
            else if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width - panBorderThickness)
            {
                transform.Translate(-Vector3.right * panSpeed * Time.deltaTime, Space.World);
            }
            else if (Input.GetKey("a") || Input.mousePosition.x <= panBorderThickness)
            {
                transform.Translate(-Vector3.left * panSpeed * Time.deltaTime, Space.World);
            }

            float scroll = Input.GetAxis("Mouse ScrollWheel");
            Vector3 pos = transform.position;
            pos.y -= scroll * scrollSpeed * Time.deltaTime * 1000;
            pos.y = Mathf.Clamp(pos.y, minScrollY, maxScrollY);
            transform.position = pos;
        }
        //TODO: Check switch statement
        //movementChar = Input.inputString;  
        //switch (movementChar)
        //{
        //    case "w":
        //        transform.Translate(-Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        //    break;
        //}
    }
}
