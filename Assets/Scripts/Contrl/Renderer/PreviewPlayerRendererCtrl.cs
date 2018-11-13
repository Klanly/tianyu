///////////////////////////////////////////////////////////////////////////////
//���ߣ��⽭
//���ڣ�2015/5/15
//��;��Ԥ��������Ⱦ������
///////////////////////////////////////////////////////////////////////////////

using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class PreviewPlayerRendererCtrl : PlayerRendererCtrl
{
    /// <summary>
    /// �Դ���װ������ ��������ݺ�����ԭ����װ����Ϣ��ͬ������ curShowEquipments��
    /// </summary>
    protected Dictionary<EquipSlot, EquipmentInfo> tryShowEquipments = new Dictionary<EquipSlot, EquipmentInfo>();


    /// <summary>
    /// ��ʼ����Ч
    /// </summary>
    protected override void InitEffects()
    {
        if (fxCtrl == null) return;
        if (tryShowEquipments.Count == 0)
        {
            base.InitEffects();
        }
        else
        {
            foreach (EquipmentInfo item in actorInfo.CurShowDictionary.Values)
            {
				if(item == null)continue;
                if (tryShowEquipments.ContainsKey(item.Slot))
                {
                    EquipmentInfo tryItem = tryShowEquipments[item.Slot];
                    if (tryItem != null && tryItem.BoneEffectList.Count > 0)
                    {
                        for (int i = 0; i < tryItem.BoneEffectList.Count; i++)
                        {
                            fxCtrl.SetBoneEffect(tryItem.BoneEffectList[i].boneName, tryItem.BoneEffectList[i].effectName, actorInfo.ModelScale);
                        }
                    }
                }
                else
                {
                    if (item != null && item.BoneEffectList.Count > 0)
                    {
                        for (int i = 0; i < item.BoneEffectList.Count; i++)
                        {
                            fxCtrl.SetBoneEffect(item.BoneEffectList[i].boneName, item.BoneEffectList[i].effectName, actorInfo.ModelScale);
                        }
                    }
                }
            }
        }
    }

    public void SetCurTryShowEquip(EquipSlot _slot, EquipmentInfo _eq)
    {
        tryShowEquipments[_slot] = _eq;
    }
}
