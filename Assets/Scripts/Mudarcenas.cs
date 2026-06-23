using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCena : MonoBehaviour
{
    public void IrParaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    }

    public void Sair()
    {
        Application.Quit();
    }
}