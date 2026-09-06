using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float speed = 3;
    CharacterController controller;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        controller = GetComponent<CharacterController>(); //initialization


    }

    // Update is called once per frame
    void Update()
    {
        // נרמול המהירות, שהיא תיהיה אחידה
        float dx=0, dz=0;

        dz = Input.GetAxis("Vertical")*speed*Time.deltaTime;
        dx = Input.GetAxis("Horizontal") * speed * Time.deltaTime;


        // הזזה של השחקן בכיוון שמצוין
        //transform.Translate(new Vector3(0,0,0.03f)); // הזזה בלי עצירה, זז אוטומטית
        // transform.Translate(new Vector3(dx, 0,dz)); //הזזה בלי קשר למכשולים

        // הזזה בתחשבות במכשולים

        Vector3 motion = new Vector3(dx, 0, dz);
        controller.Move(motion);

    }
}
