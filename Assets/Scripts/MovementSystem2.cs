using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem2 : MonoBehaviour
{
    //Observer

    private void Start() 
    {
        //sen bir observersýn ve movementpanel2 nin onforwardbuttonclicked hareketini dinle

        MovementPanel2.OnForwardButtonClicked += MoveForward;
    }
    public void MoveForward() => transform.Translate(Vector3.forward);
    public void MoveBack() => transform.Translate(Vector3.back);
    public void MoveRight() => transform.Translate(Vector3.right);
    public void MoveLeft() => transform.Translate(Vector3.left);
}
