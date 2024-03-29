﻿namespace BV212_EF.NET_ADO.DataBase.Tables;

public class OrderRow
{
    public int Id => _primaryKey.Key;
    public DateTime OpenTime {get; set;}
    public int TaskId {get; set;}
    public bool IsCompleted {get; set;}
    public DateTime CloseTime {get; set;}
    public DateTime AcceptedTime {get; set;}

    private readonly PrimaryKey _primaryKey = new PrimaryKey();
}