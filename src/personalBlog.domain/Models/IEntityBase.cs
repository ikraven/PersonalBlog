namespace personalBlog.domain.Models;


/// <summary>Interface de tipo base de entidad con ID/summary>
public interface IEntityBase 
{
    /// <summary>Identificador principal de la entidad</summary>
    public Guid Id { get; set; }
}
