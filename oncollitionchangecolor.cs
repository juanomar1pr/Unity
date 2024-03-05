using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;



public class Codigo : MonoBehaviour
{
    private void  OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.black ; 
    }
}