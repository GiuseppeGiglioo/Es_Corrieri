namespace Es_Corrieri
{
    public interface IPacco
    {
        double Altezza { get; set; }
        double Larghezza { get; set; }
        double Profondità { get; set; }

        bool equals();
        double printingombro();
    }
}