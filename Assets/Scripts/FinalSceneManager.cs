using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneManager : MonoBehaviour
{
    public void Repetir()
    {
        int nivel = LevelSelector1.GetSelectedLevel();

        if (nivel == 1)
            SceneManager.LoadScene("Jogo0");
        else if (nivel == 2)
            SceneManager.LoadScene("Jogo1");
        else if (nivel == 3)
            SceneManager.LoadScene("Jogo2");
    }

    public void Sair()
    {
        SceneManager.LoadScene("MainMenu");
    }
}