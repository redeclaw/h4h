using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ChanceManager : MonoBehaviour
{
    public TextMeshProUGUI displayText;
    public RepresentationSelector.RepType repType;
    public SelectManager selectManager;
    public GameObject coin;
    public GameObject dice;
    public GameObject roulette;
    public GameObject table;
    public int probability;
    


    // Start is called before the first frame update
    public void Start(){
        selectManager = GameObject.Find("SelectManager").GetComponent<SelectManager>();
        probability = selectManager.probability;
        repType = selectManager.repType;
        StartSim();
    }

    public void StartSim()
    {
        switch (repType){
            case RepresentationSelector.RepType.coin:
                int numCoins = (int)Math.Ceiling(Math.Log(probability, 2));
                for (int i = 0; i < numCoins; i++){
                    GameObject newCoin = Instantiate(coin, new Vector2(0, 0), Quaternion.identity);
                    newCoin.transform.SetParent(table.transform);
                }
                displayText.text = $"1/{probability} =~ {numCoins} heads in a row";
                
                break;
            case RepresentationSelector.RepType.dice:
                int numDice = (int)Math.Ceiling(Math.Log(probability, 6));
                for (int i = 0; i < numDice; i++){
                    GameObject newDice = Instantiate(dice, new Vector2(0, 0), Quaternion.identity);
                    newDice.transform.SetParent(table.transform);
                }
                displayText.text = $"1/{probability} =~ {numDice} sixes in a row";
                break;

        }
    }

    public void Retry(){
        table.BroadcastMessage("Try");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
