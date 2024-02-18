using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputScript : MonoBehaviour
{
    //fears
    public int lightning = 9000000;
    public int airCrash = 11000000;
    public int meteorite = 840000000;
    public int sharkAttack = 3700000;


    //gambling
    public int powerBall1 = 292000000;
    public int powerBall2 = 11688053;
    public int powerball3 = 913129;

    public int royalFlush = 649739;
    public int straightFlush = 72193;
    public int fourKind = 4164;
    public int fullHouse = 693;
    public int flush = 508;
    public int straight = 253;

    public int genshinFive = 167;
    public InputField numberInputField;
    private string enteredNumber;
    public TMP_InputField text;

        [Header("The value we got from the input field")]
        public string inputText;

        [Header("Showing the reaction to the player")]
        [SerializeField] private GameObject reactionGroup;
        [SerializeField] private TMP_Text reactionTextBox;

    public void GrapFromInputField(string input){
            inputText = input;
            //DisplayReactionToInput();
    }
    public void setPowerBall1(){
        inputText = powerBall1.ToString();
        text.text = powerBall1.ToString();
    }
    public void setRoyalFlush(){
        inputText = royalFlush.ToString();
        text.text = royalFlush.ToString();
    }
    public void setStraightFlush(){
        inputText = straightFlush.ToString();
        text.text = straightFlush.ToString();
    }
    public void setFourKind(){
        inputText = fourKind.ToString();
        text.text = fourKind.ToString();
    }
    public void setFullHouse(){
        inputText = fullHouse.ToString();
        text.text = fullHouse.ToString();
    }
    public void setLightning(){
        inputText = lightning.ToString();
        text.text = lightning.ToString();
    }
    public void setGenshinFive(){
        inputText = genshinFive.ToString();
        text.text = genshinFive.ToString();
    }
    public void setAirCrash(){
        inputText = airCrash.ToString();
        text.text = airCrash.ToString();
    }
    public void setMeteorite(){
        inputText = meteorite.ToString();
        text.text = meteorite.ToString();
    }
    public void setSharkAttack(){
        inputText = sharkAttack.ToString();
        text.text = sharkAttack.ToString();
    }
/*
    private void DisplayReactionToInput(){
            reactionTextBox.text = "Loading Dice/Coins approximate to: " + inputText;
            reactionGroup.SetActive(true);
    }
    */

    }
    
