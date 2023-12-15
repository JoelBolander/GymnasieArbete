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
    [SerializeField] private GameObject wasdUSv�ngar;
    [SerializeField] private GameObject wasdPrecision;
    [SerializeField] private GameObject wasdUltimat;
    [SerializeField] private GameObject wasdTotal;

    [Header("Diff Tang")]
    [SerializeField] private GameObject diffTangRak;
    [SerializeField] private GameObject diffTangKrok;
    [SerializeField] private GameObject diffTangSkarp;
    [SerializeField] private GameObject diffTangUSv�ngar;
    [SerializeField] private GameObject diffTangPrecision;
    [SerializeField] private GameObject diffTangUltimat;
    [SerializeField] private GameObject diffTangTotal;

    [Header("Diff Kontroll")]
    [SerializeField] private GameObject diffKontRak;
    [SerializeField] private GameObject diffKontKrok;
    [SerializeField] private GameObject diffKontSkarp;
    [SerializeField] private GameObject diffKontUSv�ngar;
    [SerializeField] private GameObject diffKontPrecision;
    [SerializeField] private GameObject diffKontUltimat;
    [SerializeField] private GameObject diffKontTotal;

    [Header("Sv�ng och Hastighet")]
    [SerializeField] private GameObject sv�ngHastighetRak;
    [SerializeField] private GameObject sv�ngHastighetKrok;
    [SerializeField] private GameObject sv�ngHastighetSkarp;
    [SerializeField] private GameObject sv�ngHastighetUSv�ngar;
    [SerializeField] private GameObject sv�ngHastighetPrecision;
    [SerializeField] private GameObject sv�ngHastighetUltimat;
    [SerializeField] private GameObject sv�ngHastighetTotal;

    [Header("En Spak")]
    [SerializeField] private GameObject enSpakRak;
    [SerializeField] private GameObject enSpakKrok;
    [SerializeField] private GameObject enSpakSkarp;
    [SerializeField] private GameObject enSpakUSv�ngar;
    [SerializeField] private GameObject enSpakPrecision;
    [SerializeField] private GameObject enSpakUltimat;
    [SerializeField] private GameObject enSpakTotal;

    [Header("Mus")]
    [SerializeField] private GameObject musRak;
    [SerializeField] private GameObject musKrok;
    [SerializeField] private GameObject musSkarp;
    [SerializeField] private GameObject musUSv�ngar;
    [SerializeField] private GameObject musPrecision;
    [SerializeField] private GameObject musUltimat;
    [SerializeField] private GameObject musTotal;

    [Header("Knappkontroll")]
    [SerializeField] private GameObject knappRak;
    [SerializeField] private GameObject knappKrok;
    [SerializeField] private GameObject knappSkarp;
    [SerializeField] private GameObject knappUSv�ngar;
    [SerializeField] private GameObject knappPrecision;
    [SerializeField] private GameObject knappUltimat;
    [SerializeField] private GameObject knappTotal;

    [Header("Knappkontroll Special")]
    [SerializeField] private GameObject knappSpecRak;
    [SerializeField] private GameObject knappSpecKrok;
    [SerializeField] private GameObject knappSpecSkarp;
    [SerializeField] private GameObject knappSpecUSv�ngar;
    [SerializeField] private GameObject knappSpecPrecision;
    [SerializeField] private GameObject knappSpecUltimat;
    [SerializeField] private GameObject knappSpecTotal;

    void Start()
    {
        wasdRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakWASD").ToString();
        wasdKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigWASD").ToString();
        wasdSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpWASD").ToString();
        wasdUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarWASD").ToString();
        wasdPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionWASD").ToString();
        wasdUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatWASD").ToString();
        wasdTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakWASD")+PlayerPrefs.GetFloat("KrokigWASD")+PlayerPrefs.GetFloat("SkarpWASD")+PlayerPrefs.GetFloat("U-sv�ngarWASD")+PlayerPrefs.GetFloat("PrecisionWASD")+PlayerPrefs.GetFloat("UltimatWASD")).ToString();

        diffTangRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakDifferential Tangentbord").ToString();
        diffTangKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigDifferential Tangentbord").ToString();
        diffTangSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpDifferential Tangentbord").ToString();
        diffTangUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarDifferential Tangentbord").ToString();
        diffTangPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionDifferential Tangentbord").ToString();
        diffTangUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatDifferential Tangentbord").ToString();
        diffTangTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakDifferential Tangentbord") + PlayerPrefs.GetFloat("KrokigDifferential Tangentbord") + PlayerPrefs.GetFloat("SkarpDifferential Tangentbord") + PlayerPrefs.GetFloat("U-sv�ngarDifferential Tangentbord") + PlayerPrefs.GetFloat("PrecisionDifferential Tangentbord") + PlayerPrefs.GetFloat("UltimatDifferential Tangentbord")).ToString();

        diffKontRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakDifferential Kontroll").ToString();
        diffKontKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigDifferential Kontroll").ToString();
        diffKontSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpDifferential Kontroll").ToString();
        diffKontUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarDifferential Kontroll").ToString();
        diffKontPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionDifferential Kontroll").ToString();
        diffKontUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatDifferential Kontroll").ToString();
        diffKontTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakDifferential Kontroll") + PlayerPrefs.GetFloat("KrokigDifferential Kontroll") + PlayerPrefs.GetFloat("SkarpDifferential Kontroll") + PlayerPrefs.GetFloat("U-sv�ngarDifferential Kontroll") + PlayerPrefs.GetFloat("PrecisionDifferential Kontroll") + PlayerPrefs.GetFloat("UltimatDifferential Kontroll")).ToString();

        sv�ngHastighetRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakSv�ng- och hastighets- spak").ToString();
        sv�ngHastighetKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigSv�ng- och hastighets- spak").ToString();
        sv�ngHastighetSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpSv�ng- och hastighets- spak").ToString();
        sv�ngHastighetUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarSv�ng- och hastighets- spak").ToString();
        sv�ngHastighetPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionSv�ng- och hastighets- spak").ToString();
        sv�ngHastighetUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatSv�ng- och hastighets- spak").ToString();
        sv�ngHastighetTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakSv�ng- och hastighets- spak") + PlayerPrefs.GetFloat("KrokigSv�ng- och hastighets- spak") + PlayerPrefs.GetFloat("SkarpSv�ng- och hastighets- spak") + PlayerPrefs.GetFloat("U-sv�ngarSv�ng- och hastighets- spak") + PlayerPrefs.GetFloat("PrecisionSv�ng- och hastighets- spak") + PlayerPrefs.GetFloat("UltimatSv�ng- och hastighets- spak")).ToString();

        enSpakRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakEn spak").ToString();
        enSpakKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigEn spak").ToString();
        enSpakSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpEn spak").ToString();
        enSpakUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarEn spak").ToString();
        enSpakPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionEn spak").ToString();
        enSpakUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatEn spak").ToString();
        enSpakTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakEn spak") + PlayerPrefs.GetFloat("KrokigEn spak") + PlayerPrefs.GetFloat("SkarpEn spak") + PlayerPrefs.GetFloat("U-sv�ngarEn spak") + PlayerPrefs.GetFloat("PrecisionEn spak") + PlayerPrefs.GetFloat("UltimatEn spak")).ToString();

        musRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakMus").ToString();
        musKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigMus").ToString();
        musSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpMus").ToString();
        musUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarMus").ToString();
        musPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionMus").ToString();
        musUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatMus").ToString();
        musTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakMus") + PlayerPrefs.GetFloat("KrokigMus") + PlayerPrefs.GetFloat("SkarpMus") + PlayerPrefs.GetFloat("U-sv�ngarMus") + PlayerPrefs.GetFloat("PrecisionMus") + PlayerPrefs.GetFloat("UltimatMus")).ToString();

        knappRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakKnapp- kontroll").ToString();
        knappKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigKnapp- kontroll").ToString();
        knappSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpKnapp- kontroll").ToString();
        knappUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarKnapp- kontroll").ToString();
        knappPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionKnapp- kontroll").ToString();
        knappUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatKnapp- kontroll").ToString();
        knappTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakKnapp- kontroll") + PlayerPrefs.GetFloat("KrokigKnapp- kontroll") + PlayerPrefs.GetFloat("SkarpKnapp- kontroll") + PlayerPrefs.GetFloat("U-sv�ngarKnapp- kontroll") + PlayerPrefs.GetFloat("PrecisionKnapp- kontroll") + PlayerPrefs.GetFloat("UltimatKnapp- kontroll")).ToString();

        knappSpecRak.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("RakKnapp- kontroll special").ToString();
        knappSpecKrok.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("KrokigKnapp- kontroll special").ToString();
        knappSpecSkarp.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("SkarpKnapp- kontroll special").ToString();
        knappSpecUSv�ngar.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("U-sv�ngarKnapp- kontroll special").ToString();
        knappSpecPrecision.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("PrecisionKnapp- kontroll special").ToString();
        knappSpecUltimat.GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetFloat("UltimatKnapp- kontroll special").ToString();
        knappSpecTotal.GetComponent<TextMeshProUGUI>().text = (PlayerPrefs.GetFloat("RakKnapp- kontroll special") + PlayerPrefs.GetFloat("KrokigKnapp- kontroll special") + PlayerPrefs.GetFloat("SkarpKnapp- kontroll special") + PlayerPrefs.GetFloat("U-sv�ngarKnapp- kontroll special") + PlayerPrefs.GetFloat("PrecisionKnapp- kontroll special") + PlayerPrefs.GetFloat("UltimatKnapp- kontroll special")).ToString();
    }
}
