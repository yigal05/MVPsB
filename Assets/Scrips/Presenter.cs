using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class Presenter : MonoBehaviour
{
    // Start is called before the first frame update
    public Linterna linterna;

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        Button Bon = root.Q<Button>("Bon");
        Button Boff = root.Q<Button>("Boff");

        Bon.clicked += () => linterna.On(Bon, Boff);
        Boff.clicked += () => linterna.Off(Boff,Bon);
    }
    
}
