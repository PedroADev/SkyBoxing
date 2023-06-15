using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
 
    public void iniciar()
    {
        SceneManager.LoadScene("teste");
    }


    public void sair()
    {
        Application.Quit();
    }
}
