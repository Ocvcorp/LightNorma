namespace LightNorma.Models.SP52Constants
{
    public class PublicLightNormaSetSP52PublicLightNormaNote
    {
        public int SP52PublicLightNormaNotesId { get; set; }
        public int publicLightNormaSetsId { get; set; }    
        public SP52PublicLightNormaNote SP52PublicLightNormaNote { get; set; }
        public PublicLightNormaSet PublicLightNormaSet { get; set; }

    }
}
