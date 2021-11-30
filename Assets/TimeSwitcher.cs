using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TimeSwitcher : MonoBehaviour
{
    [SerializeField]
    private string DaySceneName;
    [SerializeField]
    private string NightScenename;

    public string TextToDisplay = "Click 'E' to interact";
    public Text textField;


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            textField.text = TextToDisplay;

            if (Input.GetKeyDown("e"))
            {
                Scene scene = SceneManager.GetActiveScene();
                if (scene.name == DaySceneName)
                {
                    SceneManager.LoadScene(NightScenename);
                }
                else
                {
                    SceneManager.LoadScene(DaySceneName);
                }
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        textField.text = "";
    }
}