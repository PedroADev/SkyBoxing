using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons_end : MonoBehaviour
{
    public void reiniciar()
    {
        SceneManager.LoadScene("teste");
    }

    public void quit()
    {
        Application.Quit();
    }
}
