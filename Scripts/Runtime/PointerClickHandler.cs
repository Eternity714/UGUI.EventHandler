using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerClickHandler : MonoBehaviour, IPointerClickHandler
{
    public Action<GameObject, PointerEventData> onPointerClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        onPointerClick?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onPointerClick = null;
    }

    public static PointerClickHandler Get(GameObject go)
    {
        PointerClickHandler handler = go.GetComponent<PointerClickHandler>();
        if (handler == null) handler = go.AddComponent<PointerClickHandler>();
        return handler;
    }
}
