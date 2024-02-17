using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinFlip : MonoBehaviour
{
    [SerializeField] private Sprite[] Faces;
    public Image CoinImage;
    public int NumFlips = 11;
    void Start(){
        StartCoroutine(FlipCoin(.005f, 1, NumFlips));
    }
    public IEnumerator FlipCoin(float duration, float size, int NumFlips){
        for (int i = 0; i < NumFlips; i++){
            while (size > 0.1){
                size -= 0.07f;
                transform.localScale = new Vector3(1, size, 1);
                yield return new WaitForSeconds(duration);
            }
            CoinImage.sprite = Faces[i % 2];
            while (size < 0.99){
                size += 0.07f;
                transform.localScale = new Vector3(1, size, size);
                yield return new WaitForSeconds(duration);
            }
        }
    }
}
