using UnityEngine;
using UnityEngine.EventSystems;

public class DragFood : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public string tipoAlimento; // Saudavel ou NaoSaudavel

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private Vector2 posicaoInicial;
    private Transform paiInicial;
    private bool colocadoCorretamente = false;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();

        if (canvasGroup == null)
        {
            canvasGroup = gameObject.AddComponent<CanvasGroup>();
        }
    }

    void Start()
    {
        posicaoInicial = rectTransform.anchoredPosition;
        paiInicial = transform.parent;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (colocadoCorretamente) return;

        canvasGroup.blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (colocadoCorretamente) return;

        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (colocadoCorretamente) return;

        canvasGroup.blocksRaycasts = true;

        VoltarInicio();
    }

    public void ColocarCorretamente(Transform caixa)
    {
        colocadoCorretamente = true;
        canvasGroup.blocksRaycasts = true;

        transform.SetParent(caixa);
        rectTransform.anchoredPosition = Vector2.zero;
    }

    public void VoltarInicio()
    {
        transform.SetParent(paiInicial);
        rectTransform.anchoredPosition = posicaoInicial;
    }
}