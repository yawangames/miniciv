using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Village : Neighborhood
{
    public int citizenCount = 1;

    public List<Citizen> citizens = new List<Citizen>();


    void Start()
    {
        for (int i = 0; i < citizenCount; i++)
            CreateCitizens();
    }

    void CreateCitizens()
    {
        Citizen newCitizen = Instantiate(citizenObject, transform.position, Quaternion.identity);
        citizens.Add(newCitizen);
    }
}
