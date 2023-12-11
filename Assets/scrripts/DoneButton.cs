using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DoneButton : MonoBehaviour
{
    [SerializeField] private GameObject selectedSystem;
    [SerializeField] private GameObject selectedLevel;

    public void ClickEvent()
    {
        if (selectedSystem.GetComponent<TextMeshProUGUI>().text != "" && selectedLevel.GetComponent<TextMeshProUGUI>().text != "")
        {
            PlayerPrefs.SetInt("isTest", 0);
            PlayerPrefs.SetString("system", selectedSystem.GetComponent<TextMeshProUGUI>().text);

            SceneManager.LoadSceneAsync("Scenes/" + selectedLevel.GetComponent<TextMeshProUGUI>().text);
        }
    }
}
