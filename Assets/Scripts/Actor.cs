using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;


[RequireComponent(typeof(NavMeshAgent))]
public class Actor : Entity
{
    #region Entity
    public override void Select()
    {
        base.Select();
        GetComponentInChildren<Renderer>().material.color = Color.red;
    }


    public override void Deselect()
    {
        base.Deselect();
        GetComponentInChildren<Renderer>().material.color = Color.white;
    }
    #endregion

    #region Tasks
    [SerializeField] ActorTaskProvider TaskProvider;
    [SerializeField] ActorTask Task;
    [HideInInspector] [SerializeField] ActorCommand Command;


    public override void Process(TaskProvider taskProvider)
    {
        base.Process(taskProvider);

        ActorTaskProvider actorTaskProvider = taskProvider as ActorTaskProvider;
        if (actorTaskProvider != null)
            SetTaskProvider(actorTaskProvider);
    }


    public override void Process(Task task)
    {
        base.Process(task);

        ActorTask actorTask = task as ActorTask;
        if (actorTask != null)
            SetTask(actorTask);
    }


    public override void Process(Command command)
    {
        base.Process(command);

        ActorCommand actorCommand = command as ActorCommand;
        if (actorCommand != null)
            SetCommand(actorCommand);
    }


    public void SetTaskProvider(ActorTaskProvider taskProvider)
    {
        TaskProvider = taskProvider;
    }


    public void RemoveTaskProvider()
    {
        TaskProvider = null;
    }


    public void SetTask(ActorTask task)
    {
        Task = task;
    }


    public void RemoveTask()
    {
        Task = null;
    }


    public void SetCommand(ActorCommand command)
    {
        Command = command;
    }


    public void ExecuteCommand()
    {
        Command.Execute(this);
        Command = null;
    }


    private void TaskUpdate()
    {
        if (TaskProvider != null && Task == null)
            SetTask(TaskProvider.GetTask(this));

        if (Task != null && Command == null)
            SetCommand(Task.GetCommand(this));

        if (Command != null)
            ExecuteCommand();
    }
    #endregion

    #region NavMeshAgent
    private NavMeshAgent _navMeshAgent;


    public void MoveTo(Vector3 point, float distance = 0.0f)
    {
        _navMeshAgent.stoppingDistance = distance;
        _navMeshAgent.SetDestination(point);
    }


    public bool IsMoveCompleted()
    {
        return _navMeshAgent.remainingDistance < 0.1f;
    }
    #endregion

    #region MonoBehaviour
    protected override void OnValidate()
    {
        base.OnValidate();

        if (TaskProvider != null)
            TaskProvider = TaskProvider.ScriptClone();

        if (Task != null)
            Task = Task.ScriptClone();

        if (Command != null)
            Command = Command.ScriptClone();
    }


    protected override void Start()
    {
        base.Start();
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }


    protected override void Update()
    {
        base.Update();
        TaskUpdate();
    }
    #endregion
}