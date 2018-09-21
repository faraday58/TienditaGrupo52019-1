namespace TienditaGrupo52019_1
{
    public interface IMPago
    {
        float Efectivo(float total, float efectivo);
        bool Tarjeta(float total, float saldo, string NumeroTarjeta, string FechaVencimiento, string Cvv);
    }
}
