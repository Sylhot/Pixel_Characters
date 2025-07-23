using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

[CreateAssetMenu(fileName = "LightningWizard_E", menuName = "Skill/LightningWizard_E")]
public class LightningWizard_E : SkillBase
{
    GameObject skillInstance;
    public override void SpawnSkill(Vector3 mousePosition, Quaternion skillRotation, Vector3 characterPosition)
    {
        skillInstance = Instantiate(skillObejct, mousePosition, skillRotation);
        skillInstance.GetComponent<SkillSoundPlayer>()?.PlaySound(skillSound);
        Destroy(skillInstance, destroyerTime);
        Debug.Log("LightningWizard_E scripti calisti");
    }
}

