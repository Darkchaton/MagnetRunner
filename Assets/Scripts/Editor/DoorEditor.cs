using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Door))]
public class DoorEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        Door door = (Door)target;
        door.doorType = (Door.ActivationType)EditorGUILayout.EnumPopup("Door type", door.doorType);
        EditorGUILayout.Space();
        switch (door.doorType) //only show field based on doorType
        {
            case Door.ActivationType.PressurePlate:
                door.id = EditorGUILayout.IntField("Id", door.id);
                break;
            case Door.ActivationType.Key:
                door.keyType = (Key.KeyType)EditorGUILayout.EnumPopup("Key type", door.keyType);
                break;
            case Door.ActivationType.TriggerArea:
                EditorGUILayout.BeginHorizontal();
                door.triggerArea = (Collider2D)EditorGUILayout.ObjectField(door.triggerArea, typeof(Collider2D), true);
                EditorGUILayout.EndHorizontal();
                break;
            case Door.ActivationType.Button:
                door.id = EditorGUILayout.IntField("Id", door.id);
                break;
            case Door.ActivationType.Lever:
                door.id = EditorGUILayout.IntField("Id", door.id);
                break;
            default:
                break;
        }
    }
}
