using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorQuiz : MonoBehaviour
{
    private static int selectedLevel = 0;

    public void SelectLevel(int level)
    {
        selectedLevel = level;
        Debug.Log("Nível do quiz selecionado: " + level);
    }

    public void Play()
    {
        if (selectedLevel == 1)
            SceneManager.LoadScene("Quiz0");

        else if (selectedLevel == 2)
            SceneManager.LoadScene("Quiz1");

        else if (selectedLevel == 3)
            SceneManager.LoadScene("Quiz2");

        else
            Debug.Log("Escolhe primeiro um nível!");
    }

    public static int GetSelectedLevel()
    {
        return selectedLevel;
    }
}
