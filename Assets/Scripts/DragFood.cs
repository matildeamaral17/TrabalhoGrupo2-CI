using UnityEngine;
using UnityEngine.EventSystems;

public class DragFood : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public string tipoAlimento;

    private Transform parentInicial;
    private Vector3 posicaoInicial;
    private CanvasGroup canvasGroup;
    private Canvas canvas;

    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        parentInicial = transform.parent;
        posicaoInicial = transform.position;
        canvas = GetComponentInParent<Canvas>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentInicial = transform.parent;
        posicaoInicial = transform.position;

        transform.SetParent(canvas.transform);
        transform.SetAsLastSibling();

        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
    }

    public void VoltarInicio()
    {
        transform.SetParent(parentInicial);
        transform.position = posicaoInicial;
        transform.SetAsLastSibling();
    }

    public void ColocarCorretamente(Transform novoPai)
    {
        transform.SetParent(novoPai);
        transform.SetAsLastSibling();
    }
}