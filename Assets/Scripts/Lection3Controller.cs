using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
    [SerializeField] private List<int> list; 
    [SerializeField] private int element; 

    [ContextMenu("Print List")]
    public void PrintList()
    {
        string result = string.Join(", ", list);
        Debug.Log("List: " + result);
    }

    [ContextMenu("Add Element")]
    public void AddElement()
    {
        list.Add(element);
        Debug.Log($"Added: {element}");
    }

    [ContextMenu("Remove Element")]
    public void RemoveElement()
    {
        if (list.Contains(element))
        {
            list.Remove(element);
            Debug.Log($"Removed: {element}");
        }
        else
        {
            Debug.Log($"Element {element} not found in the list");
        }
    }

    [ContextMenu("Clear List")]
    public void ClearList()
    {
        list.Clear();
        Debug.Log("List Cleared");
    }

    [ContextMenu("Sort List")]
    public void SortList()
    {
        list.Sort();
        Debug.Log("List Sorted");
    }
}
