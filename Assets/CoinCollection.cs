using TMPro;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int coin = 0;
    public  TextMeshProUGUI coinText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coin")
        {
            coin++;
            coinText.text = "Coin: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }
    }
}
