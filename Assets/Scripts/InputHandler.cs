using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField]
    private float _moveDistance = 10f;

    [SerializeField]
    private GameObject _objectToMove;

    private MoveCommandReceiver _moveCommandReciever;
    private List<MoveCommand> _commands = new List<MoveCommand>();
    private int _currentCommandNum = 0;

    private void Start() => _moveCommandReciever = new MoveCommandReceiver();



    private void Move(MoveDirection direction)
    {
        MoveCommand moveCommand = new MoveCommand(direction, _moveCommandReciever, _moveDistance, _objectToMove);
        moveCommand.Move();
        _commands.Add(moveCommand);
        _currentCommandNum++;
    }



    public void MoveUp() { Move(MoveDirection.UP); }
    public void MoveDown() { Move(MoveDirection.DOWN); }
    public void MoveLeft() { Move(MoveDirection.LEFT); }
    public void MoveRight() { Move(MoveDirection.RIGHT); }
}
