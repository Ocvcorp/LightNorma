namespace LightNorma.Models.SP52Constants
{
    public class SP52PublicLightRequirementSP52PublicLightNormaNote
    {
        public int SP52PublicLightNormaNotesId { get; set; }
        public int publicLightNormaSetsId { get; set; }    
        public SP52PublicLightNormaNote SP52PublicLightNormaNote { get; set; }
        public SP52PublicLightRequirement SP52PublicLightRequirement { get; set; }

    }
}
