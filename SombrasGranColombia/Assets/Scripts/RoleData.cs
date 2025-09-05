using UnityEngine;

public enum JugableRol { Criollo, Afrodescendiente, Indigena, MujerRevolucionaria }

[CreateAssetMenu(fileName = "RoleData", menuName = "Sombras/Role Data")]
public class RoleData : ScriptableObject
{
    public JugableRol rol;
    [TextArea] public string descripcion;
    public Sprite icono;
    // Puedes añadir estadísticas o perks aquí
}
