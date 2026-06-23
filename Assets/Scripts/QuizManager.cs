using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public int totalPerguntas;
    private int perguntasRespondidas = 0;

    public void ResponderPergunta()
    {
        perguntasRespondidas++;

        if (perguntasRespondidas >= totalPerguntas)
        {
            SceneManager.LoadScene("FinalQuiz");
        }
    }
}
