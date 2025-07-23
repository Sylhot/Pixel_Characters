using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharacterSkillUse : MonoBehaviour
{
    public SkillBase skill_Q;
    public SkillBase skill_E;
    public SkillBase skill_F;
    public SkillBase skill_R;
    [SerializeField] private Vector3 mousePosition;
    [SerializeField] private Vector3 characterPosition;

    void Update()
    {
        mousePosition = Input.mousePosition;
        characterPosition = transform.position;
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldPosition.z = 0f;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            skill_Q.SpawnSkill(worldPosition,this.transform.rotation,characterPosition);
            Debug.Log(skill_Q.skillName);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            skill_E.SpawnSkill(worldPosition,this.transform.rotation,characterPosition);
            Debug.Log(skill_E.skillName);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            skill_F.SpawnSkill(worldPosition,this.transform.rotation,characterPosition);
            Debug.Log(skill_F.skillName);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            skill_R.SpawnSkill(worldPosition,this.transform.rotation,characterPosition);
            Debug.Log(skill_R.skillName);
        }
    }
}
