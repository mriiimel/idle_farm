

using UnityEngine;

public interface IPlayer 
{
    public float PlayerSpeed { get; }
    public Collider PlayerCollider { get; }

    public Rigidbody PlayerRB { get; }
}
