using UnityEngine;
using UnityEngine.SceneManagement;

public class EscolhaNivel : MonoBehaviour
{
    private string nivelSelecionado;

    // Botão Fácil
    public void SelecionarFacil()
    {
        nivelSelecionado = "Jogo-Fácil";
        Debug.Log("Nível Fácil selecionado");
    }

    // Botão Médio
    public void SelecionarMedio()
    {
        nivelSelecionado = "Jogo-Médio";
        Debug.Log("Nível Médio selecionado");
    }

    // Botão Difícil
    public void SelecionarDificil()
    {
        nivelSelecionado = "Jogo-Difícil";
        Debug.Log("Nível Difícil selecionado");
    }

    // Botão Jogar
    public void Jogar()
    {
        if (!string.IsNullOrEmpty(nivelSelecionado))
        {
            SceneManager.LoadScene(nivelSelecionado);
        }
        else
        {
            Debug.Log("Escolhe primeiro um nível!");
        }
    }
}