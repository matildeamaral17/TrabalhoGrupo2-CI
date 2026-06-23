    using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    private static int _selectedLevel = 0;

    public void SelectLevel(int level)
    {
        _selectedLevel = level;
        Debug.Log("Nível selecionado: " + level);
    }

    public void Play()
    {
        SceneManager.LoadScene("RodadosAlimentosJogo" + _selectedLevel);
    }
    public static int GetSelectedLevel()
{
    return _selectedLevel;
}
}