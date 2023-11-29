using System.Collections;
using UnityEngine;

public class Movable : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update() => 
        transform.position += transform.forward * Time.deltaTime;
}
