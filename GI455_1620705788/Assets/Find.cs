using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Find : MonoBehaviour
{
    // Start is called before the first frame update
    public string input;
    public GameObject inputField;
    public GameObject textDisplay;

    void Start()
    {
        
    }
    void update()
    {
        input = inputField.GetComponent<Text>().text;

        switch(input)
        {
            case "Almond pretzel":
                textDisplay.GetComponent<Text>().text = input + " is found";
                break;

            case "Bacon":
                textDisplay.GetComponent<Text>().text = input + " is found"; 
                break;

            case "Chocolate":
                textDisplay.GetComponent<Text>().text = input + " is found";
                break;

            case "Latte":
                textDisplay.GetComponent<Text>().text = input + " is found";
                break;

            case "Oreo frappe":
                textDisplay.GetComponent<Text>().text = input + " is found";
                break;

            default:
                textDisplay.GetComponent<Text>().text =" Not found";
                break;

        }   
        
    }
}
