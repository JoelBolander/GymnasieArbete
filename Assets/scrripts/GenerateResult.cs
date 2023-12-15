using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerateResult : MonoBehaviour
{
    // timerDisplay.GetComponent<TextMeshProUGUI>().text
    [Header("wasd")]
    [SerializeField] private GameObject wasdRak;
    [SerializeField] private GameObject wasdKrok;
    [SerializeField] private GameObject wasdSkarp;
    [SerializeField] private GameObject wasdUSvängar;
    [SerializeField] private GameObject wasdPrecision;
    [SerializeField] private GameObject wasdUltimat;
    [SerializeField] private GameObject wasdTotal;

    [Header("Diff Tang")]
    [SerializeField] private GameObject diffTangRak;
    [SerializeField] private GameObject diffTangKrok;
    [SerializeField] private GameObject diffTangSkarp;
    [SerializeField] private GameObject diffTangUSvängar;
    [SerializeField] private GameObject diffTangPrecision;
    [SerializeField] private GameObject diffTangUltimat;
    [SerializeField] private GameObject diffTangTotal;

    [Header("Diff Kontroll")]
    [SerializeField] private GameObject diffKontRak;
    [SerializeField] private GameObject diffKontKrok;
    [SerializeField] private GameObject diffKontSkarp;
    [SerializeField] private GameObject diffKontUSvängar;
    [SerializeField] private GameObject diffKontPrecision;
    [SerializeField] private GameObject diffKontUltimat;
    [SerializeField] private GameObject diffKontTotal;

    [Header("Sväng och Hastighet")]
    [SerializeField] private GameObject svängHastighetRak;
    [SerializeField] private GameObject svängHastighetKrok;
    [SerializeField] private GameObject svängHastighetSkarp;
    [SerializeField] private GameObject svängHastighetUSvängar;
    [SerializeField] private GameObject svängHastighetPrecision;
    [SerializeField] private GameObject svängHastighetUltimat;
    [SerializeField] private GameObject svängHastighetTotal;

    [Header("En Spak")]
    [SerializeField] private GameObject enSpakRak;
    [SerializeField] private GameObject enSpakKrok;
    [SerializeField] private GameObject enSpakSkarp;
    [SerializeField] private GameObject enSpakUSvängar;
    [SerializeField] private GameObject enSpakPrecision;
    [SerializeField] private GameObject enSpakUltimat;
    [SerializeField] private GameObject enSpakTotal;

    [Header("Mus")]
    [SerializeField] private GameObject musRak;
    [SerializeField] private GameObject musKrok;
    [SerializeField] private GameObject musSkarp;
    [SerializeField] private GameObject musUSvängar;
    [SerializeField] private GameObject musPrecision;
    [SerializeField] private GameObject musUltimat;
    [SerializeField] private GameObject musTotal;

    [Header("Knappkontroll")]
    [SerializeField] private GameObject knappRak;
    [SerializeField] private GameObject knappKrok;
    [SerializeField] private GameObject knappSkarp;
    [SerializeField] private GameObject knappUSvängar;
    [SerializeField] private GameObject knappPrecision;
    [SerializeField] private GameObject knappUltimat;
    [SerializeField] private GameObject knappTotal;

    [Header("Knappkontroll Special")]
    [SerializeField] private GameObject knappSpecRak;
    [SerializeField] private GameObject knappSpecKrok;
    [SerializeField] private GameObject knappSpecSkarp;
    [SerializeField] private GameObject knappSpecUSvängar;
    [SerializeField] private GameObject knappSpecPrecision;
    [SerializeField] private GameObject knappSpecUltimat;
    [SerializeField] private GameObject knappSpecTotal;

    void Start()
    {
        wasdRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakWASD").ToString();
        wasdKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigWASD").ToString();
        wasdSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpWASD").ToString();
        wasdUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarWASD").ToString();
        wasdPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionWASD").ToString();
        wasdUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatWASD").ToString();
        wasdTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakWASD")+PlayerPrefs.GetFloat("KrokigWASD")+PlayerPrefs.GetFloat("SkarpWASD")+PlayerPrefs.GetFloat("U-svängarWASD")+PlayerPrefs.GetFloat("PrecisionWASD")+PlayerPrefs.GetFloat("UltimatWASD")).ToString();

        diffTangRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakDifferential Tangentbord").ToString();
        diffTangKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigDifferential Tangentbord").ToString();
        diffTangSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpDifferential Tangentbord").ToString();
        diffTangUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarDifferential Tangentbord").ToString();
        diffTangPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionDifferential Tangentbord").ToString();
        diffTangUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatDifferential Tangentbord").ToString();
        diffTangTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakDifferential Tangentbord") + PlayerPrefs.GetFloat("KrokigDifferential Tangentbord") + PlayerPrefs.GetFloat("SkarpDifferential Tangentbord") + PlayerPrefs.GetFloat("U-svängarDifferential Tangentbord") + PlayerPrefs.GetFloat("PrecisionDifferential Tangentbord") + PlayerPrefs.GetFloat("UltimatDifferential Tangentbord")).ToString();

        diffKontRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakDifferential Kontroll").ToString();
        diffKontKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigDifferential Kontroll").ToString();
        diffKontSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpDifferential Kontroll").ToString();
        diffKontUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarDifferential Kontroll").ToString();
        diffKontPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionDifferential Kontroll").ToString();
        diffKontUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatDifferential Kontroll").ToString();
        diffKontTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakDifferential Kontroll") + PlayerPrefs.GetFloat("KrokigDifferential Kontroll") + PlayerPrefs.GetFloat("SkarpDifferential Kontroll") + PlayerPrefs.GetFloat("U-svängarDifferential Kontroll") + PlayerPrefs.GetFloat("PrecisionDifferential Kontroll") + PlayerPrefs.GetFloat("UltimatDifferential Kontroll")).ToString();

        svängHastighetRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakSväng- och hastighets- spak").ToString();
        svängHastighetKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigSväng- och hastighets- spak").ToString();
        svängHastighetSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpSväng- och hastighets- spak").ToString();
        svängHastighetUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarSväng- och hastighets- spak").ToString();
        svängHastighetPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionSväng- och hastighets- spak").ToString();
        svängHastighetUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatSväng- och hastighets- spak").ToString();
        svängHastighetTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakSväng- och hastighets- spak") + PlayerPrefs.GetFloat("KrokigSväng- och hastighets- spak") + PlayerPrefs.GetFloat("SkarpSväng- och hastighets- spak") + PlayerPrefs.GetFloat("U-svängarSväng- och hastighets- spak") + PlayerPrefs.GetFloat("PrecisionSväng- och hastighets- spak") + PlayerPrefs.GetFloat("UltimatSväng- och hastighets- spak")).ToString();

        enSpakRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakEn spak").ToString();
        enSpakKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigEn spak").ToString();
        enSpakSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpEn spak").ToString();
        enSpakUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarEn spak").ToString();
        enSpakPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionEn spak").ToString();
        enSpakUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatEn spak").ToString();
        enSpakTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakEn spak") + PlayerPrefs.GetFloat("KrokigEn spak") + PlayerPrefs.GetFloat("SkarpEn spak") + PlayerPrefs.GetFloat("U-svängarEn spak") + PlayerPrefs.GetFloat("PrecisionEn spak") + PlayerPrefs.GetFloat("UltimatEn spak")).ToString();

        musRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakMus").ToString();
        musKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigMus").ToString();
        musSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpMus").ToString();
        musUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarMus").ToString();
        musPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionMus").ToString();
        musUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatMus").ToString();
        musTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakMus") + PlayerPrefs.GetFloat("KrokigMus") + PlayerPrefs.GetFloat("SkarpMus") + PlayerPrefs.GetFloat("U-svängarMus") + PlayerPrefs.GetFloat("PrecisionMus") + PlayerPrefs.GetFloat("UltimatMus")).ToString();

        knappRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakKnapp- kontroll").ToString();
        knappKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigKnapp- kontroll").ToString();
        knappSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpKnapp- kontroll").ToString();
        knappUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarKnapp- kontroll").ToString();
        knappPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionKnapp- kontroll").ToString();
        knappUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatKnapp- kontroll").ToString();
        knappTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakKnapp- kontroll") + PlayerPrefs.GetFloat("KrokigKnapp- kontroll") + PlayerPrefs.GetFloat("SkarpKnapp- kontroll") + PlayerPrefs.GetFloat("U-svängarKnapp- kontroll") + PlayerPrefs.GetFloat("PrecisionKnapp- kontroll") + PlayerPrefs.GetFloat("UltimatKnapp- kontroll")).ToString();

        knappSpecRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakKnapp- kontroll special").ToString();
        knappSpecKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigKnapp- kontroll special").ToString();
        knappSpecSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpKnapp- kontroll special").ToString();
        knappSpecUSvängar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-svängarKnapp- kontroll special").ToString();
        knappSpecPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionKnapp- kontroll special").ToString();
        knappSpecUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatKnapp- kontroll special").ToString();
        knappSpecTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakKnapp- kontroll special") + PlayerPrefs.GetFloat("KrokigKnapp- kontroll special") + PlayerPrefs.GetFloat("SkarpKnapp- kontroll special") + PlayerPrefs.GetFloat("U-svängarKnapp- kontroll special") + PlayerPrefs.GetFloat("PrecisionKnapp- kontroll special") + PlayerPrefs.GetFloat("UltimatKnapp- kontroll special")).ToString();
    }
}
