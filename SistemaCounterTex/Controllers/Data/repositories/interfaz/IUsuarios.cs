﻿    using SistemaCounterTex.Models;
    namespace SistemaCounterTex.Data.repositories.interfaz
{
  public interface IUsuarios
    {
        Task<List<Usuario>> GetUsuarios();
        Task<bool> PostUsuarios(Usuario usuarios);
        Task<bool> PutUsuarios(Usuario usuarios);
        Task<bool> DeleteUsuarios(Usuario usuarios);


    }
}
