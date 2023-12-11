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
    [SerializeField] private GameObject picture;
    [SerializeField] private GameObject runTimerDisplay;
    [SerializeField] private GameObject runTimerImage;

    public float targetTime = 5.0f;
    public float targetTime2 = 5.0f;

    private bool hasStarted = false;
    private bool finishedLevel = false;
    private float runTimer = 0f;


    private void Start()
    {
        systemDisplay.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetString("system");
    }

    private void Update()
    {
        if (!hasStarted)
        {
            targetTime -= Time.deltaTime;

            float displayThing = Mathf.FloorToInt(targetTime * 10);

            timerDisplay.GetComponent<TextMeshProUGUI>().text = (displayThing / 10).ToString();

            if (targetTime <= 0.0f)
            {
                timerEnded();
                startGameTimer();
            }
        } else if (hasStarted && !finishedLevel)
        {
            runTimer += Time.deltaTime;
            float a = Mathf.FloorToInt(runTimer*10);
            runTimerDisplay.GetComponent<TextMeshProUGUI>().text = (a / 10).ToString();
        }

        if (finishedLevel)
        {
            targetTime2 -= Time.deltaTime;

            if (targetTime2 <= 0)
            {
                //load next level here
                if (PlayerPrefs.GetInt("isTest") == 0)
                {
                    SceneManager.LoadSceneAsync("Scenes/StartMenu");
                }
            }
        }
    }

    void timerEnded()
    {
        picture.SetActive(false);
        timerDisplay.SetActive(false);
        systemDisplay.SetActive(false);

        runTimerImage.SetActive(true);
        runTimerDisplay.SetActive(true);

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

    private void startGameTimer()
    {
        hasStarted = true;
    }

    public void levelFinish()
    {
        if (PlayerPrefs.GetString("system") == "WASD")
        {
            tank.GetComponent<WASD>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "Differential Tangentbord")
        {
            tank.GetComponent<DiffSim>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "Differential Kontroll")
        {
            tank.GetComponent<ControlerSimDiff>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "Sväng- och hastighets- spak")
        {
            tank.GetComponent<TurnStickSpeedStick>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "En spak")
        {
            tank.GetComponent<OneStick>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "Mus")
        {
            tank.GetComponent<Mus>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "Knapp- kontroll")
        {
            tank.GetComponent<Button>().enabled = false;
        }
        if (PlayerPrefs.GetString("system") == "Knapp- kontroll special")
        {
            tank.GetComponent<ButtonSpecial>().enabled = false;
        }
        finishedLevel = true;
    }
}
