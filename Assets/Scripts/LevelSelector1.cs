using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector1 : MonoBehaviour
{
    private static int _selectedLevel = 0;

    public void SelectLevel(int level)
    {
        _selectedLevel = level;
        Debug.Log("Nível selecionado: " + level);
    }

    public void Play()
    {
        if (_selectedLevel == 1)
            SceneManager.LoadScene("Jogo0");

        else if (_selectedLevel == 2)
            SceneManager.LoadScene("Jogo1");

        else if (_selectedLevel == 3)
            SceneManager.LoadScene("Jogo2");
    }

    public static int GetSelectedLevel()
    {
        return _selectedLevel;
    }
}