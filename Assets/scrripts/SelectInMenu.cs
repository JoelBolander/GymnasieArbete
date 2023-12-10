using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SelectInMenu : MonoBehaviour
{
    [SerializeField] private GameObject selected;

    public void ClickEvent()
    {
        selected.GetComponent<TextMeshProUGUI>().text = this.gameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text;
    }
}
