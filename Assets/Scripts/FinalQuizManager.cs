using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalQuizManager : MonoBehaviour
{
    public void Repetir()
    {
        int nivel = LevelSelectorQuiz.GetSelectedLevel();

        if (nivel == 1)
            SceneManager.LoadScene("Quiz0");

        else if (nivel == 2)
            SceneManager.LoadScene("Quiz1");

        else if (nivel == 3)
            SceneManager.LoadScene("Quiz2");
    }

    public void Sair()
    {
        SceneManager.LoadScene("MenuJogarQuiz");
    }
}
