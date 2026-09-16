using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject PlayerCamera; // public means that it must be connected in Unity
    float speed = 3;
    float angular_speed = 100;
    CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>(); //initialization
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 60;
        Debug.Log("GPU: " + SystemInfo.graphicsDeviceName);
    }

    // Update is called once per frame
    void Update()
    {
        // נרמול המהירות, שהיא תיהיה אחידה
        float dx=0, dz=0;
        float RotationAboutY = Input.GetAxis("Mouse X")* angular_speed*Time.deltaTime;
        float RotationAboutX = -Input.GetAxis("Mouse Y") * 0.2f*angular_speed * Time.deltaTime;

        PlayerCamera.transform.Rotate(RotationAboutX, 0, 0);
        transform.Rotate(new Vector3(0, RotationAboutY,0));
        dz = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;


        // הזזה של השחקן בכיוון שמצוין
        //transform.Translate(new Vector3(0,0,0.03f)); // הזזה בלי עצירה, זז אוטומטית
        // transform.Translate(new Vector3(dx, 0,dz)); //הזזה בלי קשר למכשולים

        // הזזה בתחשבות במכשולים

        Vector3 motion = new Vector3(dx, -1, dz);
        motion = transform.TransformDirection(motion); // transforms mation to global coordinates
        controller.Move(motion); //global coordinates


        /////

    }
}
