using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizPerguntas : MonoBehaviour
{
    public string proximaCena; // Nome da cena para carregar

    public void RespostaCorreta()
    {
        Debug.Log("Resposta Correta! Avançando para a próxima cena...");

        // Carrega a próxima cena diretamente
        if (!string.IsNullOrEmpty(proximaCena))
        {
            SceneManager.LoadScene(proximaCena);
        }
        else
        {
            Debug.LogWarning("O nome da 'Proxima Cena' não foi definido no Inspector!");
        }
    }

    public void RespostaErrada()
    {
        Debug.Log("Resposta Errada!");
    }
}