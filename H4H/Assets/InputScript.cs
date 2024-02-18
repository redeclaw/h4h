using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputScript : MonoBehaviour
{
    //fears
    public int lightning = 114195;
    public int airCrash = 205552;

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
        Debug.Log("a");
        inputText = powerBall1.ToString();
        text.text = powerBall1.ToString();
        //inputText = powerBall1;
    }
/*
    private void DisplayReactionToInput(){
            reactionTextBox.text = "Loading Dice/Coins approximate to: " + inputText;
            reactionGroup.SetActive(true);
    }
    */

    }
    
