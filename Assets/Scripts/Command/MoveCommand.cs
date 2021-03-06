using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCommand : ICommand
{
    private MoveDirection _direction;
    private MoveCommandReceiver _moveReceiver;
    private float _distance;
    private GameObject _moveObj;

    public MoveCommand(MoveDirection direction, MoveCommandReceiver moveReceiver, float distance, GameObject moveObj)
    {
        this._direction = direction;
        this._moveReceiver = moveReceiver;
        this._distance = distance;
        this._moveObj = moveObj;
    }


    public void Move()
    {
        _moveReceiver.MoveOperation(_moveObj, _direction, _distance);
    }

    public void CancelMove()
    {
        _moveReceiver.MoveOperation(_moveObj, (MoveDirection)_moveReceiver.InverseDirection(_direction), _distance);
    }
}