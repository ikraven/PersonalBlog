namespace personalBlog.domain.Models;

/// <summary>
/// Clase de elementos comunes
/// </summary>
public class Common
{
    /// <summary>
    /// Estados básicos de entidades
    /// </summary>
    public enum BaseStatus
    {
        /// <summary>
        /// Entidad en estado activo
        /// </summary>
        Active,
        /// <summary>
        /// Entidad en estado inactivo
        /// </summary>
        /// <remarks>Por definición solo deberia usarse si no hay elementos usados</remarks>
        Inactive
    }
}