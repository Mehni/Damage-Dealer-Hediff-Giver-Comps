using Verse;

namespace HediffGiver
{
    public class CompProperties_HediffGiver : CompProperties
    {
        public int damageAmount;
        public DamageDef damageDef;
        public bool affectInteractionCell;
        public bool affectAdjacentCells;
        public bool damagesSelf;
        public int ticksBetweenDamage;

        public CompProperties_HediffGiver() {
			compClass = typeof(CompHediffGiver);
        }
    }
}