using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    public int numberCheck;
    public string boxName { get; }
    public string boxColor { get; }

    [SerializeField]
    protected float m_speed = 1.0f;

    // ENCAPSULATION
    public float speed
    {
        get { return m_speed; }
        set
        {
            if (value > 0)
            {
                m_speed = value;
            }
            else
            {
                Debug.LogError("speed value should be higher than 0");
            }

        }
        

    }

    // POLYMORPHISM - DisplayText() method that will be overwritten in child classes
    public virtual void DisplayText()
    {
        Debug.Log("Base class method called");
      
    }

    private void OnMouseDown()
    {
        // ABSTRACTION to reuse
        DisplayText();
    }
}
