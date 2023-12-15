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
    [SerializeField] private string nextLevel;
    [SerializeField] private string currentLevel;

    private float targetTime = 5f;
    private float targetTime2 = 5f;

    private bool hasStarted = false;
    private bool finishedLevel = false;
    public float runTimer = 0f;

    private bool alreadyRun = false;


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
            if (runTimer >= 90)
            {
                levelFinish();
                runTimer = 90;
            }
            float a = Mathf.FloorToInt(runTimer*10);
            runTimerDisplay.GetComponent<TextMeshProUGUI>().text = (a / 10).ToString();
        }

        if (finishedLevel)
        {
            targetTime2 -= Time.deltaTime;

            if (targetTime2 <= 0)
            {
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

                //load next level here
                if (PlayerPrefs.GetInt("isTest") == 0)
                {
                    SceneManager.LoadSceneAsync("Scenes/StartMenu");
                } else
                {
                    if (!alreadyRun)
                    {
                        alreadyRun = true;
                        PlayerPrefs.SetFloat(currentLevel + PlayerPrefs.GetString("system"), runTimer);
                        if (nextLevel != "slut")
                        {
                            SceneManager.LoadSceneAsync("Scenes/" + nextLevel);
                        }
                        else if (nextLevel == "slut" && systemsNotDone.Count > 0)
                        {
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
                        else
                        {
                            SceneManager.LoadSceneAsync("Scenes/EndScene");
                        }
                    }
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
