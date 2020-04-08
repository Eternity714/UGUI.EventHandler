using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropHandler : MonoBehaviour, IDropHandler
{
    public Action<GameObject, PointerEventData> onDrop;

    public void OnDrop(PointerEventData eventData)
    {
        onDrop?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onDrop = null;
    }

    public static DropHandler Get(GameObject go)
    {
        DropHandler handler = go.GetComponent<DropHandler>();
        if (handler == null) handler = go.AddComponent<DropHandler>();
        return handler;
    }
}
