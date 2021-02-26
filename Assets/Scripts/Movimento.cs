using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Movimento : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private RectTransform _transform;
    [SerializeField] private Canvas _canvas;//PERMITE O OBJETO ACOMPANHAR O MOUSE PERFEITAMENTE
    [SerializeField] private CanvasGroup _canvasGroup;


    
    public void OnBeginDrag(PointerEventData eventData)//DETECTA QUANDO COMEÇA A ARRASTAR O MOUSE
    {
        Debug.Log("Inicio drag");
        _canvasGroup.blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)//DETECTA QUANDO TERMINA DE ARRASTAR O MOUSE
    {
        Debug.Log("fim drag");
        _canvasGroup.blocksRaycasts = true;
    }

    public void OnDrag(PointerEventData eventData)//DETECTA ENQUANTO O MOUSE É ARRASTADO
    {
        Debug.Log("arrastando");
        _transform.anchoredPosition += eventData.delta / _canvas.scaleFactor;//MOVIMENTA A ENGRENAGEM

    }

    public void OnPointerDown(PointerEventData pointerEventData)//DETECTA QUANDO O MOUSE É CLICADO
    {
        Debug.Log("Game Object Click in Progress");
    }

    public void OnDrop(PointerEventData eventData)
    {

    }
    
}
