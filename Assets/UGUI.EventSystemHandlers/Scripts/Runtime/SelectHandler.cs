using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectHandler : MonoBehaviour, ISelectHandler
{
    public Action<GameObject, BaseEventData> onSelect;

    public void OnSelect(BaseEventData eventData)
    {
        onSelect?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onSelect = null;
    }

    public static SelectHandler Get(GameObject go)
    {
        SelectHandler handler = go.GetComponent<SelectHandler>();
        if (handler == null) handler = go.AddComponent<SelectHandler>();
        return handler;
    }

}
