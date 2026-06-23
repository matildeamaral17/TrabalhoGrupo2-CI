using UnityEngine;

public class QuizManager : MonoBehaviour
{
    // Esta variável vai guardar a pontuação do jogador entre as cenas
    public static int pontuacaoTotal = 0;

    // Configurações gerais
    public int totalPerguntasPorNivel = 4;

    void Awake()
    {
        // Garante que este objeto não seja destruído ao mudar de cena
        // Isso é útil se você quiser que o quiz "lembre" da pontuação
        DontDestroyOnLoad(gameObject);
    }

    public void AdicionarPontos(int pontos)
    {
        pontuacaoTotal += pontos;
        Debug.Log("Pontuação Atual: " + pontuacaoTotal);
    }
}