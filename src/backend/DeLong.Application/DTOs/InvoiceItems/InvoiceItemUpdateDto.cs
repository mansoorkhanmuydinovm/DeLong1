﻿namespace DeLong.Application.DTOs.InvoiceItems;

public class InvoiceItemUpdateDto
{
    public long Id { get; set; }
    public int InvoiceId { get; set; }
    public int ProductId { get; set; }
    public decimal Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}