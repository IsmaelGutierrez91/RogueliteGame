using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public void AddSkill(SkillData skillData)
    {
        SkillBehaviour existing = GetComponentInChildren<SkillBehaviour>();
        SkillBehaviour[] all = GetComponents<SkillBehaviour>();

        foreach (var sb in all)
        {
            if (sb.name == skillData.skillName)
            {
                sb.LevelUp();
                return;
            }
        }

        SkillBehaviour newSkill = gameObject.AddComponent<SkillBehaviour>();
        newSkill.name = skillData.skillName;
        newSkill.Init(skillData);
    }
}