﻿namespace RestauranteMariscos.Entidades
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = "";
        public ICollection<Platillo> Platillos { get; set; } = new List<Platillo>();
        
    }
}
