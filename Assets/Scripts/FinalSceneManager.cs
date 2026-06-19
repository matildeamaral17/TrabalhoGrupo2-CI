using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalSceneManager : MonoBehaviour
{
    public void Repetir()
    {
        SceneManager.LoadScene("RodadosAlimentosJogo" + GetUltimoNivel());
    }

    public void Sair()
    {
        SceneManager.LoadScene("MainMenu");
    }

    private int GetUltimoNivel()
    {
        // Vamos buscar o nível que foi jogado, guardado no LevelSelector
        return LevelSelector.GetSelectedLevel();
    }
}