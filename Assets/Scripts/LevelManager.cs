using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
    private static int _selectedLevel = 0;

    public static void LoadLevel(int level)
    {
        _selectedLevel = level;
        SceneManager.LoadScene("RodadosAlimentosJogo" + level);
    }

    public static int GetSelectedLevel()
    {
        return _selectedLevel;
    }
}