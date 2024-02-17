using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChanceManager : MonoBehaviour
{
    public enum ChanceType{
        coin,
        dice,
        roulette
    }
    public ChanceType chanceType;
    public GameObject coin;
    public GameObject dice;
    public GameObject roulette;
    public GameObject canvas;
    public int probability;
    


    // Start is called before the first frame update
    public void Start(){

    }

    public void StartSim()
    {
        switch (chanceType){
            case ChanceType.coin:
                int numCoins = (int)Math.Ceiling(Math.Log(probability, 2));
                for (int i = 0; i < numCoins; i++){
                    GameObject newCoin = Instantiate(coin, new Vector2(0, 0), Quaternion.identity);
                    newCoin.transform.SetParent(canvas.transform);
                    int NumFlips = UnityEngine.Random.Range(3, 7);
                    newCoin.GetComponent<CoinFlip>().NumFlips = NumFlips * 2 + 1;
                }
                
                break;
            case ChanceType.dice:
                int numDice = (int)Math.Ceiling(Math.Log(probability, 6));
                for (int i = 0; i < numDice; i++){
                    GameObject newDice = Instantiate(dice, new Vector2(0, 0), Quaternion.identity);
                    newDice.transform.SetParent(canvas.transform);
                }
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
