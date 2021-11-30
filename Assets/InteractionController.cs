using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionController : MonoBehaviour
{
    public GameObject kwadrat;
    public GameObject kulka;

    public string TextToDisplay = "Click 'E' to interact";
    public Text textField;

    public myEnum InteractionType = new myEnum();
    public enum myEnum
    {
        Animation,
        ObjectStateChange,
        Item3
    };

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
           textField.text = TextToDisplay;
           kwadrat.SetActive(false);
           kulka.SetActive(true);
        }
            
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            textField.text = "";
            kwadrat.SetActive(true);
            kulka.SetActive(false);
        }
    }
}
