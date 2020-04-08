using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerEnterHandler : MonoBehaviour, IPointerEnterHandler
{
    public Action<GameObject, PointerEventData> onPointerEnter;

    public void OnPointerEnter(PointerEventData eventData)
    {
        onPointerEnter?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onPointerEnter = null;
    }

    public static PointerEnterHandler Get(GameObject go)
    {
        PointerEnterHandler handler = go.GetComponent<PointerEnterHandler>();
        if (handler == null) handler = go.AddComponent<PointerEnterHandler>();
        return handler;
    }

}
