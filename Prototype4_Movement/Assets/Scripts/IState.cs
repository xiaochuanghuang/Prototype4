using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IState
{
    Move o_player;

    public IState(Move player)
    {
        o_player = player;
    }

    public abstract void update();
}
