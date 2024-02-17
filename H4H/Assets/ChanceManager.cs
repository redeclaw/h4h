using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class ChanceManager : MonoBehaviour
{
    public GameObject coin;
    public GameObject dice;
    public GameObject roulette;
    public GameObject canvas;
    public int probability;
    
    // Start is called before the first frame update
    void Start()
    {
        int numcoins = (int)Math.Ceiling(Math.Log(probability, 2));
        for (int i = 0; i < numcoins; i++){
            GameObject newCoin = Instantiate(coin, new Vector2(0, 0), Quaternion.identity);
            newCoin.transform.SetParent(canvas.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
