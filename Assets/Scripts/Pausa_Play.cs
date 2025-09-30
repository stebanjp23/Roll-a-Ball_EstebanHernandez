using UnityEngine;
using TMPro;


public class Pausa_Play : MonoBehaviour
{
    public GameObject WinText; //Texto "ganaste"

    public void pausa()
    {
        Time.timeScale = 0.0f;
        WinText.gameObject.SetActive(true);
        WinText.GetComponent<TextMeshProUGUI>().text = "PAUSADO";
    }

    public void reanudar()
    {
        Time.timeScale = 1.0f;
    }

}
