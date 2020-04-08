using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragHandler : MonoBehaviour, IDragHandler
{
    public Action<GameObject, PointerEventData> onDrag;

    public void OnDrag(PointerEventData eventData)
    {
        onDrag?.Invoke(gameObject, eventData);
    }

    void OnDestroy() {
        onDrag = null;
    }

    public static DragHandler Get(GameObject go) {
        DragHandler handler = go.GetComponent<DragHandler>();
        if (handler == null) handler = go.AddComponent<DragHandler>();
        return handler;
    }
}
