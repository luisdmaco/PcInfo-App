﻿namespace PCInfo_backend.Recommendations.Resource;

public class MouseResource
{
    public int id { get; set; }
    public string Tasaderepeticion { get; set; }
    public string sensor { get; set; }
    public int DPI { get; set; }
    public string RGB { get; set; }
    public int teclas { get; set; }
    public string tipo { get; set; }
    public ProductoResource producto { get; set; }
}