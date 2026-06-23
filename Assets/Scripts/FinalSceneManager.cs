using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneManager : MonoBehaviour
{
    public void Repetir()
    {
        GameManager.Reset();
        SceneManager.LoadScene("RodadosAlimentosJogo0");
    }

    public void Sair()
    {
        SceneManager.LoadScene("MainMenu");
    }
}