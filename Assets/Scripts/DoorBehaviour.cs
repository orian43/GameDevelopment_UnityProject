using UnityEngine;

public class DoorBehaviour : MonoBehaviour

    
{
    Animator animator;
    AudioSource sound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Animator Initialization
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)

    {
        Debug.Log("Enter - Opening");
        animator.SetBool("Open", true);
        sound.PlayDelayed(0.2f);
        
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit - Closing door");

        animator.SetBool("Open", false);
        sound.PlayDelayed(0.5f);
       


    }



}
