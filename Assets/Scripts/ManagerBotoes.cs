using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerBotoes : MonoBehaviour
{
    public void Btn_Sair()
    {
        Application.Quit();
    }

    public void Btn_Instrucoes(string instrucoes)
    {
        SceneManager.LoadScene(instrucoes);
    }

    public void Btn_Creditos(string creditos)
    {
        SceneManager.LoadScene(creditos);
    }

    public void Btn_C1(string c1)
    {
        SceneManager.LoadScene(c1);
    }

    public void Btn_C2(string c2)
    {
        SceneManager.LoadScene(c2);
    }

    public void Btn_C3(string c3)
    {
        SceneManager.LoadScene(c3);
    }

    public void VoltarMenu(string inicio)
    {
        SceneManager.LoadScene(inicio);
    }
}
