
using UnityEngine;
using UnityEngine.EventSystems;

public class DropBox : MonoBehaviour, IDropHandler
{
    public string tipoAceite; // Alimentos Saudáveis ou Alimentos Não Saudáveis

    public AudioSource audioSource;
    public AudioClip somCerto;
    public AudioClip somErrado;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject objetoArrastado = eventData.pointerDrag;

        if (objetoArrastado == null) return;

        DragFood alimento = objetoArrastado.GetComponent<DragFood>();

        if (alimento == null) return;

        if (alimento.tipoAlimento == tipoAceite)
        {
            alimento.ColocarCorretamente(transform);

            RectTransform rt = objetoArrastado.GetComponent<RectTransform>();
            RectTransform caixaRect = GetComponent<RectTransform>();

            float margem = 80f;

            float x = Random.Range(
                -caixaRect.rect.width / 2 + margem,
                 caixaRect.rect.width / 2 - margem);

            float y = Random.Range(
                -caixaRect.rect.height / 2 + margem,
                 caixaRect.rect.height / 2 - margem);

            rt.anchoredPosition = new Vector2(x, y);

            if (audioSource != null && somCerto != null)
                audioSource.PlayOneShot(somCerto);

            Debug.Log("Correto!");
        }
        else
        {
            alimento.VoltarInicio();

            if (audioSource != null && somErrado != null)
                audioSource.PlayOneShot(somErrado);

            Debug.Log("Errado!");
        }
    }
}