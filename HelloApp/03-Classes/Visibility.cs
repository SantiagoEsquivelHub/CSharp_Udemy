partial class Program
{
  static void Visibility()
  {
    Jedi jedi = new Jedi();
    jedi.PowerLevel = 5000;
    jedi.LightsaberColor = "blue";

    // jedi.UseForce();
    // WriteLine(jedi.PublicField);
    // WriteLine(jedi.PrivateField);
    // WriteLine(jedi.ProtectedField);
    // jedi.RevealSecrets();

    Sith sith = new Sith();
    sith.PowerLevel = 4000;
    sith.LightsaberColor = "red";
    sith.UseForce();
    // sith.ShowProtected();
  }
}
interface IForceUser
{
  int PowerLevel { get; set; }
  string? LightsaberColor { get; set; }

  void UseForce();
}
class Jedi : IForceUser
{
  public string PublicField = "Soy un Jedi y mi es poder es conocido";

  private string PrivateField = "Mis pensamientos más profundos son privados";

  protected string ProtectedField = "El lado oscuro no debe conocer mis secretos";

  public int PowerLevel { get; set; }
  public string? LightsaberColor { get; set; }

  public void UseForce()
  {
    WriteLine($"Soy un jedi con un sable de  luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
  }

  private void Meditate()
  {
    WriteLine("Estoy en profunda meditación con la fuerza");
  }
  protected void Train()
  {
    WriteLine("Estoy entrenando para convertirme en el mejor Jedi.");
  }
  public void RevealSecrets()
  {
    WriteLine(ProtectedField);
    WriteLine(PrivateField);
    Meditate();
  }
}
class Sith : Jedi, IForceUser
{
  public new void UseForce()
  {
    WriteLine($"Soy un Sith con un sable de  luz {LightsaberColor} y mi nivel de poder es: {PowerLevel}");
  }
  public void ShowProtected()
  {
    WriteLine(ProtectedField);
    Train();
  }
}