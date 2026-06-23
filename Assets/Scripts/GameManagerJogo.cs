using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerJogo : MonoBehaviour
{
    public int totalAlimentos = 6;
    private int alimentosCertos = 0;

    public void ContarAlimentoCerto()
    {
        alimentosCertos++;

        if (alimentosCertos >= totalAlimentos)
        {
            SceneManager.LoadScene("Finalscene");
        }
    }
}