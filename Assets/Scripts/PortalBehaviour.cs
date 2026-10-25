using UnityEngine;
using UnityEngine.SceneManagement;

public class PortalBehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // go to another scene
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1);
        else SceneManager.LoadScene(0);
    }
}
