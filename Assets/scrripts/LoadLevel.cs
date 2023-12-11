using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
{
    [SerializeField] private GameObject tank;
    [SerializeField] private GameObject timerDisplay;
    [SerializeField] private GameObject systemDisplay;
    [SerializeField] private GameObject canvas;

    public float targetTime = 5.0f;


    private void Start()
    {
        systemDisplay.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("system");
    }

    private void Update()
    {

        targetTime -= Time.deltaTime;

        float displayThing = Mathf.FloorToInt(targetTime * 10);

        timerDisplay.GetComponent<TextMeshProUGUI>().text = (displayThing/10).ToString();

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        canvas.SetActive(false);
        if (PlayerPrefs.GetInt("isTest") == 0)
        {
            if (PlayerPrefs.GetString("system") == "WASD")
            {
                tank.GetComponent<WASD>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "Differential Tangentbord")
            {
                tank.GetComponent<DiffSim>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "Differential Kontroll")
            {
                tank.GetComponent<ControlerSimDiff>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "Sväng- och hastighets- spak")
            {
                tank.GetComponent<TurnStickSpeedStick>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "En spak")
            {
                tank.GetComponent<OneStick>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "Mus")
            {
                tank.GetComponent<Mus>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "Knapp- kontroll")
            {
                tank.GetComponent<Button>().enabled = true;
            }
            if (PlayerPrefs.GetString("system") == "Knapp- kontroll special")
            {
                tank.GetComponent<ButtonSpecial>().enabled = true;
            }
        }
        else
        {
            // När man gör testet

        }
    }
}
