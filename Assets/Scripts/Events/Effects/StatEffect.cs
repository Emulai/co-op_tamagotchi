using UnityEngine;

/** The effect of an event which modifies a stat
 * \author Rhys Mader
 * \date 10 Sep 2021
 */
[System.Serializable]
public class StatEffect : Effect
{
	[SerializeField]
	[Tooltip("The stat this effect affects")]
	private DynamicStatName _stat;
	
	[SerializeField]
	[Tooltip("The multiplier to apply to the associated stat")]
	private float _multiplier = 1;
	
	[SerializeField]
	[Tooltip("The adjustment added to the associated stat")]
	private float _adjustment = 0;

	/** Apply this effect to the associated stat of the given object
	\param target The object to modify the stats of
	*/
	public override void Apply(Student target)
	{
		Stat s = target.GetStat(this._stat);
		s.Value *= this._multiplier;
		s.Value += this._adjustment;
	}
}