using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public RepresentationSelector.RepType repType;
    public int probability;
    public RepresentationSelector representationSelector;
    public InputScript inputScript;
    public static SelectManager instance;

    void Awake(){
        DontDestroyOnLoad(this);
        if (instance == null){
            instance = this;
        }
        else{
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void Simulate(){
        instance.repType = instance.representationSelector.repType;
        //instance.probability = instance.inputScript.
    }
}
