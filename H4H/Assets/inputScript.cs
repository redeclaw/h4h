using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputScript : MonoBehaviour
{
    public InputField numberInputField;
    private int enteredNumber;

        [Header("The value we got from the input field")]
        [SerializeField] private string inputText;

        [Header("Showing the reaction to the player")]
        [SerializeField] private GameObject reactionGroup;
        [SerializeField] private TMP_Text reactionTextBox;

    public void GrapFromInputField(string input){
            inputText = input;
            //DisplayReactionToInput();
    }
/*
    private void DisplayReactionToInput(){
            reactionTextBox.text = "Loading Dice/Coins approximate to: " + inputText;
            reactionGroup.SetActive(true);
    }
    */

    }
    