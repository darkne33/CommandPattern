using System;
using UnityEngine;

public class MoveCommandReceiver
{
    public void MoveOperation(GameObject moveGameObject, MoveDirection direction, float distance)
    {
        switch (direction)
        {
            case MoveDirection.UP:
                MoveY(moveGameObject, distance);
                break;
            case MoveDirection.DOWN:
                MoveY(moveGameObject, -distance);
                break;
            case MoveDirection.RIGHT:
                MoveX(moveGameObject, distance);
                break;
            case MoveDirection.LEFT:
                MoveX(moveGameObject, -distance);
                break;
        }
    }

    public MoveDirection? InverseDirection(MoveDirection direction)
    {
        switch (direction)
        {
            case MoveDirection.UP:
                return MoveDirection.DOWN;
            case MoveDirection.DOWN:
                return MoveDirection.UP;
            case MoveDirection.LEFT:
                return MoveDirection.RIGHT;
            case MoveDirection.RIGHT:
                return MoveDirection.LEFT;
            default:
                return null;
        }
    }


    public void MoveY(GameObject moveGameObject, float distance)
    {
        Vector3 newPos = moveGameObject.transform.position;
        newPos.y += distance;
        moveGameObject.transform.position = newPos;
    }


    public void MoveX(GameObject moveGameObject, float distance)
    {
        Vector3 newPos = moveGameObject.transform.position;
        newPos.x += distance;
        moveGameObject.transform.position = newPos;
    }
}