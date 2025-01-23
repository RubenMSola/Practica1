using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemigo : MonoBehaviour
{
    public Transform PatrolRoute;
    public List<Transform> Locations;
    private int _locationIndex = 0;
    private NavMeshAgent _agent;

    public Transform Player;

    private int _lives = 3;
    private void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

        InitializePatrolRoute();
        MoveToNextPatrolLocation();
        Player = GameObject.Find("Personaje").transform;
    }
    public int EnemyLives
    {
        get { return _lives; }
        private set
        {
            _lives = value;
            if (_lives <= 0)
            {
                Destroy(this.gameObject);
                print("Enemy Down");
            }
        }
    }

        void Update()
    {
        if (_agent.remainingDistance < 0.2f && !_agent.pathPending)
        {
            MoveToNextPatrolLocation();
        } 
    }

    void InitializePatrolRoute()
    {
        foreach (Transform child in PatrolRoute)
        {
            Locations.Add(child);
        }
    }
    void MoveToNextPatrolLocation()
    {
        if (Locations.Count == 0)
            return;
        _agent.destination = Locations[_locationIndex].position;
        _locationIndex = (_locationIndex +1 ) % Locations.Count;
    }
    private void OnTriggerEnter(Collider other) //Creamos un metodo para que detecte la collision trigger de un objeto y si interactua con otro objeto "Personaje" que pase algo "lo muestre en la comsola"
    {
        if(other.name == "Personaje")
        {
            _agent.destination = Player.position;
            print("Personaje Detectado");
        }
    }

    private void OnTriggerExit(Collider other) // lo mismo que el codigo anterior pero al salir del trigger
    {
        if (other.name == "Personaje")
        {
            print("Personaje Salio");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Bala(Clone)")
        {
            EnemyLives -= 1;
            print("Muerto");
        }
    }
}
