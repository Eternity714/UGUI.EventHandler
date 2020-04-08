using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerDownHandler : MonoBehaviour, IPointerDownHandler
{
    public Action<GameObject, PointerEventData> onPointerDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        onPointerDown?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onPointerDown = null;
    }

    public static PointerDownHandler Get(GameObject go)
    {
        PointerDownHandler handler = go.GetComponent<PointerDownHandler>();
        if (handler == null) handler = go.AddComponent<PointerDownHandler>();
        return handler;
    }

}
