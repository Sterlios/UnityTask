using UnityEngine;

public class Rotatable : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _direction;

    private void Start() => 
        _direction = _direction.normalized;

    private void Update() => 
        transform.Rotate(_speed * Time.deltaTime * _direction);
}
