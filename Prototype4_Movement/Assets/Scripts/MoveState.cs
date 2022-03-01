using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveState : IState
{
    public MoveState(Move player) : base (player)
    {

    }
    public override void update()
    {
        //bodyTransform.Translate(new Vector3(0, 0, 0.1f) * Time.deltaTime * walkSpeed * vert);
        //bodyTransform.Rotate(new Vector3(0, 0.0000000001f, 0), hor * rotateSpeed);

        //throw new System.NotImplementedException();
    }
}
