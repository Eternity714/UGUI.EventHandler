using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PointerExitHandler : MonoBehaviour, IPointerExitHandler
{
    public Action<GameObject, PointerEventData> onPointerExit;

    public void OnPointerExit(PointerEventData eventData)
    {
        onPointerExit?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onPointerExit = null;
    }

    public static PointerExitHandler Get(GameObject go)
    {
        PointerExitHandler handler = go.GetComponent<PointerExitHandler>();
        if (handler == null) handler = go.AddComponent<PointerExitHandler>();
        return handler;
    }

}
