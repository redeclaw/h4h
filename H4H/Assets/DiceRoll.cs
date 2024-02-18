using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    public Sprite[] faces;
    public Image image;
    // Start is called before the first frame update
    void Start(){
        Try();
    }
    public void Try()
    {
        StartCoroutine(StartRoll());
    }

    IEnumerator StartRoll(){
        int numRolls = Random.Range(10, 35);
        for (int i = 0; i < numRolls; i++){
            int diceRoll = UnityEngine.Random.Range(0, 6);
            image.sprite = faces[diceRoll];
            yield return new WaitForSeconds(0.1f);
        }
        //image.sprite = faces[5];
        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
