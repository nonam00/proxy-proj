﻿namespace _14._05_2;

public class Order
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public int StatusId { get; set; }
}