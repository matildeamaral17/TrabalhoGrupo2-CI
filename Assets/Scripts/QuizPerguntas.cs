using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizPerguntas : MonoBehaviour
{
    public string proximaCena; // Nome da próxima cena após o nível
    public GameObject popupFinal; // Arraste o seu painel de Pop-up para cá no Inspector
    public bool ehUltimaPergunta = false; // Marque esta caixa no Inspector se for a última pergunta

    public void RespostaCorreta()
    {
        if (ehUltimaPergunta)
        {
            // Ativa o Pop-up se for a última pergunta
            if (popupFinal != null)
            {
                popupFinal.SetActive(true);
            }
            Debug.Log("Quiz Fácil Finalizado!");
        }
        else
        {
            // Carrega a próxima cena normalmente
            SceneManager.LoadScene(proximaCena);
        }
    }

    public void RespostaErrada()
    {
        Debug.Log("Resposta Errada!");
    }
}