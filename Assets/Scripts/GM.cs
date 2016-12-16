using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM : MonoBehaviour {

    public int coins = 0;
    public int lives = 3;

    public Text coinsText;
    public Text livesText;


	void Start () {
        coinsText.text = coins.ToString();
        livesText.text = lives.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	//yo
	}

    public void CoinWasPickedUp(int worth)
    {
        coins += worth;
        coinsText.text = coins.ToString();
    }

    public void LifeLost()
    {
        lives--;
        livesText.text = lives.ToString();
    }
}
