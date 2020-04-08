using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InitializePotentialDragHandler : MonoBehaviour, IInitializePotentialDragHandler
{
    public Action<GameObject, PointerEventData> onInitializePotentialDrag;

    public void OnInitializePotentialDrag(PointerEventData eventData)
    {
        onInitializePotentialDrag?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onInitializePotentialDrag = null;
    }

    public static InitializePotentialDragHandler Get(GameObject go)
    {
        InitializePotentialDragHandler handler = go.GetComponent<InitializePotentialDragHandler>();
        if (handler == null) handler = go.AddComponent<InitializePotentialDragHandler>();
        return handler;
    }
}
