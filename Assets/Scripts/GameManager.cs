using UnityEngine.SceneManagement;

public static class GameManager
{
    private static int _rightAnswers = 0;
    private static int _wrongAnswers = 0;
    private static int _currentLevel = 0; // 0 = fácil, 1 = médio, 2 = difícil

    private static string[] _levelScenes = { "RodadosAlimentosJogo0", "RodadosAlimentosJogo1", "RodadosAlimentosJogo2" };
    private static string _finalScene = "FinalSceneRoda";
    private static int _piecesPerLevel = 6; // fatias por nível

    public static void IncrementRightAnswer()
    {
        _rightAnswers++;

        if (_rightAnswers == _piecesPerLevel)
        {
            _rightAnswers = 0; // reset para o próximo nível
            _currentLevel++;

            if (_currentLevel >= _levelScenes.Length)
            {
                SceneManager.LoadScene(_finalScene);
            }
            else
            {
                SceneManager.LoadScene(_levelScenes[_currentLevel]);
            }
        }
    }

    public static void IncrementWrongAnswer() { _wrongAnswers++; }
    public static int GetRightAnswer() { return _rightAnswers; }
    public static int GetWrongAnswer() { return _wrongAnswers; }
    public static int GetCurrentLevel() { return _currentLevel; }

    public static void Reset()
    {
        _rightAnswers = 0;
        _wrongAnswers = 0;
        _currentLevel = 0;
    }
}