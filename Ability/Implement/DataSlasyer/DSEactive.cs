using UnityEngine;
using static AbilityEnum;

[CreateAssetMenu(menuName = "Ability/DataSlasyer/E")]
public class DSEactive : SyncAbilityBase
{
    // 스킬 시전
    public override void Cast()
    {
        // 스킬 풀링
        instantAbility = AbilityPool.instance.GetPool(AbilityPool.instance.queMap, AbilityType.DSE);
        instantAbility.transform.position = GameObject.Find("Player").transform.position + new Vector3(0, 0, 5f);

        // 사운드 풀링
        AbilitySound.instance.SkillSfxPlay(AbilitySoundType.DSE1);
    }

    // 스킬 종료
    public override void CastEnd() { AbilityPool.instance.ReturnPool(AbilityPool.instance.queMap, instantAbility, AbilityType.DSE); }
}
