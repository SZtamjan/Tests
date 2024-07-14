using System;
using System.Collections.Generic;
using UnityEngine;

namespace CustomEvents
{
    [Serializable]
    public class LayZEvents
    {
        public delegate void Method();

        public List<Method> listeners = new List<Method>();

        public void AddListener(Method newMethod)
        {
            listeners.Add(newMethod);
        }

        public void InvokeEvent()
        {
            foreach (var method in listeners)
            {
                method();
            }
        }
    }
}