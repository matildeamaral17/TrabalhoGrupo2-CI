using UnityEngine;
using UnityEngine.SceneManagement;

public class MudarCenaSimples : MonoBehaviour
{
    // Adicionamos esta linha para poderes escrever o nome da cena no Inspector
    public string nomeDaCena;

    public void IrParaProximaCena()
    {
        if (!string.IsNullOrEmpty(nomeDaCena))
        {
            SceneManager.LoadScene(nomeDaCena);
            Debug.Log("A mudar para: " + nomeDaCena);
        }
        else
        {
            Debug.LogError("Erro: O nome da cena não foi definido no Inspector!");
        }
    }
}