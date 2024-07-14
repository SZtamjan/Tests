using UnityEngine;
using CustomEvents;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    private delegate void WriteOut(string text);

    private UnityEvent dwa = new UnityEvent();
    private LayZEvents lays = new LayZEvents();
    private void Start()
    {
        dwa.AddListener(() => DebugLog("nice"));
        dwa.Invoke();
     
        lays.AddListener(() => DebugLog("xd"));
        lays.InvokeEvent();
    }

    private void WriteMessage()
    {
        Debug.Log("The message has been written");
    }

    private void DebugLog(string value)
    {
        Debug.Log(value + " z delegata");
    }

    private void SetTextAndWrite(string text, WriteOut writeOut)
    {
        Debug.Log(text);
        writeOut(text);
    }
}