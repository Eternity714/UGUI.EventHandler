using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveHandler : MonoBehaviour, IMoveHandler
{
    public Action<GameObject, AxisEventData> onMove;

    public void OnMove(AxisEventData eventData)
    {
        onMove?.Invoke(gameObject, eventData);
    }

    void OnDestroy()
    {
        onMove = null;
    }

    public static MoveHandler Get(GameObject go)
    {
        MoveHandler handler = go.GetComponent<MoveHandler>();
        if (handler == null) handler = go.AddComponent<MoveHandler>();
        return handler;
    }
}
