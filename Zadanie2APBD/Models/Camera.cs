namespace Zadanie2APBD;

public class Camera : Equipment
{
    public int Megapixels { get; set; }
    public bool IsMirrorless { get; set; }

    public Camera(string name, int megapixels, bool isMirrorless) : base(name)
    {
        Megapixels = megapixels;
        IsMirrorless = isMirrorless;
    }
}