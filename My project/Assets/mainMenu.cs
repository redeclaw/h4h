using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    public void ExitButton(){
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void startSim(){
        SceneManager.LoadScene("simScene");
    }
}

