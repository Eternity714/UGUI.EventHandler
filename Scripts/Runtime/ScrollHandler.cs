using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScrollHandler : MonoBehaviour, IScrollHandler
{
    public Action<GameObject, PointerEventData> onScroll;

    public void OnScroll(PointerEventData eventData)
    {
        onScroll?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onScroll = null;
    }

    public static ScrollHandler Get(GameObject go)
    {
        ScrollHandler handler = go.GetComponent<ScrollHandler>();
        if (handler == null) handler = go.AddComponent<ScrollHandler>();
        return handler;
    }

}
