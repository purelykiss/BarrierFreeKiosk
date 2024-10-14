using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(EventSystem))]
public class AutoClick : MonoBehaviour
{
    EventSystem eventSystem;

    private void Awake()
    {
        eventSystem = GetComponent<EventSystem>();
        StartCoroutine(RightClick());
    }

    public void Move(MoveDirection direction)
    {
        AxisEventData data = new AxisEventData(EventSystem.current);

        data.moveDir = direction;

        data.selectedObject = EventSystem.current.currentSelectedGameObject;

        ExecuteEvents.Execute(data.selectedObject, data, ExecuteEvents.moveHandler);
    }

    public void Select()
    {
        ExecuteEvents.Execute(new PointerEventData(EventSystem.current).selectedObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerClickHandler);
    }

    IEnumerator RightClick()
    {
        while (true)
        {
            Move(MoveDirection.Right);
            yield return new WaitForSeconds(1);
            Select();
            yield return new WaitForSeconds(1);
        }
    }
}