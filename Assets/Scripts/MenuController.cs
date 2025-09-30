using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void jugar()
    {
        SceneManager.LoadScene("escenaMinigame");
    }

    public void salir()
    {
        Application.Quit();
        Debug.Log("Cerrando juego");
    }
}
