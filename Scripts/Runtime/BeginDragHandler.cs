using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class BeginDragHandler : MonoBehaviour, IBeginDragHandler
{
    public Action<GameObject, PointerEventData> onBeginDrag;

    public void OnBeginDrag(PointerEventData eventData)
    {
        onBeginDrag?.Invoke(gameObject, eventData);
    }

    void OnDestroy() {
        onBeginDrag = null;
    }

    public static BeginDragHandler Get(GameObject go) {
        BeginDragHandler handler = go.GetComponent<BeginDragHandler>();
        if (handler == null) handler = go.AddComponent<BeginDragHandler>();
        return handler;
    }
}
