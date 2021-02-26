using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Slot : MonoBehaviour, IDropHandler
{
    
    [SerializeField] private RectTransform _transform;


    public void OnDrop(PointerEventData eventData)
    {
        eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = _transform.anchoredPosition;
    }
    
}
