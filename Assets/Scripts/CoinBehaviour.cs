using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinBehaviour : MonoBehaviour
{
    public GameObject player;
    public GameObject AllCoins;
    public static int NumCoins = 0;
    public Text CoinsText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)

        //Only player can collect coins
    {
        if (other.gameObject == player.gameObject)
        {
            NumCoins++; //counts collected coins
            CoinsText.text = "Gold:" + NumCoins.ToString();
            gameObject.SetActive(false);
            AudioSource souds = AllCoins.GetComponent<AudioSource>();
            souds.Play();
            
        }
    }
}
