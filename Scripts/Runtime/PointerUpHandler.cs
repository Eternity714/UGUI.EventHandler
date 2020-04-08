using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerUpHandler : MonoBehaviour, IPointerUpHandler
{
    public Action<GameObject, PointerEventData> onPointerUp;

    public void OnPointerUp(PointerEventData eventData)
    {
        onPointerUp?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onPointerUp = null;
    }

    public static PointerUpHandler Get(GameObject go)
    {
        PointerUpHandler handler = go.GetComponent<PointerUpHandler>();
        if (handler == null) handler = go.AddComponent<PointerUpHandler>();
        return handler;
    }

}
