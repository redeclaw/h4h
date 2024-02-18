using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RepresentationSelector : MonoBehaviour
{
    public enum RepType{
        coin,
        dice
    }
    public GameObject CoinButton;
    public GameObject DiceButton;
    public RepType repType;
    public void CoinPicked(){
        repType = RepType.coin;
        DiceButton.GetComponent<Button>().interactable = true;
        CoinButton.GetComponent<Button>().interactable = false;
    }
    public void DicePicked(){
        repType = RepType.dice;
        CoinButton.GetComponent<Button>().interactable = true;
        DiceButton.GetComponent<Button>().interactable = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
