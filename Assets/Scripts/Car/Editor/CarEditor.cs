using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Car))]
public class CarEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();
        Car myTarget = (Car)target;
        myTarget.speed = EditorGUILayout.IntField("Minha velocidade", myTarget.speed);
        myTarget.gear = EditorGUILayout.IntField("Marcha", myTarget.gear);
        myTarget.carPrefab = (GameObject)EditorGUILayout.ObjectField(myTarget.carPrefab, typeof(GameObject), true);

        EditorGUILayout.LabelField("Velocidade total", myTarget.TotalSpeed.ToString());

        EditorGUILayout.HelpBox("Calcule a velocidade total do carro", MessageType.Info);

        if (myTarget.TotalSpeed >= 200)
        {
            EditorGUILayout.HelpBox("Velocidade maior que permitido", MessageType.Error);
        }

        GUI.color = Color.yellow;
        if (GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }

        GUI.color = Color.black;
        if (GUILayout.Button("Create Car"))
        {
            myTarget.CreateCar();
        }
    }
}
