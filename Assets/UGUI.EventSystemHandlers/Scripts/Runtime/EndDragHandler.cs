using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndDragHandler : MonoBehaviour, IEndDragHandler
{
    public Action<GameObject, PointerEventData> onEndDrag;

    public void OnEndDrag(PointerEventData eventData)
    {
        onEndDrag?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onEndDrag = null;
    }

    public static EndDragHandler Get(GameObject go)
    {
        EndDragHandler handler = go.GetComponent<EndDragHandler>();
        if (handler == null) handler = go.AddComponent<EndDragHandler>();
        return handler;
    }
}
