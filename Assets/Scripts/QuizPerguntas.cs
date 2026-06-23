using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizPerguntas : MonoBehaviour
{
    public static int perguntasRespondidas = 0;
    public int totalPerguntas = 4;

    public string proximaCena;
    public string cenaFinal = "FinalQuiz";

    public void RespostaCorreta()
    {
        perguntasRespondidas++;

        if (perguntasRespondidas >= totalPerguntas)
        {
            perguntasRespondidas = 0;
            SceneManager.LoadScene(cenaFinal);
        }
        else
        {
            SceneManager.LoadScene(proximaCena);
        }
    }

    public void RespostaErrada()
    {
        // Se quiseres contar também as erradas como pergunta respondida:
        perguntasRespondidas++;

        if (perguntasRespondidas >= totalPerguntas)
        {
            perguntasRespondidas = 0;
            SceneManager.LoadScene(cenaFinal);
        }
        else
        {
            SceneManager.LoadScene(proximaCena);
        }
    }
}