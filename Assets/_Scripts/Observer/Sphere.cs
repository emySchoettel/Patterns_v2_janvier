using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Sphere : MonoBehaviour
{
    #region Variables
    private Material material;
    private StateSphere state;

    public  StateSphere currentstate 
    {
        get { return state; }
    }
    public StateBleu stateBleu = new StateBleu(); 
    public StateRouge stateRouge = new StateRouge();
    public readonly StateVert stateVert = new StateVert();

    private List<Observer> observers; 

    #endregion

    #region Initialisation
    private void Awake() 
    {
        observers = new List<Observer>();
    }
    void Start()
    {
        material = GetComponent<Renderer>().material;
        TransitionToState(stateRouge);
    }

    private void Update() {
        state.Update(this);
    }

    #endregion

    public void TransitionToState(StateSphere stateS)
    {
        state = stateS;
        state.ChangeColor(this);
    }
    
    public Material getMaterial()
    {
        return material;
    }

    #region Observer
    public void Attach(Observer obs)
    {
        observers.Add(obs);
    }

    public void Detach(Observer obs)
    {
        observers.Remove(obs);
    }

    public void Notify(Observer obs)
    {
        foreach(Observer observer in observers)
        {
            observer.Notify(this);
        }
    }

    #endregion
}
