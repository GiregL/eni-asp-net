using BO.Model;

namespace TpEni.Models;

public class CreateSamouraiModelView : Samourai
{
    public List<int> IdsArtsMartiauxChoisis { get; set; } = new();
}