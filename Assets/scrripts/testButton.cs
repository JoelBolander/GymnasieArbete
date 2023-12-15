using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class testButton : MonoBehaviour
{
    public void ClickEvent()
    {
        PlayerPrefs.SetInt("isTest", 1);
        PlayerPrefs.SetInt("wasdIsDone", 0);
        PlayerPrefs.SetInt("diffKeyboardIsDone", 0); 
        PlayerPrefs.SetInt("diffConIsDone", 0); 
        PlayerPrefs.SetInt("turnSpeedIsDone", 0); 
        PlayerPrefs.SetInt("oneStickIsDone", 0); 
        PlayerPrefs.SetInt("musIsDone", 0); 
        PlayerPrefs.SetInt("knappIsDone", 0);
        PlayerPrefs.SetInt("knappSpecIsDone", 0);

        List<string> systemsNotDone = new List<string>() { };
        if (PlayerPrefs.GetInt("wasdIsDone") == 0)
        {
            systemsNotDone.Add("WASD");
        }
        if (PlayerPrefs.GetInt("diffKeyboardIsDone") == 0)
        {
            systemsNotDone.Add("Differential Tangentbord");
        }
        if (PlayerPrefs.GetInt("diffConIsDone") == 0)
        {
            systemsNotDone.Add("Differential Kontroll");
        }
        if (PlayerPrefs.GetInt("turnSpeedIsDone") == 0)
        {
            systemsNotDone.Add("Sväng- och hastighets- spak");
        }
        if (PlayerPrefs.GetInt("oneStickIsDone") == 0)
        {
            systemsNotDone.Add("En spak");
        }
        if (PlayerPrefs.GetInt("musIsDone") == 0)
        {
            systemsNotDone.Add("Mus");
        }
        if (PlayerPrefs.GetInt("knappIsDone") == 0)
        {
            systemsNotDone.Add("Knapp- kontroll");
        }
        if (PlayerPrefs.GetInt("knappSpecIsDone") == 0)
        {
            systemsNotDone.Add("Knapp- kontroll special");
        }

        PlayerPrefs.SetString("system", systemsNotDone[Mathf.FloorToInt(Random.Range(0, systemsNotDone.Count))]);
        if (PlayerPrefs.GetString("system") == "WASD")
        {
            PlayerPrefs.SetInt("wasdIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "Differential Tangentbord")
        {
            PlayerPrefs.SetInt("diffKeyboardIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "Differential Kontroll")
        {
            PlayerPrefs.SetInt("diffConIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "Sväng- och hastighets- spak")
        {
            PlayerPrefs.SetInt("turnSpeedIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "En spak")
        {
            PlayerPrefs.SetInt("oneStickIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "Mus")
        {
            PlayerPrefs.SetInt("musIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "Knapp- kontroll")
        {
            PlayerPrefs.SetInt("knappIsDone", 1);
        }
        if (PlayerPrefs.GetString("system") == "Knapp- kontroll special")
        {
            PlayerPrefs.SetInt("knappSpecIsDone", 1);
        }
        SceneManager.LoadSceneAsync("Scenes/Rak");
    }
}
