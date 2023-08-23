using BO.Model;

namespace TpEni.Services;

public class SamouraiServicesImpl : ISamouraiServices
{
    public double GetPotentiel(Samourai samourai)
    {
        return (samourai.Force + (samourai.Arme?.Degats ?? 0)) * (samourai.Techniques.Count + 1);
    }
}